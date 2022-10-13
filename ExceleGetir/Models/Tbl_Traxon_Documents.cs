//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExceleGetir.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Traxon_Documents
    {
        public int ID { get; set; }
        public Nullable<int> POZID { get; set; }
        public Nullable<int> LOADID { get; set; }
        public string SENDER_PIMA { get; set; }
        public string RECEIVER_PIMA { get; set; }
        public string MBL_NO { get; set; }
        public string MESSAGE_TYPE { get; set; }
        public string FLIGHT_DATE { get; set; }
        public string DEPARTURE_PORT_CODE { get; set; }
        public string DEPARTURE_PORT { get; set; }
        public string ARRIVAL_PORT_CODE { get; set; }
        public string ARRIVAL_PORT { get; set; }
        public string VOYAGE_NO { get; set; }
        public string CARRIER { get; set; }
        public string CARRIER_CODE { get; set; }
        public string SHIPPER_NAME { get; set; }
        public string SHIPPER_ADDRESS { get; set; }
        public string SHIPPER_CITY { get; set; }
        public string SHIPPER_COUNTRY_CODE { get; set; }
        public string SHIPPER_ZIP { get; set; }
        public string SHIPPER_TAX { get; set; }
        public string CONSIGNEE_NAME { get; set; }
        public string CONSIGNEE_ADDRESS { get; set; }
        public string CONSIGNEE_CITY { get; set; }
        public string CONSIGNEE_COUNTRY_CODE { get; set; }
        public string CONSIGNEE_ZIP { get; set; }
        public string CONSIGNEE_TAX { get; set; }
        public string NOTIFY_NAME { get; set; }
        public string NOTIFY_ADDRESS { get; set; }
        public string NOTIFY_CITY { get; set; }
        public string NOTIFY_COUNTRY_CODE { get; set; }
        public string NOTIFY_ZIP { get; set; }
        public string AGENT_IATA_CODE { get; set; }
        public string AGENT_IATA_NAME { get; set; }
        public string AGENT_IATA_CITY { get; set; }
        public string ACCOUNTING_INFO { get; set; }
        public string CURRENCY { get; set; }
        public string CHARGECODE { get; set; }
        public string WEIGHT_PC { get; set; }
        public string OTHER_PC { get; set; }
        public string DECLARED_VALUE_CARRIER { get; set; }
        public string DECLARED_VALUE_CUSTOMS { get; set; }
        public string INSURANCE { get; set; }
        public string HANDLING_INFO { get; set; }
        public string OTHER_CHARGES { get; set; }
        public string WEIGHT_CHARGE { get; set; }
        public string AGENT_CHARGES { get; set; }
        public string CARRIER_CHARGES { get; set; }
        public string TOTAL_CHARGE { get; set; }
        public string SPH_CODES { get; set; }
        public Nullable<System.DateTime> CREATION_DATE { get; set; }
        public string CREATION_PLACE { get; set; }
        public string COMPLETE_MESSAGE { get; set; }
        public Nullable<int> STATUS { get; set; }
        public string RETURN_MESSAGE { get; set; }
        public Nullable<int> PAPER_BL { get; set; }
        public string GENERAL_DESC { get; set; }
        public string TRANSFERLINE1CODE { get; set; }
        public string TRANSFERPORT1CODE { get; set; }
        public string TRANSFERLINE2CODE { get; set; }
        public string TRANSFERPORT2CODE { get; set; }
        public string CARRIER_ADDRESS { get; set; }
    }
}