//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace Taxi.Model
{
    public class ModelInput
    {
        [ColumnName("VendorId"), LoadColumn(0)]
        public string VendorId { get; set; }


        [ColumnName("RateCode"), LoadColumn(1)]
        public float RateCode { get; set; }


        [ColumnName("PassengerCount"), LoadColumn(2)]
        public float PassengerCount { get; set; }


        [ColumnName("TripTime"), LoadColumn(3)]
        public float TripTime { get; set; }


        [ColumnName("TripDistance"), LoadColumn(4)]
        public float TripDistance { get; set; }


        [ColumnName("PaymentType"), LoadColumn(5)]
        public string PaymentType { get; set; }


        [ColumnName("FareAmount"), LoadColumn(6)]
        public float FareAmount { get; set; }


    }
}
