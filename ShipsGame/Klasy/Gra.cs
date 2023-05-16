using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipsGame.Klasy
{
    public static class Gra
    {
        /*public static bool CzyMoznaPostawicStatek(int indexAktualnegoStatku, int komorkaX, int komorkaY, bool jestHoryzontalnie, int[,] komorki)
        {
            if (jestHoryzontalnie)
            {
                if (komorkaX + RozmiaryStatkow[indexAktualnegoStatku] - 1 <= Gracz.OSTATNI_INDEX_PLANSZY)
                {
                    for (int i = Math.Max(0, komorkaX - 1); i <= Math.Min(Gracz.OSTATNI_INDEX_PLANSZY, komorkaX + RozmiaryStatkow[indexAktualnegoStatku]); i++)
                    {
                        for (int j = Math.Max(0, komorkaY - 1); j <= Math.Min(Gracz.OSTATNI_INDEX_PLANSZY, komorkaY + 1); j++)
                        {
                            if (komorki[i, j] != -1)
                            {
                                return false;
                            }
                        }
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (komorkaY + RozmiaryStatkow[indexAktualnegoStatku] - 1 <= Gracz.OSTATNI_INDEX_PLANSZY)
                {
                    for (int i = Math.Max(0, komorkaX - 1); i <= Math.Min(Gracz.OSTATNI_INDEX_PLANSZY, komorkaX + 1); i++)
                    {
                        for (int j = Math.Max(0, komorkaY - 1); j <= Math.Min(Gracz.OSTATNI_INDEX_PLANSZY, komorkaY + RozmiaryStatkow[indexAktualnegoStatku]); j++)
                        {
                            if (komorki[i, j] != -1)
                            {
                                return false;
                            }
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }*/

        public static void RozmiescStatek(int indexAktualnegoStatku, int komorkaX, int komorkaY, bool jestHoryzontalnie, int[,] komorki)
        {
            
        }

        /*public static void RozmieszczenieStatkowKomputera()
        {
            Random random = new Random();
            int indexAktualnegoStatku = 0;

            while (indexAktualnegoStatku < RozmiaryStatkow.Length)
            {
                int x = random.Next(Gracz.ROZMIAR_PLANSZY);
                int y = random.Next(Gracz.ROZMIAR_PLANSZY);

                if (CzyMoznaPostawicStatek(indexAktualnegoStatku, x, y, true, Komputer.Plansza))
                {
                    RozmiescStatek(indexAktualnegoStatku, x, y, true, Gra.Komputer.Plansza);
                    indexAktualnegoStatku++;
                }
            }
        }*/

        /*public static bool WykonajAtak(int komorkaX, int komorkaY, Gracz atakujacy, Gracz atakowany)
        {
            atakowany.OdkrytePola[komorkaX, komorkaY] = true;

            if (atakowany.Plansza[komorkaX, komorkaY] != -1)
            {
                atakowany.Flota[atakowany.Plansza[komorkaX, komorkaY]]--;

                if (atakowany.Flota[atakowany.Plansza[komorkaX, komorkaY]] == 0)
                {
                    atakujacy.LiczbaStatkowDoZatopienia--;
                }

                return true;
            }
            else
            {
                return false;
            }
        }*/

        /*public static int[] StrzalKomputera(Gracz gracz)
        {

            Random random = new Random();

            int x = random.Next(Gracz.ROZMIAR_PLANSZY);
            int y = random.Next(Gracz.ROZMIAR_PLANSZY);

            while (gracz.OdkrytePola[x, y] == true)
            {
                x = random.Next(Gracz.ROZMIAR_PLANSZY);
                y = random.Next(Gracz.ROZMIAR_PLANSZY);
            }

            int[] strzal = { x, y };
            return strzal;
        }*/

    }
}
