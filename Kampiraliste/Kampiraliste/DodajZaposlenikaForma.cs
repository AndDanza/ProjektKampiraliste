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
        List<int> vrsteZaposlenika = new List<int>();
      
        public DodajZaposlenikaForma()
        {
            InitializeComponent();
            vrsteZaposlenika.Add(1);
            vrsteZaposlenika.Add(2);

            comboBoxVrstaZaposlenika.DataSource = vrsteZaposlenika;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ef = new KampiralisteEntiteti())
            {
                zaposlenik zap = new zaposlenik {
                    ime = textBoxIme.Text,
                    prezime = textBoxPrezime.Text,
                    korisnicko_ime = textBoxKorIme.Text,
                    vrsta_zaposlenika = (int)comboBoxVrstaZaposlenika.SelectedValue,
                    lozinka = textBoxLozinka.Text              
                };

                ef.zaposleniks.Add(zap); //Dodajemo tim u odgovarajuću kolekciju u kontekstu.
                ef.SaveChanges();


                List<zaposlenik> popis = new List<zaposlenik>();
                zaposlenik pop = (from z in ef.zaposleniks
                             where z.vrsta_zaposlenika == 1
                             select z).First<zaposlenik>();
                //popis.Add(pop);

                var pop1 = ef.zaposleniks.Where(z => z.vrsta_zaposlenika == 1);
                foreach (var zapo in pop1)
                {
                    popis.Add(zapo);
                }
                zaposlenikBindingSource.DataSource = popis;
            }
        }

        private void zaposlenikBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            zaposlenik za = zaposlenikBindingSource.Current as zaposlenik;
            textBox1.Text = za.ime;
        }
    }
}
