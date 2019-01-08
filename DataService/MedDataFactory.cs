using System;
using System.Collections.Generic;
using CommonData.Metadata;

namespace DataService
{
    public static class MedDataFactory
    {
        private static List<string> Name = new List<string>() {"Ann", "Iona", "Murphy", "Xandra", "Eugenia", "Molly", "Patience", "Nyssa", "Cheryl", "Maile" };
        private static List<string> Encounter = new List<string>() { "SXO30KSE9XR", "KNL05RDS3TN", "WNJ91YFW9IU", "LUT16GUH3ZU", "PGB16OBF0QN", "QVU12GWN5SG", "AFK30WNO7IO", "IVB40UCO9SJ", "KAA59RXS0VW", "HPJ70FNM7IC" };

        public static List<Medication> CreateMedicationData()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());

            var med1 = new Medication
            {
                MedId = random.Next(0, 9999).ToString(),
                DispensedMedication = "Fentanyl tablet 5 mg",
                FormularyDrug = "Fentanyl",
                FormularyFormFactor = "tablet",
                FormularyDose = "5 mg",
                FormularyUnits = "mg",
            };

            var med2 = new Medication
            {
                MedId = random.Next(0, 9999).ToString(),
                DispensedMedication = "Fentanyl tablet 10 mg",
                FormularyDrug = "Fentanyl",
                FormularyFormFactor = "tablet",
                FormularyDose = "10 mg",
                FormularyUnits = "mg",
            };

            var med3 = new Medication
            {
                MedId = random.Next(0, 9999).ToString(),
                DispensedMedication = "Fentanyl tablet 20 mg",
                FormularyDrug = "Fentanyl",
                FormularyFormFactor = "tablet",
                FormularyDose = "20 mg",
                FormularyUnits = "mg",
            };

            var med4 = new Medication
            {
                MedId = random.Next(0, 9999).ToString(),
                DispensedMedication = "Oxycodone injectable 20 ml",
                FormularyDrug = "Oxycodone",
                FormularyFormFactor = "injectable",
                FormularyDose = "20 ml",
                FormularyUnits = "ml",
            };

            var med5 = new Medication
            {
                MedId = random.Next(0, 9999).ToString(),
                DispensedMedication = "Oxycodone injectable 40 ml",
                FormularyDrug = "Oxycodone",
                FormularyFormFactor = "injectable",
                FormularyDose = "40 ml",
                FormularyUnits = "ml",
            };

            var med6 = new Medication
            {
                MedId = random.Next(0, 9999).ToString(),
                DispensedMedication = "Morphine injectable 5 ml",
                FormularyDrug = "Morphine",
                FormularyFormFactor = "injectable",
                FormularyDose = "5 ml",
                FormularyUnits = "ml",
            };

            var med7 = new Medication
            {
                MedId = random.Next(0, 9999).ToString(),
                DispensedMedication = "Morphine injectable 10 ml",
                FormularyDrug = "Morphine",
                FormularyFormFactor = "injectable",
                FormularyDose = "10 ml",
                FormularyUnits = "ml",
            };

            var med8 = new Medication
            {
                MedId = random.Next(0, 9999).ToString(),
                DispensedMedication = "Morphine injectable 15 ml",
                FormularyDrug = "Morphine",
                FormularyFormFactor = "injectable",
                FormularyDose = "15 ml",
                FormularyUnits = "ml",
            };

            var med9 = new Medication
            {
                MedId = random.Next(0, 9999).ToString(),
                DispensedMedication = "Hydromorphone Hydrochloride tablet 400 mg",
                FormularyDrug = "Hydromorphone Hydrochloride",
                FormularyFormFactor = "tablet",
                FormularyDose = "400 mg",
                FormularyUnits = "mg",
            };

            var meds = new List<Medication>() { med1, med2, med3, med4, med5, med6, med7, med8, med9 };
            return meds;
        }
    }
}
