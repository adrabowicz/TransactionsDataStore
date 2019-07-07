using System;
using System.Collections.Generic;
using CommonData;
using CommonData.Metadata;

namespace DataService
{
    public static class TransactionDataFactory
    {
        public static List<AppTile> AddTransactionData(List<Encounter> encounters, int maxTransactionsPerEncounter, DateTime startDate, DateTime endDate)
        {
            var appTiles = new List<AppTile>();
            
            var random = new Random(Guid.NewGuid().GetHashCode());

            var personData = PartyDataFactory.CreatePersonData(100);
            var medicationData = MedDataFactory.CreateMedicationData();

            for (var i = 0; i < encounters.Count; i++)
            {
                var dateString = DataUtility.FormatCurrentDateTime();
                var transactionsPerEncounter = random.Next(1, maxTransactionsPerEncounter);

                var appTile = new AppTile
                {
                    Id = Guid.NewGuid().ToString(),
                    BatchId = string.Empty,
                    RunId = string.Empty,
                    TimestampLocal = DateTime.Now,
                    TimestampUtc = DateTime.UtcNow,
                    ClientKey = 0,
                    SourceId = random.Next(1, 40).ToString(),
                    DispenseTransactionKey = 0,
                    EncounterId = encounters[i].EncounterId,
                    MedId = random.Next(1, 8).ToString(),
                    StationName = string.Empty,
                    OrderAmount = null,
                    OrderUnits = null,
                };

                appTile.AppTransactions = new List<AppTileTransaction>();

                for (var j = 0; j < transactionsPerEncounter; j++)
                {
                    var transaction = new AppTileTransaction();

                    transaction.RelatedTransactionKey = 0;

                    var encounterStartDate = DataUtility.GetRandomDateTime(random, startDate, endDate);
                    transaction.TransactionDateTime = encounterStartDate;

                    transaction.TransactionType = ((TransactionTypeEnum)random.Next(1, 5)).ToString();
                    transaction.TransactionAmount = random.Next(1, 10000);
                    transaction.TransactionUnits = string.Empty;

                    transaction.PartyId = random.Next(1, 99).ToString();

                    appTile.AppTransactions.Add(transaction);
                }

                appTiles.Add(appTile);
            }

            return appTiles;
        }
    }
}
