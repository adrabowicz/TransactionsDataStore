using System;
using System.Collections.Generic;
using CommonData;
using CommonData.Metadata;

namespace DataService
{
    public static class TransactionDataFactory
    {
        public static List<AppTransaction> AddTransactionData(List<Encounter> encounters, int maxTransactionsPerEncounter, DateTime startDate, DateTime endDate)
        {
            var data = new List<AppTransaction>();
            
            var random = new Random(Guid.NewGuid().GetHashCode());

            var personData = PartyDataFactory.CreatePersonData(100);
            var medicationData = MedDataFactory.CreateMedicationData();

            for (var i = 0; i < encounters.Count; i++)
            {
                var dateString = DataUtility.FormatCurrentDateTime();
                var transactionsPerEncounter = random.Next(1, maxTransactionsPerEncounter);

                for (var j = 0; j < transactionsPerEncounter; j++)
                {
                    var transaction = new AppTransaction
                    {
                        Id = Guid.NewGuid(),
                        SourceType = ((SourceTypeEnum)random.Next(1, 4)).ToString(),
                        SourceId = random.Next(1, 40).ToString(),
                        EncounterId = encounters[i].EncounterId,
                        PartyId = random.Next(1, 99).ToString(),
                        MedId = random.Next(1, 8).ToString(),
                        TransactionType = ((TransactionTypeEnum)random.Next(1, 5)).ToString(),
                        TransactionAmount = random.Next(1, 10000)
                    };

                    var encounterStartDate = DataUtility.GetRandomDateTime(random, startDate, endDate);
                    transaction.Timestamp = encounterStartDate;

                    Console.WriteLine($"Id: {transaction.Id}, timestamp: {transaction.Timestamp}");

                    transaction.EncounterStartDate = encounterStartDate;
                    var encounterEndDate = DataUtility.GetRandomDateTime(random, encounterStartDate, endDate);
                    transaction.EncounterEndDate = encounterEndDate;
                    transaction.TransactionDateTime = DataUtility.GetRandomDateTime(random, encounterStartDate, encounterEndDate);
                    transaction.PartyMaskedName = personData[int.Parse(transaction.PartyId)].MaskedName;
                    transaction.PartyName = personData[int.Parse(transaction.PartyId)].Name;
                    transaction.DispensedMedication = medicationData[int.Parse(transaction.MedId)].DispensedMedication;
                    transaction.FormularyDrug = medicationData[int.Parse(transaction.MedId)].FormularyDrug;
                    transaction.FormularyForm = medicationData[int.Parse(transaction.MedId)].FormularyFormFactor;
                    transaction.FormularyDose = medicationData[int.Parse(transaction.MedId)].FormularyDose;
                    var dose = transaction.FormularyDose.Split(new char[] { ' ' });
                    transaction.FormularyDoseAmount = decimal.Parse(dose[0]);
                    transaction.FormularyDoseUnits = dose[1];
                    transaction.TransactionUnits = transaction.FormularyDoseUnits;

                    data.Add(transaction);
                }
            }

            return data;
        }
    }
}
