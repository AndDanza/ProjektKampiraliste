using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kampiraliste
{
    public partial class AzurirajCjenikForma : Form
    {
        private vrsta_smjestaja vrstaSmjestajaZaIzmjenu;
        public AzurirajCjenikForma()
        {
            InitializeComponent();
        }

        public AzurirajCjenikForma(vrsta_smjestaja vrsta)
        {

            InitializeComponent();
            if (vrsta != null)
            {
                vrstaSmjestajaZaIzmjenu = vrsta;
                unosNaziv.Text = vrsta.naziv;
                unosCijena.Text = vrsta.iznos.ToString();
            }
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        private void spremiPromjene_Click(object sender, EventArgs e)
        {
            if (unosNaziv.Text == "" || unosCijena.Text == "" || !IsDigitsOnly(unosCijena.Text))
            {
                MessageBox.Show("Svi podaci moraju biti ispravno popunjeni!", "Ispravnost podataka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                DialogResult rezultatUpita = MessageBox.Show("Jeste li sigurni da želite ažurirati stavku cjenika?", "Ažuriranje stavke cjenika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (rezultatUpita == DialogResult.Yes)
                {
                    try
                    {
                        using (var ef = new KampiralisteEntiteti())
                        {

                            ef.vrsta_smjestaja.Attach(vrstaSmjestajaZaIzmjenu);
                            vrstaSmjestajaZaIzmjenu.naziv = unosNaziv.Text;
                            vrstaSmjestajaZaIzmjenu.iznos = decimal.Parse(unosCijena.Text);
                            ef.SaveChanges();
                            this.Close();
                        }
                        MessageBox.Show("Stavka cjenika uspješno ažurirana!");
                    }
                    catch
                    {
                        MessageBox.Show("Stavka cjenika nije ažurirana. Pokušajte ponovo!");
                    }
                    
                }
                
            }
            
        }

     
    }
}
