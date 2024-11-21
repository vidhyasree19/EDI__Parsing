using System.Data.SqlTypes;
using System.Reflection.Metadata.Ecma335;

using Edi_Parsing.Models;

namespace Parser
{
    public static class Parse
    {
        public static Isa ParseIsaSegment(string[] linedata)
        {
            Isa isa = new Isa();

            if (linedata.Length >= 16)
            {
                isa.Authorization_Information_Qualifer = !string.IsNullOrWhiteSpace(linedata[1]) ? linedata[1].Trim() : null;
                isa.Authorization_Information = !string.IsNullOrWhiteSpace(linedata[2]) ? linedata[2].Trim() : null;
                isa.Security_Information_Qualifer = !string.IsNullOrWhiteSpace(linedata[3]) ? linedata[3].Trim() : null;
                isa.Security_Information = !string.IsNullOrWhiteSpace(linedata[4]) ? linedata[4].Trim() : null;
                isa.Interchange_Id_Qualifier = !string.IsNullOrWhiteSpace(linedata[5]) ? linedata[5].Trim() : null;
                isa.Interchange_Sender_Qualifier = !string.IsNullOrWhiteSpace(linedata[6]) ? linedata[6].Trim() : null;
                isa.Interchange_Id_Qualifier_Receiver = !string.IsNullOrWhiteSpace(linedata[7]) ? linedata[7].Trim() : null;
                isa.Interchange_Receiver_Id = !string.IsNullOrWhiteSpace(linedata[8]) ? linedata[8].Trim() : null;
                isa.Date = !string.IsNullOrWhiteSpace(linedata[9]) ? linedata[9].Trim() : null;
                isa.Time = !string.IsNullOrWhiteSpace(linedata[10]) ? linedata[10].Trim() : null;
                isa.Interchange_Control_Standard_Id_Code = !string.IsNullOrWhiteSpace(linedata[11]) ? linedata[11].Trim() : null;
                isa.Interchange_Version = !string.IsNullOrWhiteSpace(linedata[12]) ? linedata[12].Trim() : null;
                isa.Interchange_Control_Nbr = !string.IsNullOrWhiteSpace(linedata[13]) ? linedata[13].Trim() : null;
                isa.Acknowledgement_Requested = !string.IsNullOrWhiteSpace(linedata[14]) ? linedata[14].Trim() : null;
                isa.Test_Indicator = !string.IsNullOrWhiteSpace(linedata[15]) ? linedata[15].Trim() : null;
                isa.Sub_Element_Separator = !string.IsNullOrWhiteSpace(linedata[16]) ? linedata[16].Trim() : null;
            }

            return isa;
        }
        public static Gs ParseGsSegment(string[] linedata)
        {
            Gs gs = new Gs();

            if (linedata.Length >= 9)
            {
                gs.Functional_Identifier_Code = !string.IsNullOrWhiteSpace(linedata[1]) ? linedata[1].Trim() : null;
                gs.Functional_Senders_Code = !string.IsNullOrWhiteSpace(linedata[2]) ? linedata[2].Trim() : null;
                gs.Functional_Receivers_Code = !string.IsNullOrWhiteSpace(linedata[3]) ? linedata[3].Trim() : null;
                gs.Group_Date = !string.IsNullOrWhiteSpace(linedata[4]) ? linedata[4].Trim() : null;
                gs.Group_Time = !string.IsNullOrWhiteSpace(linedata[5]) ? linedata[5].Trim() : null;
                gs.Group_Control_Number = !string.IsNullOrWhiteSpace(linedata[6]) ? linedata[6].Trim() : null;
                gs.Responsible_Agency_Code = !string.IsNullOrWhiteSpace(linedata[7]) ? linedata[7].Trim() : null;
                gs.Version = !string.IsNullOrWhiteSpace(linedata[8]) ? linedata[8].Trim() : null;
            }

            return gs;
        }

        public static St ParseStSegment(string[] linedata)
        {
            St st = new St();

            if (linedata.Length >= 2)
            {
                st.ContainerNumber = !string.IsNullOrWhiteSpace(linedata[0]) ? linedata[0].Trim() : null;

                st.Transaction_Set_Identifier_Code = !string.IsNullOrWhiteSpace(linedata[1]) ? linedata[1].Trim() : null;
                st.Transaction_Set_Control_Number = !string.IsNullOrWhiteSpace(linedata[2]) ? linedata[2].Trim() : null;
            }

            return st;
        }


