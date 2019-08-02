using System;
using System.Collections.Generic;
using System.Text;

namespace FrequencyManager
{
    public class Frequency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double RxFreq { get; set; }
        public double TxFreq { get; set; }
        public string Location { get; set; }
        public int SigStr { get; set; }
        //-----Digital Modes-----//
        public bool IsDigi { get; set; }
        public string DigiMode { get; set; }
        //-----DMR Mototrbo-----//
        public int DigiDmrCc { get; set; }
        public int DigiDmrTs { get; set; }
        public int DigiDmrTgId { get; set; }
        public string DigiDmrTgName { get; set; }
        public string DigiDmrEncType { get; set; }
        //-----Tetra-----//
        public double DigiTetraMcch { get; set; }
        public int DigiTetraTgID { get; set; }
        public string DigiTetraTgName { get; set; }
        //-----Analog-----//
        public string AnaMode { get; set; }
        public string AnaSqType { get; set; }
        public double AnaCtcssCode { get; set; }
        public int AnaDcsCode { get; set; }
        public double Bandwidth { get; set; }
        public bool AnaEnc { get; set; }

        public static Frequency CreateFrequency(int id, string name)
        {
            var frequency = new Frequency();

            //frequency.Id = id;
            //frequency.Name = name;
            //frequency.Category = "Unallocated";
            //frequency.RxFreq = 145.000000;
            //frequency.TxFreq = 145.000000;
            //frequency.Bandwidth = 12.5;
            //frequency.Location = "Not Set";
            //frequency.AnaMode = "Not Set";
            //frequency.AnaSqCode = 67.0;
            //frequency.AnaEnc = false;
            //frequency.DigiMode = "Not Set";
            //frequency.DigiCC = 0;
            //frequency.DigiTS = 1;
            //frequency.DigiTG = 1;
            //frequency.DigiEncEP = false;
            //frequency.DigiEncBP = false;

            return frequency;
        }

        public Frequency SetName(string name)
        {
            Name = name;

            return this;
        }
        public Frequency SetCategory(string category)
        {
            Category = category;

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
        
        public Frequency SetLocation(string location)
        {
            Location = location;

            return this;
        }

        public Frequency SetSignalStrength(int sigstrength)
        {
            SigStr = sigstrength;

            return this;
        }

        public Frequency SetIsDigi(bool isdigi)
        {
            IsDigi = isdigi;

            return this;
        }

        public Frequency SetDigiMode(string digimode)
        {
            DigiMode = digimode;

            return this;
        }

        public Frequency SetDigiDmrCc(int digidmrcc)
        {
            DigiDmrCc = digidmrcc;

            return this;
        }

        public Frequency SetDigiDmrTs(int digidmrts)
        {
            DigiDmrTs = digidmrts;

            return this;
        }

        public Frequency SetDigiDmrTgId(int digidmrtgid)
        {
            DigiDmrTgId = digidmrtgid;

            return this;
        }

        public Frequency SetDigiDmrTgName(string digidmrtgname)
        {
            DigiDmrTgName = digidmrtgname;

            return this;
        }

        public Frequency SetDigiDmrEncType(string digidmrenctype)
        {
           DigiDmrEncType = digidmrenctype;

           return this;
        }

        public Frequency SetDigiTetraMcch(double digitetramcch)
        {
            DigiTetraMcch = digitetramcch;

            return this;
        }

        public Frequency SetDigiTetraTgId(int digitetratgid)
        {
            DigiTetraTgID = digitetratgid;

            return this;
        }

        public Frequency SetDigiTetraTgName(string digitetratgname)
        {
            DigiTetraTgName = digitetratgname;

            return this;
        }

        public Frequency SetAnaMode(string anamode)
        {
            AnaMode = anamode;

            return this;
        }

        public Frequency SetAnaSqType(string anasqtype)
        {
            AnaSqType = anasqtype;

            return this;
        }

        public Frequency SetAnaCtcssCode(double anactcsscode)
        {
            AnaCtcssCode = anactcsscode;

            return this;
        }

        public Frequency SetAnaDcsCode(int anadcscode)
        {
            AnaDcsCode = anadcscode;

            return this;
        }

        public Frequency SetBandwidth(int bandwidth)
        {
            Bandwidth = bandwidth;

            return this;
        }

        public Frequency SetAnaEnc(bool anaenc)
        {
            AnaEnc = anaenc;

            return this;
        }
    }
}
