using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;
using Edi_Parsing;
using Edi_Parsing.Models;
using Parser;

namespace Parsing
{
    class Program
    {
        private static readonly string EndpointUri = "https://localhost:8081";
        private static readonly string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";
        private static readonly string DatabaseId = "EDIParser";
        private static readonly string ContainerId = "EDIContainers";

        static async Task Main(string[] args)
        {
            string filepath = @"C:\Users\VidhyaSreeChinthalap\Desktop\EDI3.txt";
            string outputfilepath = @"C:\Users\VidhyaSreeChinthalap\Desktop\Out3.txt";

            File.WriteAllText(outputfilepath, "");

            try
            {
                Segments segments = new Segments();
                string[] filedata = File.ReadAllLines(filepath);
                B4 b4 = new B4();
                foreach (string line in filedata)
                {
                    Console.WriteLine(line);
                    string[] linedata = line.Split('*');

                    if (linedata.Length == 0) continue;

                    if (linedata[0] == "ISA")
                    {
                        Isa isa = Parse.ParseIsaSegment(linedata);
                        segments.isaSegment = isa;
                    }
                    else if (linedata[0] == "GS")
                    {
                        Gs gs = Parse.ParseGsSegment(linedata);
                        segments.gsSegment = gs;
                    }
                    else if (linedata[0] == "ST")
                    {
                        St st = Parse.ParseStSegment(linedata);
                        segments.stSegment.Add(st);
                    }
                    else if (linedata[0] == "B4")
                    {
                        if (segments.stSegment.Count > 0)
                        {
                            St lastSt = segments.stSegment[segments.stSegment.Count - 1];
                            b4 = Parse.ParseB4Segment(linedata);
                            lastSt.ContainerNumber = b4.EquipmentInitial + b4.EquipmentNumber;
                            if (b4 != null)
                            {
                                lastSt.b4Segment.Add(b4);
                            }
                        }
                    }
                    else if (linedata[0] == "N9")
                    {
                        if (segments.stSegment.Count > 0)
                        {
                            St lastSt = segments.stSegment[segments.stSegment.Count - 1];

                            N9 n9 = Parse.ParseN9Segment(linedata);

                            if (n9 != null)
                            {
                                lastSt.n9Segment.Add(n9);
                            }
                        }
                    }
                    else if (linedata[0] == "Q2")
                    {
                        if (segments.stSegment.Count > 0)
                        {
                            St lastSt = segments.stSegment[segments.stSegment.Count - 1];
                            Q2 q2 = Parse.ParseQ2Segment(linedata);
                            if (q2 != null)
                            {
                                lastSt.q2Segment = q2;
                            }
                        }
                    }
                    else if (linedata[0] == "SG")
                    {
                        if (segments.stSegment.Count > 0)
                        {
                            St lastSt = segments.stSegment[segments.stSegment.Count - 1];
                            Sg sg = Parse.ParseSgSegment(linedata);
                            if (sg != null)
                            {
                                lastSt.sgSegment.Add(sg);
                            }
                        }
                    }
                    else if (linedata[0] == "R4")
                    {
                        if (segments.stSegment.Count > 0)
                        {
                            St lastSt = segments.stSegment[segments.stSegment.Count - 1];
                            R4 r4 = Parse.ParseR4Segment(linedata);
                            if (r4 != null)
                            {
                                lastSt.r4Segment.Add(r4);
                            }
                        }
                    }
                    else if (linedata[0] == "SE")
                    {
                        St lastSt = segments.stSegment[segments.stSegment.Count - 1];
                        Se se = Parse.ParseSeSegment(linedata);
                        if (se != null)
                        {
                            lastSt.seSegment = se;
                        }
                    }
                    else if (linedata[0] == "GE")
                    {
                        Ge ge = Parse.ParseGeSegment(linedata);
                        segments.geSegment = ge;
                    }
                    else if (linedata[0] == "IEA")
                    {
                        Iea iea = Parse.ParseIeaSegment(linedata);
                        segments.ieaSegment = iea;
                    }
                }

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                };

                string output = JsonSerializer.Serialize(segments, options);

                File.WriteAllText(outputfilepath, output);
                Console.WriteLine("The file is parsed successfully. Check the output at: " + outputfilepath);

                await StoreInCosmosDbAsync(segments);
                Console.WriteLine("Data Stored in DB successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private static async Task StoreInCosmosDbAsync(Segments segments)
        {
            try
            {
                using CosmosClient client = new CosmosClient(EndpointUri, PrimaryKey);
                Database database = await client.CreateDatabaseIfNotExistsAsync(DatabaseId);

                // Check if the container exists or needs to be created
                Container container = await database.CreateContainerIfNotExistsAsync(ContainerId, "/containerNumber");

                // Now store data in the container
                foreach (var item in segments.stSegment)
                {
                    var cosmosItem = new
                    {
                        id = Guid.NewGuid().ToString(),
                        // EDIData = segments,
                        containerNumber = item.ContainerNumber,
                        TradeType=item.b4Segment.First().SpecialHandlingCode,
                        Status=item.b4Segment.First().ShipmentStatusCode,
                        VesselName=item.q2Segment.Vessel_Name,
                        VesselCode = item.q2Segment.Vessel_Code,
                        Voyage=item.q2Segment.Flight_Number,
                        Origin=item.r4Segment.First().Port_Name,
                        Destination=item.r4Segment.Last().Port_Name,
                        Line=item.n9Segment.First().Reference_Identification_Qualifier,
                        SizeType=item.b4Segment.First().EquipmentType,
                    };

                    await container.CreateItemAsync(cosmosItem, new PartitionKey(cosmosItem.containerNumber));
                    Console.WriteLine("Segment data saved to Cosmos DB successfully.");
                }
            }
            catch (CosmosException ex)
            {
                Console.WriteLine($"Error saving data to Cosmos DB: {ex.Message}");
            }


        }
    }
}
