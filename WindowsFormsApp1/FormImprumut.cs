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
            Service1Client service1Client = new Service1Client();

            var id_user = service1Client.S_verifica_cititor(email_user);
            if (id_user==-1)
            {
                CITITORDTO c = new CITITORDTO()
                {
                    Nume = nume_user,
                    Prenume = prenume_user,
                    Adresa = adresa_user,
                    Email = email_user,
                    Stare = BitConverter.GetBytes(0)
                };
                service1Client.S_adauga_cititor(c);
                rezultat.Text = "User nou creat";
                rezultat.Visible = true;
                pas3.Visible = true;
            }
            else
            {
                int st = service1Client.S_get_stare(id_user);
                rezultat.Text = "Stare: " + st.ToString();
                rezultat.Visible = true;
                pas3.Visible = true;
            }

        }

        private void pas3_Click(object sender, EventArgs e)
        {
            Service1Client service1Client = new Service1Client();

            var cId = service1Client.S_verifica_cititor(email.Text);
            AfisareCarti f3 = new AfisareCarti(cId);
            f3.Show();
        }
    }
}
