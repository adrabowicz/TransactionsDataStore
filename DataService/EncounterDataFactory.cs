using System;
using System.Collections.Generic;
using CommonData;
using CommonData.Metadata;

namespace DataService
{
    public static class EncounterDataFactory
    {
        public static List<Encounter> CreateEncounterData(int count, DateTime startDate, DateTime endDate)
        {
            var random = new Random(Guid.NewGuid().GetHashCode());

            var range = (endDate - startDate).Days;

            var encounters = new List<Encounter>();

            for (var i = 0; i < count; i++)
            {
                var startDateOffset = random.Next(range / 2);
                var endDateOffset = random.Next(startDateOffset, range - startDateOffset);
                var encounterStartDateTime = startDate.AddDays(startDateOffset);
                var encounterEndDateTime = startDate.AddDays(endDateOffset);

                var encounter = new Encounter
                {
                    EncounterId = random.Next(0, 9999).ToString(),
                    EncounterStartDate = DataUtility.FormatDateTime(encounterStartDateTime),
                    EncounterEndDate = DataUtility.FormatDateTime(encounterEndDateTime)
                };
                encounters.Add(encounter);
            }

            return encounters;
        }
    }
}
