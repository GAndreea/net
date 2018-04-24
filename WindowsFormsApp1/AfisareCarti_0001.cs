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
    public partial class AfisareCarti : Form
    {
        public AfisareCarti(int id)
        {
        
            InitializeComponent();
            cititorId.Text = id.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void afis_Click(object sender, EventArgs e)
        {
            var gen_carte = gen.Text;
            int id_gen = ClassLibrary1.Program.get_genId(gen_carte);

            if (id_gen == -1)
            {
                carti.Visible = false;
                nuCarti.Visible = true;
                alegere.Visible = false;
                rezultat.Visible = false;
                nuCarti.Text = "Nu sunt carti la acest gen.";
            } else
            {
                nuCarti.Visible = false;
                carti.Visible = true;
                alegere.Visible = true;
                rezultat.Visible = false;
                foreach (ListViewItem item in carti.Items)
                    carti.Items.Remove(item);
                foreach (ColumnHeader c in carti.Columns)
                    carti.Columns.Remove(c);
                var carti2 = ClassLibrary1.Program.listare_carti(id_gen);
                carti.Columns.Add("Titlu");
                carti.Columns.Add("Autor nume");
                carti.Columns.Add("Autor prenume");
                carti.AutoArrange = false;
                carti.View = View.Details;
                foreach (var c in carti2)
                {
                    string[] arr = new string[3];
                    ListViewItem itm; 
                    arr[0] = c.Titlu;
                    var a = ClassLibrary1.Program.get_autor((int)c.AutorId);
                    arr[1] = a.Nume;
                    arr[2] = a.Prenume;
                    itm = new ListViewItem(arr);
                    carti.Items.Add(itm);
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void imprumuta_Click(object sender, EventArgs e)
        {
            rezultat.Visible = true;
            var titlu_carte = titlu.Text;
            var autor_nume = numeAutor.Text;
            var autor_prenume = prenumeAutor.Text;
            var cititor_id = Int32.Parse(cititorId.Text);
            var carte_id = ClassLibrary1.Program.verifica_carte(autor_nume, autor_prenume, titlu_carte);
            if (carte_id==-1)
            {
                DateTime data = ClassLibrary1.Program.verifica_data(autor_nume, autor_prenume, titlu_carte);
                rezultat.Text = "Cartea nu este dispoinibla pana la: " + data.ToString();
            } else
            {
                ClassLibrary1.Program.imprumuta_carte(carte_id, cititor_id);
                rezultat.Text = "Carte imprumutata cu succes";
            }

        }
    }
}
