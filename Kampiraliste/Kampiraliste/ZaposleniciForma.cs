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
    public partial class ZaposleniciForma : Form
    {
        private List<zaposlenik> popis;
        public ZaposleniciForma()
        {
            InitializeComponent();
            UcitajZaposlenike();
        }

        private void UcitajZaposlenike()
        {
            using (var ef = new KampiralisteEntiteti())
            {
                popis = new List<zaposlenik>(ef.zaposleniks.ToList());
            }
            zaposlenikBindingSource.DataSource = popis;

        }


        private void obrisiZaposlenika_Click(object sender, EventArgs e)
        {
            DialogResult rezultatUpita = MessageBox.Show("Jeste li sigurni da želite obrisati zaposlenika?", "Brisanje zaposlenika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rezultatUpita == DialogResult.Yes)
            {
                try
                {
                    using (var ef = new KampiralisteEntiteti())
                    {
                        zaposlenik za = zaposlenikBindingSource.Current as zaposlenik;
                        ef.zaposleniks.Attach(za);
                        ef.zaposleniks.Remove(za);
                        ef.SaveChanges();
                        UcitajZaposlenike();
                    }
                    MessageBox.Show("Zaposlenik uspješno obrisan");
                }
                catch
                {
                    MessageBox.Show("Zaposlenika nije moguće obrisati!");
                }
                
            }

        }

        private void azurirajZaposlenika_Click(object sender, EventArgs e)
        {
            zaposlenik za = zaposlenikBindingSource.Current as zaposlenik;
            AzurirajZaposlenikaForma azuriraj = new AzurirajZaposlenikaForma(zaposlenikBindingSource.Current as zaposlenik);
            azuriraj.ShowDialog();
            UcitajZaposlenike();
        }

        private void dodajNovogZaposlenika_Click(object sender, EventArgs e)
        {
            DodajZaposlenikaForma dodajNovog = new DodajZaposlenikaForma();
            dodajNovog.ShowDialog();
            UcitajZaposlenike();
        }
    }
}