        public static B4 ParseB4Segment(string[] linedata)
        {
            B4 b4 = new B4();
           

            if (linedata.Length >= 2)
            {


                b4.SpecialHandlingCode = !string.IsNullOrWhiteSpace(linedata.Length > 1 ? linedata[1].Trim() : null) ? linedata[1].Trim() : null;
                b4.InquiryRequestNumber = !string.IsNullOrWhiteSpace(linedata.Length > 2 ? linedata[2].Trim() : null) ? linedata[2].Trim() : null;
                b4.ShipmentStatusCode = !string.IsNullOrWhiteSpace(linedata.Length > 3 ? linedata[3].Trim() : null) ? linedata[3].Trim() : null;
                b4.ReleaseDate = !string.IsNullOrWhiteSpace(linedata.Length > 4 ? linedata[4].Trim() : null) ? linedata[4].Trim() : null;
                b4.ReleaseTime = !string.IsNullOrWhiteSpace(linedata.Length > 5 ? linedata[5].Trim() : null) ? linedata[5].Trim() : null;
                b4.StatusLocation = !string.IsNullOrWhiteSpace(linedata.Length > 6 ? linedata[6].Trim() : null) ? linedata[6].Trim() : null;
                b4.EquipmentInitial = !string.IsNullOrWhiteSpace(linedata.Length > 7 ? linedata[7].Trim() : null) ? linedata[7].Trim() : null;
                b4.EquipmentNumber =!string.IsNullOrWhiteSpace(linedata.Length > 8 ? linedata[8].Trim() : null) ? linedata[8].Trim() : null;
                b4.EquipmentStatusCode = !string.IsNullOrWhiteSpace(linedata.Length > 9 ? linedata[9].Trim() : null) ? linedata[9].Trim() : null;
                b4.EquipmentType = !string.IsNullOrWhiteSpace(linedata.Length > 10 ? linedata[10].Trim() : null) ? linedata[10].Trim() : null;
                b4.LocationIdentifier = !string.IsNullOrWhiteSpace(linedata.Length > 11 ? linedata[11].Trim() : null) ? linedata[11].Trim() : null;
                b4.LocationQualifier = !string.IsNullOrWhiteSpace(linedata.Length > 12 ? linedata[11].Trim() : null) ? linedata[12].Trim() : null;
                b4.DateTime = !string.IsNullOrWhiteSpace(linedata.Length > 13 ? linedata[12].Trim() : null) ? linedata[13].Trim() : null;
            }

            return b4;
        }


        public static N9 ParseN9Segment(string[] linedata)
        {
            N9 n9 = new N9();

            if (linedata.Length >= 2)
            {
                n9.Reference_Identification_Qualifier = !string.IsNullOrWhiteSpace(linedata.Length > 1 ? linedata[1].Trim() : null) ? linedata[1].Trim() : null;
                n9.Reference_Identification = !string.IsNullOrWhiteSpace(linedata.Length > 2 ? linedata[2].Trim() : null) ? linedata[2].Trim() : null;
                n9.Free_Form_Identification = !string.IsNullOrWhiteSpace(linedata.Length > 3 ? linedata[3].Trim() : null) ? linedata[3].Trim() : null;
                n9.Date = !string.IsNullOrWhiteSpace(linedata.Length > 4 ? linedata[4].Trim() : null) ? linedata[4].Trim() : null;
                n9.Time = !string.IsNullOrWhiteSpace(linedata.Length > 5 ? linedata[5].Trim() : null) ? linedata[5].Trim() : null;
                n9.Time_Code = !string.IsNullOrWhiteSpace(linedata.Length > 6 ? linedata[6].Trim() : null) ? linedata[6].Trim() : null;
                n9.Reference__Identification_Qualifier = !string.IsNullOrWhiteSpace(linedata.Length > 7 ? linedata[7].Trim() : null) ? linedata[7].Trim() : null;
                n9.Reference__Identification = !string.IsNullOrWhiteSpace(linedata.Length > 8 ? linedata[8].Trim() : null) ? linedata[8].Trim() : null;
                n9.Free_Form_Identification_Qualifier = !string.IsNullOrWhiteSpace(linedata.Length > 9 ? linedata[9].Trim() : null) ? linedata[9].Trim() : null;
                n9.Reference_Identification1 = !string.IsNullOrWhiteSpace(linedata.Length > 10 ? linedata[10].Trim() : null) ? linedata[10].Trim() : null;
                n9.Free_Form_Identification_Qualifier1 = !string.IsNullOrWhiteSpace(linedata.Length > 11 ? linedata[11].Trim() : null) ? linedata[11].Trim() : null;
                n9.Reference_Identification_ = !string.IsNullOrWhiteSpace(linedata.Length > 12 ? linedata[12].Trim() : null) ? linedata[12].Trim() : null;
                n9.DateTime = !string.IsNullOrWhiteSpace(linedata.Length > 13 ? linedata[13].Trim() : null) ? linedata[13].Trim() : null;
            }


            return n9;
        }

