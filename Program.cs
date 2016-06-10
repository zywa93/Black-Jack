using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static Gracz Krupier = new Gracz();
        public static Gracz Graczyk = new Gracz();
        public static Talia Talunia = new Talia();


        static Form1 obstawianie;
        static Form2 gra;
        public static int pula = 0;
        static bool gracz_pass = false;
        static bool krupier_pass = false;
        static bool krupier_przegral = false;
        public static void zamienEkrany(){
            obstawianie.Hide();
            Graczyk.dobierz_karte(Talunia.zwroc());
            Krupier.dobierz_karte(Talunia.zwroc());
            gra.Show();
            gra.zaktualizujPunktyGracza();
            gra.zaktualizujPunktyKrupiera();
            gra.pokaz_pieniadze();
        }

        public static void wrocDoObstawiania()
        {
           
            if (Graczyk.ilosc_zetonow() == 0) 
            {
                MessageBox.Show("Wygrał Krupier");
                Application.Exit();
            }
            else if(Krupier.ilosc_zetonow()==0){
                MessageBox.Show("Wygrał Gracz");
                Application.Exit();
            }
            else
            {
                gra.Hide();
                obstawianie.Show();
                gra.wlacz_przyciski();
                gra.wyzeruj_punkty();
                gracz_pass = false;
                krupier_pass = false;
                krupier_przegral = false;
            }
        }
        static void tura_krupiera()
        {
            Krupier.dobierz_karte(Talunia.zwroc());
            gra.zaktualizujPunktyKrupiera();
            if (Krupier.get_ilosc_punktow() > 21)
            {
                krupier_przegral = true;
            }
            else if(Krupier.get_ilosc_punktow() == 21){
                krupier_pass = true;
            }
            else{
                if (Krupier.get_ilosc_punktow() > 16)
                {
                    krupier_pass = true;
                }
            }
            
        }
        public static void pass_gracza()
        {
            gracz_pass = true;
            while (krupier_pass == false)
            {
                tura_krupiera();
                if (krupier_przegral) break;
            }
            
            kto_blizej_wygranej();
            
        }

        public static void kto_blizej_wygranej()
        {

            
            int a = 21 - Graczyk.get_ilosc_punktow();
            int b = 21 - Krupier.get_ilosc_punktow();
            if (b < 0)
            {
                wygrales();
            }
            else if (a == b)
            {
                remis();
            }
            else if (a > b)
            {
                przegrales();
            }
            else
            {
                wygrales();
            }
            
            
            
            
        }

        static void remis()
        {
            restart();
            if (MessageBox.Show("Remis", "Wynik", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                wrocDoObstawiania();
            } 
        }

        static void restart()
        {
            Talunia.usun_talie();
            Talunia.nowa_talia();
            Graczyk.usun_kart();
            Krupier.usun_kart();
            
        }
        static void wygrales()
        {
            restart();
            Graczyk.wygrana(pula);
            pula = 0;
            if (MessageBox.Show("Wygrał Gracz", "Wynik", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                wrocDoObstawiania();
            } 
        }

        static void przegrales()
        {
            restart();
            Krupier.wygrana(pula);
            pula = 0;
            if (MessageBox.Show("Wygrał Krupier", "Wynik", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                wrocDoObstawiania();
            }    
        }


        public static void tura_gracza()
        {
            Graczyk.dobierz_karte(Talunia.zwroc());
            gra.zaktualizujPunktyGracza();
            if (Graczyk.get_ilosc_punktow() == 21)
            {
                pass_gracza();
            }
            else if (Graczyk.get_ilosc_punktow() > 21)
            {
                przegrales();
            }
            else if (krupier_pass == false)
            {
                tura_krupiera();
                if (krupier_przegral) kto_blizej_wygranej();
            }
            gra.wlacz_przyciski();
        }
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            obstawianie = new Form1();
            gra = new Form2();
            Application.Run(obstawianie);
        }
    }
    

}
