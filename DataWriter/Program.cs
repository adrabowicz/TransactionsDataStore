using System;
using DataService;
using DataWriterService;

namespace DataWriter
{
    public static class Program
    {
        static DateTime startDate = new DateTime(2018, 7, 1);
        static DateTime endDate = new DateTime(2018, 7, 31);

        static void Main(string[] args)
        {
            //SaveMedicationData();

            //SaveEncounterData();

            SaveTransactionData();
        }

        private static void SaveMedicationData()
        {
            var fileNameWithPath = @"C:\Junk\med-data.json";
            var data = MedDataFactory.CreateMedicationData();
            FileWriter.SaveDataToJsonFile(data, fileNameWithPath);
        }

        private static void SaveEncounterData()
        {
            var jsonFileName = @"C:\Junk\encounter-data.json";
            var textFileName = @"C:\Junk\encounter-data.txt";

            var data = EncounterDataFactory.CreateEncounterData(100, startDate, endDate);
            FileWriter.SaveDataToJsonFile(data, jsonFileName);
            FileWriter.SaveEncounterDataToTextFile(data, textFileName);
        }

        private static void SaveTransactionData()
        {
            var jsonFileName = @"C:\Junk\transaction-data.json";
            var textFileName = @"C:\Junk\transaction-data.txt";

            var encounters = EncounterDataFactory.CreateEncounterData(100, startDate, endDate);
            var transactions = TransactionDataFactory.AddTransactionData(encounters, 10, startDate, endDate);
            FileWriter.SaveDataToJsonFile(transactions, jsonFileName);
            //FileWriter.SaveEncounterDataToTextFile(data, textFileName);
        }
    }
}
