namespace FrequencyManager
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using static System.IO.File;

    public class FrequencyService
    {
        private string fileName = "Frequencies.json";

        private static List<Frequency> SeedInitialFrequencies()
        {
            var defaultFreq = Frequency.CreateFrequency(1)
                            .SetName("HMCG 0")
                            .SetCategory("Marine")
                            .SetRX(156.000000)
                            .SetTX(156.000000)
                            .SetLocation("United Kingdom")
                            .SetSignalStrength(5)
                            .SetIsDigi(false)
                            .SetDigiMode("N/A")
                            .SetDigiDmrCc(0)
                            .SetDigiDmrTs(0)
                            .SetDigiDmrTgId(0)
                            .SetDigiDmrTgName("N/A")
                            .SetDigiDmrEncType("N/A")
                            .SetDigiDmrTgId(0)
                            .SetDigiTetraTgName("N/A")
                            .SetAnaMode("NFM")
                            .SetAnaSqType("None")
                            .SetAnaCtcssCode(0)
                            .SetAnaDcsCode(0)
                            .SetAnaDcsCode(0)
                            .SetAnaEnc(false)
                            .SetBandwidth(12.5)
                            .SetComment("HM Coastguard");


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
                var defaultFrequencies = SeedInitialFrequencies();

                return defaultFrequencies;
            }
        }
    }
}
