using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Karta
    {

        int numer;
        int symbol;
        public int punkty;

        public Karta(int num, int sym, int pun)
        {
            numer = num;
            symbol = sym;
            punkty = pun;
        }

    }
}
