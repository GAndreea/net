using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            WcfService2.Service1 ser = new WcfService2.Service1();
            Service1Client service1Client = new Service1Client();
            var carte_noua = new CARTE()
            {
                Titlu = titlu_carte
            };
            if (obiectAutor == null)
            {
               var autor1 = new AUTOR()
               {
                  Nume = nume_autor,
                  Prenume = prenume_autor
               };
               ClassLibrary1.Program.adauga_autor(autor1);
               carte_noua.AutorId = autor1.AutorId;
               carte_noua.AUTOR = autor1;
            }
            else
            {
               carte_noua.AutorId = obiectAutor.AutorId;
               carte_noua.AUTOR = obiectAutor;
            }

            var obiectGen = ClassLibrary1.Program.get_gen_by_name(gen_carte);
            if (obiectGen == null)
            {
                var gen1 = new GEN()
                {
                    Descriere = gen_carte
                };
                ClassLibrary1.Program.adauga_gen(gen1);
                carte_noua.GenId = gen1.GenId;
                carte_noua.GEN = gen1;
            }
            else
            {
                carte_noua.GenId = obiectGen.GenId;
                carte_noua.GEN = obiectGen;
            }

            ClassLibrary1.Program.achizitie_carte(carte_noua, nr_exemplare);
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
