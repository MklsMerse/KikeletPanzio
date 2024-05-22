using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KikeletPanzio
{
    internal class UgyfelAdatok
    {
        int azonosito;
        string nev;
        DateTime szuletesidatum;
        string email;
        bool vip;

        public UgyfelAdatok(string sor)
        {
            string[] adatok = sor.Split(";");
            Azonosito = int.Parse(adatok[0]);
            Nev = (adatok[1]);
            Szuletesidatum = DateTime.Parse(adatok[2]);
            Email = adatok[3];
            Vip = bool.Parse(adatok[4]);
        }
        public override string ToString()
        {
            return $"{Azonosito};{Nev};{Szuletesidatum};{Email};{Vip}";
        }

        public UgyfelAdatok(int azonosito, string nev, DateTime szuletesidatum, string email, bool vip)
        {
            Azonosito = azonosito;
            Nev = nev;
            Szuletesidatum = szuletesidatum;
            Email = email;
            Vip = vip;
        }

        public int Azonosito { get => azonosito; set => azonosito = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Szuletesidatum { get => szuletesidatum; set => szuletesidatum = value; }
        public string Email { get => email; set => email = value; }
        public bool Vip { get => vip; set => vip = value; }
    }
}
