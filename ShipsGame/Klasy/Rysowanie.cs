using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipsGame.Klasy
{
    public static class Rysowanie
    {
        private const int PRZEZROCZYSTOSC = 255;

        private const int SZEROKOSC_RAMKI = 35;
        private const int WYSOKOSC_RAMKI = 35;

        private const int SZEROKOSC_KOMORKI = 40;
        private const int WYSOKOSC_KOMORKI = 40;

        public static readonly Brush[] kolory = new SolidBrush[5]
        {
            new SolidBrush(Color.FromArgb(PRZEZROCZYSTOSC, Color.Yellow)),
            new SolidBrush(Color.FromArgb(PRZEZROCZYSTOSC, Color.Red)),
            new SolidBrush(Color.FromArgb(PRZEZROCZYSTOSC, Color.Green)),
            new SolidBrush(Color.FromArgb(PRZEZROCZYSTOSC, Color.Blue)),
            new SolidBrush(Color.FromArgb(PRZEZROCZYSTOSC, Color.Violet))
        };

        /*public static void RysujObramowanie(int komorkaX, int komorkaY, int kolor, PictureBox plansza)
        {
            Graphics graphics = plansza.CreateGraphics();
            graphics.DrawRectangle(new Pen(kolory[kolor], 3), komorkaX * SZEROKOSC_KOMORKI, komorkaY * SZEROKOSC_KOMORKI, SZEROKOSC_RAMKI, WYSOKOSC_RAMKI);
        }*/
        
        /*public static void RysujKomorke(int komorkaX, int komorkaY, int kolor, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(kolory[kolor], komorkaX * SZEROKOSC_KOMORKI, komorkaY * SZEROKOSC_KOMORKI, SZEROKOSC_KOMORKI, WYSOKOSC_KOMORKI);
        }*/

        /*public static void RysujUstawioneKomorki(int[,] komorki, PaintEventArgs e)
        {
            for (int x = 0; x < Gracz.ROZMIAR_PLANSZY; x++)
            {
                for (int y = 0; y < Gracz.ROZMIAR_PLANSZY; y++)
                {
                    if (komorki[x, y] != -1)
                    {
                        RysujKomorke(x, y, komorki[x, y], e);
                    }
                }
            }
        }*/

        /*public static void RysujKomorki(bool[,] odkryteKomorki, int[,] komorki, PaintEventArgs e)
        {
            for (int x = 0; x < Gracz.ROZMIAR_PLANSZY; x++)
            {
                for (int y = 0; y < Gracz.ROZMIAR_PLANSZY; y++)
                {
                    if (odkryteKomorki[x, y])
                    {
                        if (komorki[x, y] != -1)
                        {
                            RysujTrafionaKomorke(x, y, e);
                        }
                        else
                        {
                            RysujNietrafionaKomorke(x, y, e);
                        }
                    }
                }
            }
        }*/

        private static void RysujTrafionaKomorke(int komorkaX, int komorkaY, PaintEventArgs e)
        {

        }

        private static void RysujNietrafionaKomorke(int komorkaX, int komorkaY, PaintEventArgs e)
        {

        }

        /*public static void RysujZatopioneStatki(int[,] komorki, int[] trafieniaStatku, PaintEventArgs e)
        {
            for (int aktualnyStatek = 0; aktualnyStatek < Gra.RozmiaryStatkow.Length; aktualnyStatek++)
            {
                if (trafieniaStatku[aktualnyStatek] == 0)
                {
                    for (int x = 0; x < Gracz.ROZMIAR_PLANSZY; x++)
                    {
                        for (int y = 0; y < Gracz.ROZMIAR_PLANSZY; y++)
                        {
                            if (komorki[x, y] == aktualnyStatek)
                            {
                                RysujKomorke(x, y, aktualnyStatek, e);
                            }
                        }
                    }
                }
            }
        }*/
    }
}
