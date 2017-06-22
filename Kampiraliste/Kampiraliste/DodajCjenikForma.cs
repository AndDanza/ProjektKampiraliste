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
    public partial class DodajCjenikForma : Form
    {
        public DodajCjenikForma()
        {
            InitializeComponent();
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

        private void dodajNoviCjenik_Click(object sender, EventArgs e)
        {
            if (unosNaziv.Text == "" || unosCijena.Text == "" || !IsDigitsOnly(unosCijena.Text))
            {
                MessageBox.Show("Svi podaci moraju biti ispravno popunjeni!", "Ispravnost podataka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                DialogResult rezultatUpita = MessageBox.Show("Jeste li sigurni da želite dodati novu stavku cjenika?", "Dodavanje stavke cjenika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (rezultatUpita == DialogResult.Yes)
                {
                    try
                    {
                        using (var ef = new KampiralisteEntiteti())
                        {
                            vrsta_smjestaja vrsta = new vrsta_smjestaja
                            {
                                naziv = unosNaziv.Text,
                                iznos = decimal.Parse(unosCijena.Text)
                            };

                            ef.vrsta_smjestaja.Add(vrsta);
                            ef.SaveChanges();
                            this.Close();

                        }
                        MessageBox.Show("Stavka uspješno dodana!");
                    }
                    catch
                    {
                        MessageBox.Show("Stavka nije dodana pokušajte opet!");
                    }
                    
                }
            }
            
        }
    }
}
