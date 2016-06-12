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
    public partial class Form1 : Form
    {
       
       
        public Form1()
        {
            InitializeComponent();
        }

        
        private void zabierzZetony(int ilosc)
        {
            Program.pula+=Program.Graczyk.obstaw(ilosc) + Program.Krupier.obstaw(ilosc);
            Program.zamienEkrany();
        }


        private void Zeton10_Click(object sender, EventArgs e)
        {
            zabierzZetony(10);
         
        }

        private void Zeton25_Click(object sender, EventArgs e)
        {
            zabierzZetony(25);
        }

        private void Zeton50_Click(object sender, EventArgs e)
        {
            zabierzZetony(50);
        }

    }
}
