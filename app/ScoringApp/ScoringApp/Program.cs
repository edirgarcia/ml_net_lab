using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.ML;
using Microsoft.ML.Data;

namespace ScoringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ML.NET Scoring dead simple example");
            Score();
        }


        public static void Score()
        {
            var modelPath = "../../../../../../models/ml_net_taxi_csharp.zip";
            // what about the nimbus model?
            //var modelPath = "../../../../../../models/ml_net_taxi_python.zip";
            var mlContext = new MLContext();
            var loadedModel = mlContext.Model.Load(modelPath, out DataViewSchema inputSchema);

            var example = new List<TaxiTrip>()
            {
                new TaxiTrip()
                {
                    VendorId = "CMT",
                    RateCode = "1",
                    PassengerCount = 1,
                    TripTime = 1271,
                    TripDistance = 3.8F,
                    PaymentType = "CRD"
                }
            };

            // load data into IDataView
            var loadedData = mlContext.Data.LoadFromEnumerable(example);

            var predictionDataView = loadedModel.Transform(loadedData);

            // convert IDataView predictions to IEnumerable
            var prediction = mlContext.Data
                .CreateEnumerable<TaxiTripFarePrediction>(predictionDataView,
                reuseRowObject: false).ToList();

            foreach (var p in prediction)
            {
                //Console.WriteLine("Predicting TaxiTrip: " );
                Console.WriteLine($"PredictedScore: {p.Score}");
            }
        }
    }


    // Does this look familiar? yes it's the same plain oject from the C# notebook, or the schema in the NimbusML notebook
    // so this can be common code referenced in the notebook and here
    // For Microsoft internal audience: Doesn't this look an awful loot like CCS PredictionInput? it's the same only fully customizable in schema!
    // And actually CCS is already able to load this on the Common.ML framework.
    public class TaxiTrip
    {
        [LoadColumn(0)]
        public string VendorId;

        [LoadColumn(1)]
        public string RateCode;

        [LoadColumn(2)]
        public float PassengerCount;

        [LoadColumn(3)]
        public float TripTime;

        [LoadColumn(4)]
        public float TripDistance;

        [LoadColumn(5)]
        public string PaymentType;

        [LoadColumn(6)]
        public float FareAmount;
    }

    public class TaxiTripFarePrediction
    {
        [ColumnName("Score")]
        public float Score;
    }
}
