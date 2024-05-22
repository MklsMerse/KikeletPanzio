using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KikeletPanzio
{
    internal class UgyfelAdatok
    {
        int azonosito;
        string nev;
        string szuletesidatum;
        string email;
        bool vip;

        public UgyfelAdatok(int azonosito, string nev, string szuletesidatum, string email, bool vip)
        {
            Azonosito = azonosito;
            Nev = nev;
            Szuletesidatum = szuletesidatum;
            Email = email;
            Vip = vip;
        }

        public int Azonosito { get => azonosito; set => azonosito = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Szuletesidatum { get => szuletesidatum; set => szuletesidatum = value; }
        public string Email { get => email; set => email = value; }
        public bool Vip { get => vip; set => vip = value; }
        public UgyfelAdatok(string sor)
        {
            string[] adatok = sor.Split(";");
            Azonosito = int.Parse(adatok[0]);
            Nev = (adatok[1]);
            Szuletesidatum = (adatok[2]);
            Email = adatok[3];
            Vip = bool.Parse(adatok[4]);
        }
    }
}
