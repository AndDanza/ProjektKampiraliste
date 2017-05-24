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
    public partial class AzurirajZaposlenikaForma : Form
    {
        zaposlenik zaposlenikZaIzmjenu;
        public AzurirajZaposlenikaForma()
        {
            InitializeComponent();
        }

        public AzurirajZaposlenikaForma(zaposlenik za)
        {
            
            InitializeComponent();
            if(za != null)
            {
                textBox1.Text = za.id.ToString();
                zaposlenikZaIzmjenu = za;
            }
                

            if (za == null)
                textBox1.Text = "null";

            textBoxIme.Text = za.ime;
            textBoxPrezime.Text = za.prezime;
            textBoxKorIme.Text = za.korisnicko_ime;
            textBoxVrsta.Text = za.vrsta_zaposlenika.ToString();
            textBoxLozinka.Text = za.lozinka;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ef = new KampiralisteEntiteti())
            {
                ef.zaposleniks.Remove(zaposlenikZaIzmjenu);
               /* zaposlenikZaIzmjenu.ime = textBoxIme.Text;
                zaposlenikZaIzmjenu.prezime = textBoxPrezime.Text;
                zaposlenikZaIzmjenu.korisnicko_ime = textBoxKorIme.Text;
                zaposlenikZaIzmjenu.vrsta_zaposlenika = int.Parse(textBoxVrsta.Text);
                zaposlenikZaIzmjenu.lozinka = textBoxLozinka.Text;*/
                ef.SaveChanges();
            }

        }
    }
}
