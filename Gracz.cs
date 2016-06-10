using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Gracz
    {
         List<Karta> reka = new List<Karta>();
         int ilosc_punktow;
         public int get_ilosc_punktow()
         {
             return ilosc_punktow;
         }
         int zetony;

         public int ilosc_zetonow()
         {
             return zetony;
         }

        public void wygrana(int kasa){
            zetony = zetony + kasa;
        }



         public void pass()
         {
         }
         public void dobierz_karte(Karta kar)
         {
             ilosc_punktow = ilosc_punktow + kar.punkty;
             reka.Add(kar);
         }

         public void usun_kart()
         {
             reka.Clear();
             ilosc_punktow = 0;
         }

        public int obstaw(int ile_obstawiasz)
         {
             if (zetony >= ile_obstawiasz)
             {
                 zetony = zetony - ile_obstawiasz;
                 return ile_obstawiasz;
             }
             else
             {
                 int zz = zetony;
                 zetony = 0;
                 return zz;

             }
         }

         public Gracz()
         {
             ilosc_punktow = 0;
             zetony = 200;
             
         }
        
    }
}
