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
        private zaposlenik zaposlenikZaIzmjenu;
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
            if (unosIme.Text == "" || unosPrezime.Text=="" || unosKorIme.Text=="" || unosVrsta.Text=="" || unosLozinka.Text=="")
            {
                MessageBox.Show("Svi podaci moraju biti popunjeni!", "Ispravnost podataka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                DialogResult rezultatUpita = MessageBox.Show("Jeste li sigurni da želite ažurirati zaposlenika?", "Ažuriranje zaposlenika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (rezultatUpita == DialogResult.Yes)
                {
                    try
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
                            this.Close();
                        }
                        MessageBox.Show("Zaposlenik uspješno ažuriran!");
                    }
                    catch
                    {
                        MessageBox.Show("Zaposlenik nije ažuriran pokušajte ponovo!");
                    }
                    
                }
            }
            
                
            
        }
    }
}
