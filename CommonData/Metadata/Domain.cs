using System;
using System.Collections.Generic;

namespace CommonData.Metadata
{
    public enum TransactionTypeEnum
    {
        Unknown = 0,
        Dispense = 1,
        Waste = 2,
        Return = 3,
        DispenseOverride = 4,
        DispenseCancel = 5
    }

    public class AppTile
    {
        public AppTile()
        {
            AppTransactions = new List<AppTileTransaction>();
        }

        public string Id { get; set; }
        public string BatchId { get; set; }
        public string RunId { get; set; }
        public DateTime TimestampLocal { get; set; }
        public DateTime TimestampUtc { get; set; }
        public int ClientKey { get; set; }
        public string SourceId { get; set; }
        public long DispenseTransactionKey { get; set; }
        public string EncounterId { get; set; }
        public string MedId { get; set; }
        public string StationName { get; set; }
        public decimal? OrderAmount { get; set; }
        public string OrderUnits { get; set; }
        public List<AppTileTransaction> AppTransactions { get; set; }
    }

    public class AppTileTransaction
    {
        public long? RelatedTransactionKey { get; set; }
        public string TransactionType { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public decimal TransactionAmount { get; set; }
        public string TransactionUnits { get; set; }
        public string PartyId { get; set; }
    }

    public class Source
    {
        public Guid Id { get; set; }
        public string SourceId { get; set; }
        public string SourceType { get; set; }

    }

    public class Encounter
    {
        public Guid Id { get; set; }
        public string EncounterId { get; set; }
        public string EncounterStartDate { get; set; }
        public string EncounterEndDate { get; set; }
    }

    public class Party
    {
        public Guid Id { get; set; }
        public string PartyId { get; set; }
        public string PartySourceId { get; set; }
        public string PartyMaskedName { get; set; }
        public string PartyName { get; set; }
    }

    public class Medication
    {
        public Guid Id { get; set; }
        public string MedId { get; set; }
        public string DispensedMedication { get; set; }
        public string FormularyDrug { get; set; }
        public string FormularyFormFactor { get; set; }
        public string FormularyDose { get; set; }
        public string FormularyUnits { get; set; }
    }
}
