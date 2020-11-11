using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RistiNolla
{
    public partial class Form1 : Form
    {
        bool vuoro = true; // true = x false = y
        bool tietokonet_vastaa = false;
        int vuoro_numero = 0;
        //static string pelaaja1, pelaaja2;


        public Form1()
        {
            InitializeComponent();
        }

        /*
        // Muuta pelaajat nimiksi
        public static void PelaajienNimet(string n1, string n2)
        {           
            pelaaja1 = n1;
            pelaaja2 = n2;
        }
        */

        // Näytää ensin nimi ikkun/Form 2
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Form f2 = new Form2();
            f2.ShowDialog();
            PelaajaX.Text = pelaaja1;
            PelaajaO.Text = pelaaja2;
            */
        }

        // Peli ohjeet
        private void mitenToimiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("X aina aloitaa ensin ja peliä pelataan niin että yrität saada kolme X tai O riviiin painamalla ruudula olevia nappeja enenkun vastustajasi tekeesen sinua ennen, jos nimeät Pelaaja 2 CPU se muutaa Pelaaja 2 tietokoneeksi.");
        }

        // Poistumis nappi
        private void sammutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Paina nappia niin se vaihtaa sen X tai O riipuen kenen vuorosta ja vaihtaa vuorot
        private void nappi_click(object sender, EventArgs e)
        {
            try
            {
                Button n = (Button)sender;
                if (vuoro)
                {
                    n.Text = "X";
                }
                else
                {
                    n.Text = "O";
                }
                vuoro = !vuoro;
                n.Enabled = false;
                vuoro_numero++;
            }
            catch {}

            tarkistaVoittaja();

            if ((!vuoro) && (tietokonet_vastaa) )
            {
                tietokonet_tekee_liikeen();
            }
        }

        // Tietokone tekee liikeen
        private void tietokonet_tekee_liikeen()
        {
            Button liike = null;
            liike = etsi_voittoa_tai_estoa("O");
            if (liike == null)
            {
                liike = etsi_voittoa_tai_estoa("X");
                if (liike == null)
                {
                    liike = etsi_nurkka();
                    if (liike == null)
                    {
                        liike = etsi_vapaa_alue();
                    }
                }
            }
            liike.PerformClick();
        }

        // Etsii miten voi voitaa tai estää
        private Button etsi_voittoa_tai_estoa(string merkki)
        {
            Console.WriteLine("Etsi voittoa tai estoa:  " + merkki);

            // Sivuain liike
            if ((A1.Text == merkki) && (A2.Text == merkki) && (A3.Text == ""))
            {
                return A3;
            }
            if ((A2.Text == merkki) && (A3.Text == merkki) && (A1.Text == ""))
            {
                return A1;
            }
            if ((A1.Text == merkki) && (A3.Text == merkki) && (A2.Text == ""))
            {
                return A2;
            }

            if ((B1.Text == merkki) && (B2.Text == merkki) && (B3.Text == ""))
            {
                return B3;
            }
            if ((B2.Text == merkki) && (B3.Text == merkki) && (B1.Text == ""))
            {
                return A1;
            }
            if ((B1.Text == merkki) && (B3.Text == merkki) && (B2.Text == ""))
            {
                return B2;
            }

            if ((C1.Text == merkki) && (C2.Text == merkki) && (C3.Text == ""))
            {
                return A3;
            }
            if ((C2.Text == merkki) && (C3.Text == merkki) && (C1.Text == ""))
            {
                return A1;
            }
            if ((C1.Text == merkki) && (C3.Text == merkki) && (C2.Text == ""))
            {
                return C2;
            }

            // Vaaka liike
            if ((A1.Text == merkki) && (B1.Text == merkki) && (C1.Text == ""))
            {
                return C1;
            }
            if ((B1.Text == merkki) && (C1.Text == merkki) && (A1.Text == ""))
            {
                return A1;
            }
            if ((A1.Text == merkki) && (C1.Text == merkki) && (B1.Text == ""))
            {
                return B1;
            }

            if ((A2.Text == merkki) && (B2.Text == merkki) && (C2.Text == ""))
            {
                return C2;
            }
            if ((B2.Text == merkki) && (C2.Text == merkki) && (A2.Text == ""))
            {
                return A3;
            }
            if ((A2.Text == merkki) && (C2.Text == merkki) && (B2.Text == ""))
            {
                return B2;
            }

            if ((A3.Text == merkki) && (B3.Text == merkki) && (C3.Text == ""))
            {
                return C3;
            }
            if ((B3.Text == merkki) && (C3.Text == merkki) && (A3.Text == ""))
            {
                return A3;
            }
            if ((A3.Text == merkki) && (C3.Text == merkki) && (B3.Text == ""))
            {
                return B3;
            }

            // Vinno siirto
            if ((A1.Text == merkki) && (B2.Text == merkki) && (C3.Text == ""))
            {
                return C3;
            }
            if ((B2.Text == merkki) && (C3.Text == merkki) && (A1.Text == ""))
            {
                return A1;
            }
            if ((A1.Text == merkki) && (C3.Text == merkki) && (B2.Text == ""))
            {
                return B2;
            }

            if ((A3.Text == merkki) && (B2.Text == merkki) && (C3.Text == ""))
            {
                return C3;
            }
            if ((B2.Text == merkki) && (C3.Text == merkki) && (A1.Text == ""))
            {
                return A1;
            }
            if ((A1.Text == merkki) && (C3.Text == merkki) && (B2.Text == ""))
            {
                return B2;
            }

            return null;
        }

        private Button etsi_nurkka()
        {
            Console.WriteLine("Etsitään nurkka");
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }

                if (A1.Text == "O")
                    return A1;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C3.Text == "")
                    return C3;

            return null;
        }

        private Button etsi_vapaa_alue()
        {
            Console.WriteLine("Etsitään vapaata aluetta");
            Button n
        }

        // Tarkistaa voittajan
        private void tarkistaVoittaja()
        {
            bool voittaja_loityi = false;

            // Sivutain Voitto
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                voittaja_loityi = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                voittaja_loityi = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                voittaja_loityi = true;
            }

            // Ylhäältä Voitto
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                voittaja_loityi = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                voittaja_loityi = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                voittaja_loityi = true;
            }

            // Vino Voitto
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                voittaja_loityi = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                voittaja_loityi = true;
            }

            // Kertoo kuka voitta tai tuliko tasapeli
            if (voittaja_loityi)
            {
                poistaNappi();

                string voittaja = "";
                if (vuoro)
                {
                    voittaja = P2.Text;
                    O_voitto.Text = (Int32.Parse(O_voitto.Text) + 1).ToString(); 
                }
                else
                {
                    voittaja = P1.Text;
                    X_voitto.Text = (Int32.Parse(X_voitto.Text) + 1).ToString();
                }
                MessageBox.Show(voittaja + " Voitaa");
            }
            else
            {
                if (vuoro_numero == 9)
                {
                    Tasapaeli.Text = (Int32.Parse(Tasapaeli.Text) + 1).ToString();
                    MessageBox.Show("Tasapeli");
                }
            }
        }

        // Poistaa napin käytöstä kun sitä on painettu
        private void poistaNappi()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button n = (Button)c;
                    n.Enabled = false;
                }
            }
            catch{ }
        }

        //Uusi peli
        private void uusiPeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vuoro = true;
            vuoro_numero = 0;
       
                foreach (Control c in Controls)
                {
                try
                {
                    Button n = (Button)c;
                    n.Enabled = true;
                    n.Text = "";
                }
                catch { }
                }
        }

        // Näytää kenen vuoro napeissa
        private void nappi_tulee(object sender, EventArgs e)
        {
            try
            {
                Button n = (Button)sender;
                if (n.Enabled)
                {

                    if (vuoro)
                    {
                        n.Text = "X";
                    }
                    else
                    {
                        n.Text = "O";
                    }
                }
            }
            catch {}
        }

        // Tekeeniin että nappeihin ei jää vuoro merkit
        private void nappi_menee(object sender, EventArgs e)
        {
            try
            {
                Button n = (Button)sender;
                if (n.Enabled)
                {
                    n.Text = "";
                }
            }

            catch {}
        }

        private void resetPisteetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            O_voitto.Text = "0";
            X_voitto.Text = "0";
            Tasapaeli.Text = "0";
        }

        private void P2_TextChanged(object sender, EventArgs e)
        {
            if (P2.Text.ToUpper() == "CPU")
            {
                tietokonet_vastaa = true;
            }
            else
            {
                tietokonet_vastaa = false;
            }
        }

        private void setPlayerDeafultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Text = "Pelaaja 1";
            P2.Text = "CPU";
        }
    }
}
