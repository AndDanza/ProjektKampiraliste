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
    public partial class DodajZaposlenikaForma : Form
    {

        List<int> vrsteZaposlenika = new List<int> { 1, 2 };
        
        public DodajZaposlenikaForma()
        {
            InitializeComponent();
            unosVrstaZaposlenika.DataSource = vrsteZaposlenika;
        }

        private void dodajZaposlenika_Click(object sender, EventArgs e)
        {
            DialogResult rezultatUpita = MessageBox.Show("Jeste li sigurni da želite dodati novog zaposlenika?", "Dodavanje zaposlenika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rezultatUpita == DialogResult.Yes)
            {
                using (var ef = new KampiralisteEntiteti())
                {
                    zaposlenik zap = new zaposlenik
                    {
                        ime = unosIme.Text,
                        prezime = unosPrezime.Text,
                        korisnicko_ime = unosKorIme.Text,
                        vrsta_zaposlenika = (int)unosVrstaZaposlenika.SelectedValue,
                        lozinka = unosLozinka.Text
                    };

                    ef.zaposleniks.Add(zap);
                    ef.SaveChanges();
                    this.Hide();
                    ZaposleniciForma formaZaposlenika = new ZaposleniciForma();
                    formaZaposlenika.ShowDialog();

                }
            }
           
        }

    }
}
