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
    public partial class FormImprumut : Form
    {
        public FormImprumut()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var email_user = email.Text;
            var nume_user = nume.Text;
            var prenume_user = prenume.Text;
            var adresa_user = adresa.Text;
            var id_user = ClassLibrary1.Program.verifica_cititor(email_user);
            if (id_user==-1)
            {
                ClassLibrary1.Program.adauga_cititor(nume_user, prenume_user, adresa_user, email_user);
                rezultat.Text = "User nou creat";
                rezultat.Visible = true;
                pas3.Visible = true;
            }
            else
            {
                int st = ClassLibrary1.Program.get_stare(id_user);
                rezultat.Text = "Stare: " + st.ToString();
                rezultat.Visible = true;
                pas3.Visible = true;
            }

        }

        private void pas3_Click(object sender, EventArgs e)
        {
            var cId = ClassLibrary1.Program.verifica_cititor(email.Text);
            AfisareCarti f3 = new AfisareCarti(cId);
            f3.Show();
        }
    }
}
