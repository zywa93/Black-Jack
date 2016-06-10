using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Talia
    {
        public Queue<Karta> talia; //Queue-kolejka

        public void nowa_talia(){
             talia = new Queue<Karta>();

            List<Karta> temp = new List<Karta>();

            for (int i = 2; i <= 14; i++)
            {

                for (int j = 1; j <= 4; j++)
                {

                    int p; //ilość punkty
                    if (i <= 10)
                    {
                        p = i;
                    }
                    else if (i > 10 && i < 14)
                    {
                        p = 10;
                    }
                    else
                    {
                        p = 1;
                    }
                    Karta karteczka = new Karta(i, j, p);

                    temp.Add(karteczka); //do listy dodajemy obiekt
                }
            }
            for (int i = 0; i < temp.Count-1; i++)
            {
               Karta kopia = temp[i];
               System.Random losowanie = new Random();
               int ll=losowanie.Next(i+1, temp.Count-1);
               temp[i] = temp[ll];
               temp[ll]= kopia;
            }

            foreach (Karta karta in temp)
            {
                talia.Enqueue(karta);
            }
        }
        public Talia()
        {
            nowa_talia();
        }

        public void usun_talie()
        {
            talia = null;
        }


        public Karta zwroc()
        {
            return talia.Dequeue(); //zwraca i usuwa kartę
        }
    }
}
