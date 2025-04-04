using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIZSGA_KOROM_KONZOL
{
    class Auto
    {
        int sorszam;
        string marka, modell;
        int gyartasiEv;
        string szin;
        int eladottDb;
        int atlagAr;

        public Auto(string sor)
        {
            string[] adatok = sor.Split(';');

            this.Sorszam = int.Parse(adatok[0]);
            this.Marka = adatok[1];
            this.Modell = adatok[2];
            this.GyartasiEv = int.Parse(adatok[3]);
            this.Szin = adatok[4];
            this.EladottDb = int.Parse(adatok[5]);
            this.AtlagAr = int.Parse(adatok[6]);
        }

        public int Sorszam { get => sorszam; set => sorszam = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Modell { get => modell; set => modell = value; }
        public int GyartasiEv { get => gyartasiEv; set => gyartasiEv = value; }
        public string Szin { get => szin; set => szin = value; }
        public int EladottDb { get => eladottDb; set => eladottDb = value; }
        public int AtlagAr { get => atlagAr; set => atlagAr = value; }
        public static List<Auto> Beolvas(string fajl)
        {
            return File.ReadAllLines(fajl).Skip(1).Select(x => new Auto(x)).ToList();
        }
    }
}
