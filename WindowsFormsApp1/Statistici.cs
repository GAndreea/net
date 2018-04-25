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
    public partial class Statistici : Form
    {
        public Statistici()
        {
            InitializeComponent();
            Service1Client service1Client = new Service1Client();

            cititori.Text = ClassLibrary1.Program.get_nrCititori().ToString();

            var carti = ClassLibrary1.Program.clasament_carti();
            
            listCarti.Columns.Add("Titlu");
            listCarti.Columns.Add("Autor");
            listCarti.Columns.Add("Imprumuturi");
            listCarti.AutoArrange = false;
            listCarti.View = View.Details;
            foreach (var c in carti)
            {
                string[] arr = new string[3];
                ListViewItem itm;
                arr[0] = c.Titlu;
                var a = ClassLibrary1.Program.get_autor((int)c.AutorId);
                arr[1] = a.Nume + a.Prenume;
                arr[2] = ClassLibrary1.Program.imprumuturi_carte(c.CarteId).ToString();
                
                itm = new ListViewItem(arr);
                listCarti.Items.Add(itm);
            }


            //autori
            var autori = ClassLibrary1.Program.clasament_autori();

            listAutori.Columns.Add("Nume Autor");
            listAutori.Columns.Add("Prenume Autor");
            listAutori.Columns.Add("Imprumuturi");
            listAutori.AutoArrange = false;
            listAutori.View = View.Details;
            foreach (var c in autori)
            {
                string[] arr = new string[3];
                ListViewItem itm;
                arr[0] = c.Nume;
                arr[1] = c.Prenume;
                arr[2] = ClassLibrary1.Program.imprumuturi_autor(c.AutorId).ToString();

                itm = new ListViewItem(arr);
                listAutori.Items.Add(itm);
            }

            //genuri
            var genuri = ClassLibrary1.Program.clasament_genuri();

            listGenuri.Columns.Add("Gen");
            listGenuri.Columns.Add("Imprumuturi");
            listGenuri.AutoArrange = false;
            listGenuri.View = View.Details;
            foreach (var c in genuri)
            {
                string[] arr = new string[2];
                ListViewItem itm;
                arr[0] = c.Descriere;
                arr[1] = ClassLibrary1.Program.imprumuturi_gen(c.GenId).ToString();

                itm = new ListViewItem(arr);
                listGenuri.Items.Add(itm);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listCititori.Visible = true;
            var start_date = dela.Value;
            var end_date = panala.Value;
            var cititori = ClassLibrary1.Program.cititori_perioada(start_date, end_date);
            foreach (ListViewItem item in listCititori.Items)
                listCititori.Items.Remove(item);
            foreach (ColumnHeader c in listCititori.Columns)
                listCititori.Columns.Remove(c);
            listCititori.Columns.Add("Nume");
            listCititori.Columns.Add("Prenume");

            listCititori.AutoArrange = false;
            listCititori.View = View.Details;
            foreach (var c in cititori)
            {
                string[] arr = new string[2];
                ListViewItem itm;
                arr[0] = c.Nume;
                arr[1] = c.Prenume;              
                itm = new ListViewItem(arr);
                listCititori.Items.Add(itm);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var carte_id = Int32.Parse(carteId.Text);
            var reviewuri = ClassLibrary1.Program.reviewuri_carte(carte_id);
            numeCarte.Text = ClassLibrary1.Program.get_titlu(carte_id);
            foreach (ListViewItem item in listReviewuri.Items)
                listReviewuri.Items.Remove(item);
            foreach (ColumnHeader c in listReviewuri.Columns)
                listReviewuri.Columns.Remove(c);
            listReviewuri.Columns.Add("Id");
            listReviewuri.Columns.Add("Review");

            listReviewuri.AutoArrange = false;
            listReviewuri.View = View.Details;
            foreach (var c in reviewuri)
            {
                string[] arr = new string[2];
                ListViewItem itm;
                arr[0] = c.ReviewId.ToString();
                arr[1] = c.Text;
                itm = new ListViewItem(arr);
                listReviewuri.Items.Add(itm);
            }
        }
    }
}
