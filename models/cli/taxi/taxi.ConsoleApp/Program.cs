//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using System;
using Taxi.Model;

namespace Taxi.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                VendorId = @"CMT",
                RateCode = 1F,
                PassengerCount = 1F,
                TripTime = 1271F,
                TripDistance = 3.8F,
                PaymentType = @"CRD",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual FareAmount with predicted FareAmount from sample data...\n\n");
            Console.WriteLine($"VendorId: {sampleData.VendorId}");
            Console.WriteLine($"RateCode: {sampleData.RateCode}");
            Console.WriteLine($"PassengerCount: {sampleData.PassengerCount}");
            Console.WriteLine($"TripTime: {sampleData.TripTime}");
            Console.WriteLine($"TripDistance: {sampleData.TripDistance}");
            Console.WriteLine($"PaymentType: {sampleData.PaymentType}");
            Console.WriteLine($"\n\nPredicted FareAmount: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
