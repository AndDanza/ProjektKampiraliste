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

        public AzurirajZaposlenikaForma(zaposlenik zapo)
        {
            
            InitializeComponent();
            if(zapo != null)
            {
                zaposlenikZaIzmjenu = zapo;
            }

            unosIme.Text = zapo.ime;
            unosPrezime.Text = zapo.prezime;
            unosKorIme.Text = zapo.korisnicko_ime;
            unosVrsta.Text = zapo.vrsta_zaposlenika.ToString();
            unosLozinka.Text = zapo.lozinka;
        }

        private void spremiNovePodatke_Click(object sender, EventArgs e)
        {
            DialogResult rezultatUpita = MessageBox.Show("Jeste li sigurni da želite dodati novog zaposlenika?", "Dodavanje zaposlenika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rezultatUpita == DialogResult.Yes)
            {
                using (var ef = new KampiralisteEntiteti())
                {

                    ef.zaposleniks.Attach(zaposlenikZaIzmjenu);
                    zaposlenikZaIzmjenu.ime = unosIme.Text;
                    zaposlenikZaIzmjenu.prezime = unosPrezime.Text;
                    zaposlenikZaIzmjenu.korisnicko_ime = unosKorIme.Text;
                    zaposlenikZaIzmjenu.vrsta_zaposlenika = int.Parse(unosVrsta.Text);
                    zaposlenikZaIzmjenu.lozinka = unosLozinka.Text;
                    ef.SaveChanges();
                    this.Hide();
                    ZaposleniciForma formaZaposlenika = new ZaposleniciForma();
                    formaZaposlenika.ShowDialog();
                }
            }
                
            
        }
    }
}
