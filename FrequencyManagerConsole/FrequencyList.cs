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
            var defaultFreq = Frequency.CreateFrequency(1, "HMCG Channel 0", "Marine", 156.000000, 156.000000, "UK", 5, false, "", 0, 0, 0, "", "", 0, "", "NFM", "", 0, 0, 25, false, "Default Seeded");
                            
                            //.SetName("HMCG Channel 0")
                            //.SetCategory("Marine")
                            //.SetRX(156.000000)
                            //.SetTX(156.000000)  
                            //.SetLocation("United Kingdom")
                            //.SetSignalStrength(5)
                            //.SetIsDigi(false)
                            //.SetDigiMode("Not Digital")
                            //.SetDigiDmrCc(0)
                            //.SetDigiDmrTs(0)
                            //.SetDigiTG("Not Set");

                            //.SetAnaMode("Not Set")
                            //.SetAnaSqCode("Not Set")
                                                        
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
