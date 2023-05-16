using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipsGame.Klasy
{
    public class Gracz
    {
        //nazwa gracza (nick)
        public string Nazwa;


        //plansza gracza
        // -1 - pole puste
        // 0-3 - pole zawiera statek o długości +1    0  -> statek 1masztowy    1  -> statek 2masztowy
        public int[,] Plansza;

        //plansza do przechowywania info czy pole było odkryte
        // true -> trafiony     false -> nie trafiony
        public bool[,] OdkrytePola;

        //ile pól statków jest do zatopienia    [1,2,3,4]
        public int[] Flota;

        // ile zostało nam niezatopionych statków
        public int LiczbaStatkówDoZatopienia;  // 4 na początku

        public static int ROZMIAR_PLANSZY = 10;
        public static int OSTATNI_INDEX_PLANSZY = ROZMIAR_PLANSZY - 1;

        public Gracz()
        {
            Flota = new int[] {1,2,3,4};

            Plansza = new int[ROZMIAR_PLANSZY, ROZMIAR_PLANSZY];
            OdkrytePola = new bool[ROZMIAR_PLANSZY, ROZMIAR_PLANSZY];

            LiczbaStatkówDoZatopienia = Flota.Length;
        }
    }
}
