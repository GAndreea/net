using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var titlu_carte = titluCarte.Text;
            var nume_autor = numeAutor.Text;
            var prenume_autor = prenumeAutor.Text;
            var gen_carte = gen.Text;
            var nr_exemplare = Int32.Parse(nrExemplare.Text);

            ClassLibrary1.Program.achizitie_carte(titlu_carte, nume_autor, prenume_autor, gen_carte, nr_exemplare);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormImprumut f = new FormImprumut();
            f.Show();
           // this.Close();
        }
    }
}
