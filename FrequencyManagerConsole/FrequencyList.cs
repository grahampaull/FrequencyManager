using System;
using System.Collections.Generic;
using System.Text;
using static System.IO.File;
using Newtonsoft.Json;

namespace FrequencyManager
{
    public class FrequencyList
    {
        private string fileName = "Frequencies.json";

        private static List<Frequency> SeedInitialFrequencies()
        {
            var defaultFreq = Frequency.CreateFrequency(1, "HMCG 0")
                    .SetRX(156.000000)
                    .SetTX(155.000000)
                    .SetCategory("Unallocated")
                    .SetLocation("Not Set")
                    .SetAnaMode("Not Set")
                    .SetAnaSqCode("Not Set")
                    .SetDigiMode("Not Set")
                    .SetDigiCC("Not Set")
                    .SetDigiTS("Not Set")
                    .SetDigiTG("Not Set");

            var listOfFrequencies = new List<Frequency>();

            listOfFrequencies.Add(defaultFreq);

            return listOfFrequencies;
        }

        public void SaveFrequencies(List<Frequency> freqs)
        {
            var dataAsString = JsonConvert.SerializeObject(freqs);

            WriteAllText(fileName, dataAsString);
        }

        public List<Frequency> LoadFrequencies()
        {
            if (Exists(fileName))
            {
                var dataAsString = ReadAllText(fileName);

                var dataAsObject = JsonConvert.DeserializeObject<List<Frequency>>(dataAsString);

                return dataAsObject;
            }
            else
            {
                var defaultGames = SeedInitialFrequencies();

                return defaultGames;
            }

        }
    }
}
