using System.Collections.Generic;
using CommonData;
using CommonData.Metadata;

namespace DataService
{
    public static class PartyDataFactory
    {
        public static List<Person> CreatePersonData(int personCount)
        {
            var data = new List<Person>();

            for (var i = 0; i < personCount; i++)
            {
                var dateString = DataUtility.FormatCurrentDateTime();
                var person = new Person
                {
                    Id = i.ToString(),
                    Name = "Person_" + i.ToString(),
                    Quantity = i,
                    Timestamp = dateString
                };
                data.Add(person);
            }

            return data;
        }
    }
}