        public static Q2 ParseQ2Segment(string[] linedata)
        {
            Q2 q2 = new Q2();

            if (linedata.Length >= 2)
            {
                q2.Vessel_Code = !string.IsNullOrWhiteSpace(linedata.Length > 1 ? linedata[1] : null) ? linedata[1].Trim() : null;
                q2.Country_Code = !string.IsNullOrWhiteSpace(linedata.Length > 2 ? linedata[2] : null) ? linedata[2].Trim() : null;
                q2.Date = !string.IsNullOrWhiteSpace(linedata.Length > 3 ? linedata[3] : null) ? linedata[3].Trim() : null;
                q2.Date1 = !string.IsNullOrWhiteSpace(linedata.Length > 4 ? linedata[4] : null) ? linedata[4].Trim() : null;
                q2.Date2 = !string.IsNullOrWhiteSpace(linedata.Length > 5 ? linedata[5] : null) ? linedata[5].Trim() : null;
                q2.Lading_Quantity = !string.IsNullOrWhiteSpace(linedata.Length > 6 ? linedata[6] : null) ? linedata[6].Trim() : null;
                q2.Weight = !string.IsNullOrWhiteSpace(linedata.Length > 7 ? linedata[7] : null) ? linedata[7].Trim() : null;
                q2.Weight_Qualifier = !string.IsNullOrWhiteSpace(linedata.Length > 8 ? linedata[8] : null) ? linedata[8].Trim() : null;
                q2.Flight_Number = !string.IsNullOrWhiteSpace(linedata.Length > 9 ? linedata[9] : null) ? linedata[9].Trim() : null;
                q2.Reference_Identification_Qualifier = !string.IsNullOrWhiteSpace(linedata.Length > 10 ? linedata[10] : null) ? linedata[10].Trim() : null;
                q2.Reference_Identification = !string.IsNullOrWhiteSpace(linedata.Length > 11 ? linedata[11] : null) ? linedata[11].Trim() : null;
                q2.Vessel_Code_Qualifier = !string.IsNullOrWhiteSpace(linedata.Length > 12 ? linedata[12] : null) ? linedata[12].Trim() : null;
                q2.Vessel_Name = !string.IsNullOrWhiteSpace(linedata.Length > 13 ? linedata[13] : null) ? linedata[13].Trim() : null;
                q2.Volume = !string.IsNullOrWhiteSpace(linedata.Length > 14 ? linedata[14] : null) ? linedata[14].Trim() : null;
                q2.Volume_Unit_Qualifier = !string.IsNullOrWhiteSpace(linedata.Length > 15 ? linedata[15] : null) ? linedata[15].Trim() : null;
                q2.Weight_Unit_Code = !string.IsNullOrWhiteSpace(linedata.Length > 16 ? linedata[16] : null) ? linedata[16].Trim() : null;
            }

            return q2;
        }

