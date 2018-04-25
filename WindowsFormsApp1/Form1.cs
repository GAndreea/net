using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService2;

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

            Service1Client service1Client = new Service1Client();
            var carte_noua = new CARTEDTO()
            {
                Titlu = titlu_carte
            };
            AUTORDTO obiectAutor = service1Client.S_get_autor_by_name(nume_autor);
            if (obiectAutor == null)
            {
               var autor1 = new AUTORDTO()
               {
                  Nume = nume_autor,
                  Prenume = prenume_autor
               };
               service1Client.S_adauga_autor(autor1);
               carte_noua.AUTOR = autor1;
            }
            else
            {
               carte_noua.AUTOR = obiectAutor;
            }

            var obiectGen = service1Client.S_get_gen_by_name(gen_carte);
            if (obiectGen == null)
            {
                var gen1 = new GENDTO()
                {
                    Descriere = gen_carte
                };
                service1Client.S_aduga_gen(gen1);
                carte_noua.GEN = gen1;
            }
            else
            {
                carte_noua.GEN = obiectGen;
            }

            service1Client.S_achizitie_carte(carte_noua, nr_exemplare);
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

        private void restitue_Click(object sender, EventArgs e)
        {
            RestituieCarte f = new RestituieCarte();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Statistici f = new Statistici();
            f.Show();
        }
    }
}
