using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024.jan._22_Autok
{
    internal class Autok
    {
        string rendszam;
        string marka;
        string modell;
        int gyartasiev;
        DateTime forgalmiErvenyesseg;
        int vetelar;
        int kmallas;
        int hengerűrtartalom;
        int tomeg;
        int teljesitmeny;

        public string Rendszam { get => rendszam; set => rendszam = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Modell { get => modell; set => modell = value; }
        public int Gyartasiev { get => gyartasiev; set => gyartasiev = value; }
        public DateTime ForgalmiErvenyesseg { get => forgalmiErvenyesseg; set => forgalmiErvenyesseg = value; }
        public int Vetelar { get => vetelar; set => vetelar = value; }
        public int Kmallas { get => kmallas; set => kmallas = value; }
        public int Hengerűrtartalom { get => hengerűrtartalom; set => hengerűrtartalom = value; }
        public int Tomeg { get => tomeg; set => tomeg = value; }
        public int Teljesitmeny { get => teljesitmeny; set => teljesitmeny = value; }

        public Autok(string rendszam, string marka, string modell,int gyartasiev, DateTime forgalmiErvenyesseg, int vetelar, int kmallas, int hengerűrtartalom, int tomeg, int teljesitmeny)
        {
            Rendszam = rendszam;
            Marka = marka;
            Modell = modell;
            Gyartasiev = gyartasiev;
            ForgalmiErvenyesseg = forgalmiErvenyesseg;
            Vetelar = vetelar;
            Kmallas = kmallas;
            Hengerűrtartalom = hengerűrtartalom;
            Tomeg = tomeg;
            Teljesitmeny = teljesitmeny;
        }
        public override string ToString()
        {
            return $"{this.marka} {this.modell} ({this.vetelar})";
        }
    }

}
