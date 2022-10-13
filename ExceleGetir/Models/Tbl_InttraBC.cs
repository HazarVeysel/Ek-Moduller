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
    
    public partial class Tbl_InttraBC
    {
        public int ID { get; set; }
        public Nullable<int> POZ_ID { get; set; }
        public string SHIPMENT_ID { get; set; }
        public string REZ_SHIPMENT_ID { get; set; }
        public string TRANSACTION_TYPE { get; set; }
        public string TRANSACTION_STATUS { get; set; }
        public Nullable<System.DateTime> TRANSACTION_DATE { get; set; }
        public string FILENAME { get; set; }
        public string CarrierComments { get; set; }
        public string ConfirmatoryName { get; set; }
        public string ConfirmatoryEmail { get; set; }
        public Nullable<System.DateTime> ShipmentInstructionDueDate { get; set; }
        public string FreightTariffNumber { get; set; }
        public string ContractPartyReferenceNumber { get; set; }
        public string OutboundBookingAgentRefNumber { get; set; }
        public string VehicleIdentificationNumber { get; set; }
        public string ConsigneeReferenceNumber { get; set; }
        public string BillOfLadingNumber { get; set; }
        public string BookingNumber { get; set; }
        public string LocalBookingNumber { get; set; }
        public string ContractNumber { get; set; }
        public string FreightForwarderRefNumber { get; set; }
        public string ContractLineItemNumber { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string ContainerReleaseNumber { get; set; }
        public string ShipperReferenceNumber { get; set; }
        public string INTTRAReferenceNumber { get; set; }
        public string INTTRAShippingInstructionNumber { get; set; }
        public string StockKeepingUnit { get; set; }
        public string InternalTransactionNumber { get; set; }
        public string VesselName { get; set; }
        public string LloydsCode { get; set; }
        public string VoyageNumber { get; set; }
        public string SCACCode { get; set; }
        public string PortOfLoad { get; set; }
        public string PortOfLoadCode { get; set; }
        public Nullable<System.DateTime> POLEarliestDeparture { get; set; }
        public Nullable<System.DateTime> POLLatestDelivery { get; set; }
        public string PortOfDischarge { get; set; }
        public string PortOfDischargeCode { get; set; }
        public Nullable<System.DateTime> PODEstimatedArrival { get; set; }
        public string VesselName1 { get; set; }
        public string LloydsCode1 { get; set; }
        public string VoyageNumber1 { get; set; }
        public string SCACCode1 { get; set; }
        public string PortOfLoad1 { get; set; }
        public string PortOfLoadCode1 { get; set; }
        public Nullable<System.DateTime> POLEarliestDeparture1 { get; set; }
        public Nullable<System.DateTime> POLLatestDelivery1 { get; set; }
        public string PortOfDischarge1 { get; set; }
        public string PortOfDischargeCode1 { get; set; }
        public Nullable<System.DateTime> PODEstimatedArrival1 { get; set; }
        public Nullable<int> ARCHIVED { get; set; }
        public Nullable<int> RezervasyonID { get; set; }
    }
}
