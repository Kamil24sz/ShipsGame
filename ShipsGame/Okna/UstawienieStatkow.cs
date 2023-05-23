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
    }
}