        public static Sg ParseSgSegment(string[] linedata)
        {
            Sg sg = new Sg();
            if (linedata.Length > 2)
            {
                sg.Shipment_Status_Code = !string.IsNullOrWhiteSpace(linedata.Length > 1 ? linedata[1] : null) ? linedata[1].Trim() : null;
                sg.Status_Reason_Code = !string.IsNullOrWhiteSpace(linedata.Length > 2 ? linedata[2] : null) ? linedata[2].Trim() : null;
                sg.Dispostion_Code = !string.IsNullOrWhiteSpace(linedata.Length > 3 ? linedata[3] : null) ? linedata[3].Trim() : null;
                sg.Date = !string.IsNullOrWhiteSpace(linedata.Length > 4 ? linedata[4] : null) ? linedata[4].Trim() : null;
                sg.Time = !string.IsNullOrWhiteSpace(linedata.Length > 5 ? linedata[5] : null) ? linedata[5].Trim() : null;
                sg.Time_Code = !string.IsNullOrWhiteSpace(linedata.Length > 6 ? linedata[6] : null) ? linedata[6].Trim() : null;
                sg.DateTime = !string.IsNullOrWhiteSpace(linedata.Length > 7 ? linedata[7] : null) ? linedata[7].Trim() : null;
            }
            return sg;
        }

        public static R4 ParseR4Segment(string[] linedata)
        {
            R4 r4 = new R4();
            if (linedata.Length > 2)
            {
                r4.Port_Or_Terminal_Function_Code = !string.IsNullOrWhiteSpace(linedata.Length > 1 ? linedata[1] : null) ? linedata[1].Trim() : null;
                r4.Location_Qualifier = !string.IsNullOrWhiteSpace(linedata.Length > 2 ? linedata[2] : null) ? linedata[2].Trim() : null;
                r4.Location_Identifier = !string.IsNullOrWhiteSpace(linedata.Length > 3 ? linedata[3] : null) ? linedata[3].Trim() : null;
                r4.Port_Name = !string.IsNullOrWhiteSpace(linedata.Length > 4 ? linedata[4] : null) ? linedata[4].Trim() : null;
                r4.Country_Code = !string.IsNullOrWhiteSpace(linedata.Length > 5 ? linedata[5] : null) ? linedata[5].Trim() : null;
                r4.Terminal_Name = !string.IsNullOrWhiteSpace(linedata.Length > 6 ? linedata[6] : null) ? linedata[6].Trim() : null;
                r4.Pier_Number = !string.IsNullOrWhiteSpace(linedata.Length > 7 ? linedata[7] : null) ? linedata[7].Trim() : null;
                r4.State_or_Province_Code = !string.IsNullOrWhiteSpace(linedata.Length > 8 ? linedata[8] : null) ? linedata[8].Trim() : null;
            }
            return r4;
        }


        public static Se ParseSeSegment(string[] linedata)
        {
            Se se = new Se();
            if (linedata.Length > 2)
            {
                se.Number_Of_Included_Segments = !string.IsNullOrWhiteSpace(linedata.Length > 1 ? linedata[1] : null) ? linedata[1].Trim() : null;
                se.Transaction_Set_Control_Number = !string.IsNullOrWhiteSpace(linedata.Length > 2 ? linedata[2] : null) ? linedata[2].Trim() : null;
            }
            return se;
        }

        public static Ge ParseGeSegment(string[] linedata)
        {
            Ge ge = new Ge();
            if (linedata.Length >= 2)
            {
                ge.Number_Of_Transaction_Sets_Included = !string.IsNullOrWhiteSpace(linedata.Length > 1 ? linedata[1] : null) ? linedata[1].Trim() : null;
                ge.Group_Control_Number = !string.IsNullOrWhiteSpace(linedata.Length > 2 ? linedata[2] : null) ? linedata[2].Trim() : null;
            }
            return ge;
        }


        public static Iea ParseIeaSegment(string[] linedata)
        {
            Iea iea = new Iea();
            if (linedata.Length >= 2)
            {
                iea.Number_Of_Included_Functional_Groups = !string.IsNullOrWhiteSpace(linedata.Length > 1 ? linedata[1] : null) ? linedata[1].Trim() : null;
                iea.Interchange_Control_Number = !string.IsNullOrWhiteSpace(linedata.Length > 2 ? linedata[2] : null) ? linedata[2].Trim() : null;
            }
            return iea;
        }




    }
}