using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KikeletPanzio
{
    internal class Szoba
    {
        int ar;
        int szobasz;
        int ferohely;

        public Szoba(int ar, int szobasz, int ferohely)
        {
            Ar = ar;
            Szobasz = szobasz;
            Ferohely = ferohely;
        }

        public int Ar { get => ar; set => ar = value; }
        public int Szobasz { get => szobasz; set => szobasz = value; }
        public int Ferohely { get => ferohely; set => ferohely = value; }
    }
}
