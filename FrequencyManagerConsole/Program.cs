using System;
using static System.Console;
using static System.ConsoleColor;
using System.Collections.Generic;

namespace FrequencyManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var FrequencyList = new FrequencyList();

            var frequency = FrequencyList.LoadFrequencies();

            WriteLine("Would you like to add a new frequency?");

            if (ReadLine() == "y")
            {
                WriteLine("Ok, Fill in the details then press enter after each");

                WriteLine("STRING - Name");
                string name = ReadLine();

                WriteLine("STRING - What Category?");
                string category = ReadLine();

                WriteLine("DOUBLE - RX Freq eg: 156.000000");
                double rxFreq = Convert.ToInt32(ReadLine());

                WriteLine("DOUBLE - TX Freq eg: 156.000000");
                double txFreq = Convert.ToInt32(ReadLine());

                WriteLine("STRING - Location");
                string location = ReadLine();

                WriteLine("INT - Signal Strength (0-5)");
                int sigStrength = Convert.ToInt32(ReadLine());

                //AT THIS POINT I NEED TO SEE IF THE USER WANTS ANALOG OR DIGITAL, i AM SKIPPING THIS FOR NOW AS i AM NOT SURE HOW TO DO THIS
                WriteLine("AT THIS POINT I NEED TO SEE IF THE USER WANTS ANALOG OR DIGITAL, i AM SKIPPING THIS FOR NOW AS i AM NOT SURE HOW TO DO THIS");

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

                var newFrequency = Frequency.CreateFrequency(frequency.Count() + 1, name, category, rxFreq, txFreq, location, sigStrength, false, "", 0, 0, 0, "", "", 0, "", "NFM", "CTCSS", 67.0, 0, 12.5, false, "This is seeded");

                var FrequencyList.Add(newFrequency);

            }

            var listFrequencies = new FrequencyList();

            var freq = listFrequencies.LoadFrequencies();

            foreach (var singleFreq in freq)
            {
                WriteLine($"{singleFreq.Name} can be found on {singleFreq.RxFreq:N6}");
            }
        }
    }
}
