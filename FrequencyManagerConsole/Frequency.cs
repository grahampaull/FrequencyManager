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
        public int DigiTetraTgId { get; set; }
        public string DigiTetraTgName { get; set; }
        //-----Analog-----//
        public string AnaMode { get; set; }
        public string AnaSqType { get; set; }
        public double AnaCtcssCode { get; set; }
        public int AnaDcsCode { get; set; }
        public bool AnaEnc { get; set; }
        public double Bandwidth { get; set; }
        public string Comments { get; set; }
        

        public static Frequency CreateFrequency(int id)
        {
            var frequency = new Frequency();

            frequency.Id = id;
            frequency.Name = "HMCG 0";
            frequency.Category = "Marine";
            frequency.RxFreq = 156.000000;
            frequency.TxFreq = 156.000000;
            frequency.Location = "United Kingdom";
            frequency.SigStr = 0;
            frequency.IsDigi = false;
            frequency.DigiMode = "N/A";
            frequency.DigiDmrCc = 0;
            frequency.DigiDmrTs = 0;
            frequency.DigiDmrTgId = 0;
            frequency.DigiDmrTgName = "N/A";
            frequency.DigiDmrEncType = "N/A";
            frequency.DigiTetraTgId = 0;
            frequency.DigiTetraTgName = "N/A";
            frequency.AnaMode = "NFM";
            frequency.AnaSqType = "None";
            frequency.AnaCtcssCode = 0;
            frequency.AnaDcsCode = 0;
            frequency.AnaEnc = false;
            frequency.Bandwidth = 12.5;
            frequency.Comments = "HM Coastguard Channel 0";

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
                
        public Frequency SetDigiTetraTgId(int digitetratgid)
        {
            DigiTetraTgId = digitetratgid;

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

       

        public Frequency SetAnaEnc(bool anaenc)
        {
            AnaEnc = anaenc;

            return this;
        }

        public Frequency SetBandwidth(double bandwidth)
        {
            Bandwidth = bandwidth;

            return this;
        }

        public Frequency SetComment(string comments)
        {
            Comments = comments;

            return this;
        }
    }
}
