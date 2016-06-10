using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form2 : Form
    {
        public void pokaz_pieniadze()
        {
            Wartosc_puli.Text=Program.pula.ToString();
            Wartosc_zetonow_gracza.Text = Program.Graczyk.ilosc_zetonow().ToString();
            Wartosc_zetonow_krupiera.Text = Program.Krupier.ilosc_zetonow().ToString();
                
        }
        public Form2()
        {
            InitializeComponent();
     
        }
        public void zaktualizujPunktyGracza(){
            Punkty_Gracza.Text=Program.Graczyk.get_ilosc_punktow().ToString(); //rzutowanie

        }

        public void zaktualizujPunktyKrupiera()
        {
            Punkty_Krupiera.Text = Program.Krupier.get_ilosc_punktow().ToString();

        }

        public void wyzeruj_punkty()
        {
            Punkty_Gracza.Text = "0";
            Punkty_Krupiera.Text = "0";
        }
        private void dajKarte_Click(object sender, EventArgs e)
        {
            wylacz_przyciski();
            Program.tura_gracza();
            
        }

        public void wylacz_przyciski()
        {
            dajKarte.Enabled = false;
            Pasuj.Enabled = false;
        }
        public void wlacz_przyciski()
        {
            dajKarte.Enabled = true;
            Pasuj.Enabled = true; 
        }


        private void Pasuj_Click(object sender, EventArgs e)
        {
            wylacz_przyciski();
            Program.pass_gracza();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
