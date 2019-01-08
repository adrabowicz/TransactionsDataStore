using System;

namespace CommonData.Metadata
{
    public enum SourceTypeEnum
    {
        Unknown = 0,
        SourceType1 = 1,
        SourceType2 = 2,
        SourceType3 = 3,
        SourceType4 = 4
    }

    public enum TransactionTypeEnum
    {
        Unknown = 0,
        Dispense = 1,
        Waste = 2,
        Return = 3,
        DispenseOverride = 4,
        DispenseCancel = 5
    }

    public class SourceTransaction
    {
        public Guid Id { get; set; }
        public string SourceId { get; set; }
        public string EncounterId { get; set; }
        public string PartyId { get; set; }
        public string MedId { get; set; }
        public string TransactionType { get; set; }
        public string TransactionDateTime { get; set; }
        public decimal TransactionAmount { get; set; }
        public string TransactionUnits { get; set; }
    }

    public class AppTransaction
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string SourceId { get; set; }
        public string EncounterId { get; set; }
        public string PartyId { get; set; }
        public string MedId { get; set; }
        public string SourceType { get; set; }
        public DateTime EncounterStartDate { get; set; }
        public DateTime EncounterEndDate { get; set; }
        public string TransactionType { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public decimal TransactionAmount { get; set; }
        public string TransactionUnits { get; set; }
        public string PartyMaskedName { get; set; }
        public string PartyName { get; set; }
        public string DispensedMedication { get; set; }
        public string FormularyDrug { get; set; }
        public string FormularyForm { get; set; }
        public string FormularyDose { get; set; }
        public decimal FormularyDoseAmount { get; set; }
        public string FormularyDoseUnits { get; set; }
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
