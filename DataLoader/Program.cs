using System;
using DataLoaderService;
using DataService;

namespace DataLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadTransactionDataIntoIndex();
        }

        private static void LoadTransactionDataIntoIndex()
        {
            MessageClient.SetupElasticClient();

            var startDate = new DateTime(2019, 6, 1);
            var endDate = new DateTime(2019, 7, 1);

            var encounters = EncounterDataFactory.CreateEncounterData(100, startDate, endDate);
            var data = TransactionDataFactory.AddTransactionData(encounters, 8, startDate, endDate);
            MessageClient.LoadTransactionDataIntoIndex(data);
        }

        private static void LoadPersonDataIntoIndex()
        {
            MessageClient.SetupElasticClient();

            var data = PartyDataFactory.CreatePersonData(100);
            MessageClient.LoadPersonDataIntoIndex(data);
        }
    }
}
