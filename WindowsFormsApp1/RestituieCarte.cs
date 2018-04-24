using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W
namespace WindowsFormsApp1
{
    public partial class RestituieCarte : Form
    {
        public RestituieCarte()
        {
            InitializeComponent();
        }

        private void imprumuturi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nuImprumuturi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var email_user = emailBox.Text;
            var id_user = ClassLibrary1.Program.verifica_cititor(email_user);
            
            if (id_user == -1)
            {
                restituieGrup.Visible = false;
                imprumuturi.Visible = false;

                nuImprumuturi.Text = "Nu exista imrumuturi pt adresa data";
                nuImprumuturi.Visible = true;
            }
            else
            {
                var imprumuturi1 = ClassLibrary1.Program.get_imprumuturi(id_user);
                if (imprumuturi1.Count == 0)
                {
                    restituieGrup.Visible = false;
                    imprumuturi.Visible = false;

                    nuImprumuturi.Text = "Nu exista imprumuturi pt adresa data";
                    nuImprumuturi.Visible = true;
                } else
                {
                    restituieGrup.Visible = true;
                    imprumuturi.Visible = true;
                    nuImprumuturi.Visible = false;
                    foreach (ListViewItem item in imprumuturi.Items)
                        imprumuturi.Items.Remove(item);
                    foreach (ColumnHeader c in imprumuturi.Columns)
                        imprumuturi.Columns.Remove(c);
                    imprumuturi.Columns.Add("Id");
                    imprumuturi.Columns.Add("Titlu");
                    imprumuturi.Columns.Add("Autor");
                    imprumuturi.Columns.Add("Data imprumut");
                    imprumuturi.Columns.Add("Data scadenta");
                    imprumuturi.Columns.Add("Data returnare");
                    imprumuturi.AutoArrange = false;
                    imprumuturi.View = View.Details;
                    foreach (var c in imprumuturi1)
                    {
                        string[] arr = new string[6];
                        ListViewItem itm;
                        arr[0] = c.ImprumutId.ToString();
                        var c1 = ClassLibrary1.Program.get_carte((int)c.CarteId);
                        arr[1] = c1.Titlu;
                        var a = ClassLibrary1.Program.get_autor((int)c1.AutorId);
                        arr[2] = a.Nume + " " + a.Prenume;
                        arr[3] = (c.DataImprumut).ToString();
                        arr[4] = (c.DataScadenta).ToString();
                        arr[5] = (c.DataRestituire).ToString();
                        itm = new ListViewItem(arr);
                        imprumuturi.Items.Add(itm);
                    }

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var imprumut_id = Int32.Parse(idImprumut.Text);
            var review_text = review.Text;
            rezultat.Visible = true;
            ClassLibrary1.Program.restituie_carte(imprumut_id);
            var new_review = new REVIEW()
            {
                ImprumutId = imprumut_id,
                Text = review_text
            };
            ClassLibrary1.Program.adauga_review(new_review);
            rezultat.Text = "Restituit";
        }
    }
}
