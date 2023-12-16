using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Stos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private string[] stos = new string[0];
        int dl;//dlugosc tabeli

        private void buttonWloz_Click(object sender, EventArgs e)
        {
            if (textBoxWpisz.Text != "")
            {
                textBoxWpisz.Focus();
                textBoxWpisz.SelectAll();
                dl = stos.Length + 1;
                
                //stworzenie kopi
                string[] tab = (string[])stos.Clone();
                //stworzenie nowego obiektu tablicy stos
                stos = new string[dl];
                //przekopiowanie zawartości tab do stos
                tab.CopyTo(stos, 0);
                //wpisanie elementu z textBox1
                stos[stos.Length - 1] = textBoxWpisz.Text;
                //połaczenie elementów tablicy w string
                textBoxPokaz.Text = String.Join(" ", stos);
                textBoxWpisz.Focus();
            }
        }

        private void buttonZdejmij_Click(object sender, EventArgs e)
        {
            if (stos.Length != 0)
            {
                dl = stos.Length - 1;
                string[] tab = new string[dl];
                Array.Copy(stos, tab, dl);
                stos = new string[dl];
                tab.CopyTo(stos, 0);
                textBoxPokaz.Text = String.Join(" ", stos);
            }
        }


    }
}
