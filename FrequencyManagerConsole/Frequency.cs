using System;
using System.Collections.Generic;
using System.Text;

namespace FrequencyManager
{
    public class Frequency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double RxFreq { get; set; }
        public double TxFreq { get; set; }
        public double Bandwidth { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public string AnaMode { get; set; }
        public double AnaSqCode { get; set; }
        public bool AnaEnc { get; set; }
        public string DigiMode { get; set; }
        public int DigiCC { get; set; }
        public int DigiTS { get; set; }
        public int DigiTG { get; set; }
        public bool DigiEncEP { get; set; }
        public bool DigiEncBP { get; set; }

        public static Frequency CreateFrequency(int id, string name)
        {
            var frequency = new Frequency();
            frequency.Id = id;
            frequency.Name = name;
            frequency.RxFreq = 145.000000;
            frequency.TxFreq = 145.000000;
            frequency.Bandwidth = 12.5;
            frequency.Category = "Unallocated";
            frequency.Location = "Not Set";
            frequency.AnaMode = "Not Set";
            frequency.AnaSqCode = 67.0;
            frequency.AnaEnc = false;
            frequency.DigiMode = "Not Set";
            frequency.DigiCC = 0;
            frequency.DigiTS = 1;
            frequency.DigiTG = 1;
            frequency.DigiEncEP = false;
            frequency.DigiEncBP = false;

            return frequency;
        }

        public Frequency SetName(string name)
        {
            Name = name;

            return this;
        }

        public Frequency SetRX(double rxfreq)
        {
            RxFreq = rxfreq;

            return this;
        }

        public Frequency SetTX(double txfreq)
        {
            TxFreq = txfreq;

            return this;
        }

        public Frequency SetCategory(string category)
        {
            Category = category;

            return this;
        }

        public Frequency SetLocation(string location)
        {
            Location = location;

            return this;
        }

        public Frequency SetAnaMode(string anamode)
        {
            AnaMode = anamode;

            return this;
        }

        public Frequency SetAnaSqCode(double anasqcode)
        {
            AnaSqCode = anasqcode;

            return this;
        }

        public Frequency SetAnaEnc(bool anaenc)
        {
            AnaEnc = anaenc;

            return this;
        }

        public Frequency SetDigiMode(string digimode)
        {
            DigiMode = digimode;

            return this;
        }

        public Frequency SetDigiCC(int digicc)
        {
            DigiCC = digicc;

            return this;
        }

        public Frequency SetDigiTS(int digits)
        {
            DigiTS = digits;

            return this;
        }

        public Frequency SetDigiTG(int digitg)
        {
            DigiTG = digitg;

            return this;
        }

        public Frequency SetDigiEncEP(bool digiencep)
        {
           DigiEncEP = digiencep;

           return this;
        }

        public Frequency SetDigiEncBP(bool digiencbp)
        {
           DigiEncBP = digiencbp;

           return this;
        }
    }
}
