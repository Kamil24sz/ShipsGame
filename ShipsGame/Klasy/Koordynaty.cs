using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipsGame.Klasy
{
    public static class Koordynaty
    {
        public static int PobierzKomorke(int wspolrzedna)
        {
            int komorka = wspolrzedna / 40;

            if (komorka >= 0 && komorka <= 9)
            {
                return komorka;
            }
            else
            {
                return -1;
            }
        }

    }
}
