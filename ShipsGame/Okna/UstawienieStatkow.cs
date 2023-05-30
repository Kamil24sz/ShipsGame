using ShipsGame.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipsGame.Okna
{
    public partial class UstawienieStatkow : Form
    {
        //współrzędne myszy
        int myszX;
        int myszY;

        // indeks do tablicy z długością statków
        int indexAktualnegoStatku;

        // pole pokazujące jak satek jest ustawiany
        // true - poziomo
        // false - pionowo
        bool poziom;

        bool[] rozmieszczoneStatki = new bool[4];

        public UstawienieStatkow()
        {
            InitializeComponent();

            // upewnienie się że skalowanie okna nie wpływa na rozmiar planszy;
            planszaGracza.Width = 400;
            planszaGracza.Height = 400;

            poziom = true;

            Gra.Uzytkownik = new Gracz();
            Gra.Komputer = new Gracz();

            indexAktualnegoStatku = 0;

            btnDalej.Enabled = false;
        }

        private void planszaGracza_MouseMove(object sender, MouseEventArgs e)
        {
            // funkcja będzie wywoływana dopóki wszystkie statki nie będą rozłożone (indeksy od 0 do 3)
            if(indexAktualnegoStatku < 4)
            {
                myszX = Koordynaty.PobierzKomorke(e.Location.X);
                myszY = Koordynaty.PobierzKomorke(e.Location.Y);

                planszaGracza.Refresh();

                // jeśli statek jest ustawiany poziomo
                if(poziom)
                {
                    for(int i = 0; i < Gra.RozmiaryStatkow[indexAktualnegoStatku]; i++)
                    {
                        if(myszX + i <= Gracz.OSTATNI_INDEX_PLANSZY)
                        {
                            Rysowanie.RysujObramowanie(myszX + i, myszY, indexAktualnegoStatku, planszaGracza);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < Gra.RozmiaryStatkow[indexAktualnegoStatku]; i++)
                    {
                        if (myszY + i <= Gracz.OSTATNI_INDEX_PLANSZY)
                        {
                            Rysowanie.RysujObramowanie(myszX, myszY + i, indexAktualnegoStatku, planszaGracza);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            poziom = !poziom;
        }

        private void planszaGracza_Click(object sender, EventArgs e)
        {
            //sprawdzenie czy można postawić statek w danym polu
            if (CzyMoznaPostawicStatek(indexAktualnegoStatku, myszX, myszY, poziom, Gra.Uzytkownik.Plansza))
            {
                // ustalamy wartość true, jeśłi dany statek został rozmieszczony
                rozmieszczoneStatki[indexAktualnegoStatku] = true;

                //jeśli można postawić statek to wywołaj funkcję do rozmieszczania
                Gra.RozmiescStatek(indexAktualnegoStatku, myszX, myszY, poziom, Gra.Uzytkownik.Plansza);

                // odświeżenie planszy gracza
                planszaGracza.Refresh();

                if(indexAktualnegoStatku < Gra.RozmiaryStatkow.Length)
                {
                    indexAktualnegoStatku++;
                }

                //gdy wszystkie statki są rozstawione
                int pos = Array.IndexOf(rozmieszczoneStatki, false); //array.index of gdy nie znajdzie wartości w tabliy
                // zwraca -1 
                if (pos == -1) {
                    btnDalej.Enabled = true;
                    planszaGracza.Enabled = false;
                }
            }

        }

        //funkcja do sprawdzania czy można postawić statek w dnaym miejscu
        public static bool CzyMoznaPostawicStatek(int indexAktualnegoStatku, int komorkaX, int komorkaY, 
            bool jestHoryzontalnie, int[,] komorki)
        {
            // są 2 wersje dla statku umieszonego pionowo i poziomo  =>   poziomo - true   ,  pionowo - false
            if(jestHoryzontalnie)
            {
                // sprawdzamy czy statek się zmieści na szerokość - ustawienie poziome
                if(komorkaX + Gra.RozmiaryStatkow[indexAktualnegoStatku] - 1 <= Gracz.OSTATNI_INDEX_PLANSZY)
                {
                    // pętla sprawdza pole przed i za statkiem (przed statkiem i za statkiem)
                    for(int i = Math.Max(0, komorkaX - 1);
                        i<= Math.Min(Gracz.OSTATNI_INDEX_PLANSZY, komorkaX + Gra.RozmiaryStatkow[indexAktualnegoStatku]); i++)
                    {
                        // pole nad i pod statkiem ( +1 i -1 nad statkiem)
                        for(int j = Math.Max(0, komorkaY - 1); 
                            j <= Math.Min(Gracz.OSTATNI_INDEX_PLANSZY, komorkaY + 1); j++)
                        {
                            if (komorki[i,j] != -1)
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
                // sprawdzamy czy statek zmieści się na wysokość - ustawienie pionowe
                if(komorkaY + Gra.RozmiaryStatkow[indexAktualnegoStatku] - 1 <= Gracz.OSTATNI_INDEX_PLANSZY)
                {
                    // sprawdzenie komórek z lewej i prawej strony statku ( +1, -1)
                    for (int i = Math.Max(0, komorkaX - 1);
                        i <= Math.Min(Gracz.OSTATNI_INDEX_PLANSZY, komorkaX + 1); i++)
                    {
                        // sprawdzenie komórek nad i pod statkiem (nad i przed stkiem)
                        for (int j = Math.Max(0, komorkaY - 1);
                            j <= Math.Min(Gracz.OSTATNI_INDEX_PLANSZY, komorkaY + Gra.RozmiaryStatkow[indexAktualnegoStatku]); j++)
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
        }

        private void planszaGracza_Paint(object sender, PaintEventArgs e)
        {
            Rysowanie.RysujUstawioneKomorki(Gra.Uzytkownik.Plansza, e);
        }
    }
}
