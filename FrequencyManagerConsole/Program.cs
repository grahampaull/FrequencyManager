namespace FrequencyManager
{
    using System;
    using static System.Console;

    internal class Program
    {
        internal static void Main(string[] args)
        {

            //  bool isdigi1 = GetBooleanFromString(Console.ReadLine().ToLower());
            //  bool isdigi2 = GetBooleanFromStringUsingIfStatements(Console.ReadLine().ToLower());
            //  bool isdigi3 = GetBooleanFromStringUsingSwitch(Console.ReadLine().ToLower());

            var frequencyService = new FrequencyService();

            var frequency = frequencyService.LoadFrequencies();

            WriteLine("Would you like to add a new frequency?");

            if (ReadLine() == "y")
            {
                WriteLine("Ok, Fill in the details then press enter after each");

                WriteLine("STRING - Name");
                string name = ReadLine();

                WriteLine("STRING - What Category?");
                string category = ReadLine();

                WriteLine("DOUBLE - RX Freq eg: 156.000000");
                double rxFreq = Convert.ToDouble(ReadLine());

                WriteLine("DOUBLE - TX Freq eg: 156.000000");
                double txFreq = Convert.ToDouble(ReadLine());

                WriteLine("STRING - Location");
                string location = ReadLine();

                WriteLine("INT - Signal Strength (0-5)");
                int sigStrength = Convert.ToInt32(ReadLine());

                //AT THIS POINT I NEED TO SEE IF THE USER WANTS ANALOG OR DIGITAL, i AM SKIPPING THIS FOR NOW AS i AM NOT SURE HOW TO DO THIS
                WriteLine("AT THIS POINT I NEED TO SEE IF THE USER WANTS ANALOG OR DIGITAL, i AM SKIPPING THIS FOR NOW AS i AM NOT SURE HOW TO DO THIS");

                bool isdigi = GetBooleanFromString(Console.ReadLine().ToLower());


                WriteLine("Analog Mode: WFM, NFM, AM, SSB");
                string anaMode = ReadLine();

                WriteLine("What Squelch Type? - CTCSS or DCS");
                string anaSqType = ReadLine();

                WriteLine("CTCSS Tone Code");
                double anaCtcssCode = Convert.ToInt32(ReadLine());

                WriteLine("DCS Tone Code");
                int anaDcsCode = Convert.ToInt32(ReadLine());

                WriteLine("Bandwidth - 12.5");
                double bandwidth = Convert.ToInt32(ReadLine());

                var newFrequency = Frequency.CreateFrequency(frequency.Count + 1);

                frequency.Add(newFrequency);

            }

            foreach (var singleFreq in frequency)
            {
                WriteLine($"{singleFreq.Name} can be found on {singleFreq.RxFreq:N6}");
            }
        }

        private static bool GetBooleanFromString(string isDigiString)
        {
            return isDigiString == "yes" || isDigiString == "y" || isDigiString == "yip";
        }

        private static bool GetBooleanFromStringUsingIfStatements(string isDigiString)
        {
            if (isDigiString == "yes" || isDigiString == "y" || isDigiString == "yip")
            {
                return true;
            }
            else if (isDigiString == "no" || isDigiString == "n" || isDigiString == "nope")
            {
                return false;
            }
            else
            {
                Console.WriteLine("INVALID INPUT PROVIDED!");
                return false;
            }
        }

        private static bool GetBooleanFromStringUsingSwitch(string isDigiString)
        {
            switch (isDigiString)
            {
                case "yes": return true;
                case "yip": return true;
                case "y": return true;
                case "yadda": return true;
                case "no": return false;
                case "nope": return false;
                case "fuck off": return false;
                default: return false;
            }
        }
    }
}
