using System.Collections.Generic;
using System.IO;
using CommonData.Metadata;
using Newtonsoft.Json;

namespace DataWriterService
{
    public static class FileWriter
    {
        public static void SaveDataToJsonFile<T>(List<T> data, string fileNameWithPath)
        {
            using (var writetext = new StreamWriter(fileNameWithPath))
            {
                string medJson = JsonConvert.SerializeObject(data.ToArray());
                writetext.WriteLine(medJson);
            }
        }

        public static void SaveEncounterDataToTextFile(List<Encounter> data, string fileNameWithPath)
        {
            using (var writetext = new StreamWriter(fileNameWithPath))
            {
                var header = "Encounter Id|Start Date|End Date";
                writetext.WriteLine(header);

                foreach (var encounter in data)
                {
                    var item = $"{encounter.EncounterId}|{encounter.EncounterStartDate}|{encounter.EncounterEndDate}";
                    writetext.WriteLine(item);
                }
            }
        }
    }
}
