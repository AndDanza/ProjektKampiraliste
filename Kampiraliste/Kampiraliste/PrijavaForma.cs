using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kampiraliste
{
    public partial class PrijavaForma : Form
    {
        //KampiralisteEntiteti ef;
        zaposlenik prijavljeniZaposlenik;
        public PrijavaForma()
        {
            //ef = new KampiralisteEntiteti();
            InitializeComponent();
            //zaposlenik zaposlenik = new zaposlenik();
            prijavljeniZaposlenik = new zaposlenik();
        }
        
        private void PrijaviMe(object sender, EventArgs e)
        {
            try
            {
                using (KampiralisteEntiteti ef = new KampiralisteEntiteti())
                {
                    bool provjeraPrijave = false;

                    foreach (var zaposlenik in ef.zaposleniks)
                    {
                        if (zaposlenik.korisnicko_ime == unosKorisnickoIme.Text && zaposlenik.lozinka == unosLozinka.Text)
                        {
                            prijavljeniZaposlenik = zaposlenik;
                            provjeraPrijave = true;
                            break;
                        }
                    }

                    if (!provjeraPrijave)
                    {
                        MessageBox.Show("Unjeli ste krivo korisnicko ime ili lozinku!");
                        return;
                    }

                    if (prijavljeniZaposlenik.vrsta_zaposlenika == 1)
                    {
                        MessageBox.Show("Uspješna prijava!");
                        MeniVoditeljForma formaUredi = new MeniVoditeljForma();
                        formaUredi.Show();
                    }

                    if (prijavljeniZaposlenik.vrsta_zaposlenika == 2)
                    {
                        MessageBox.Show("Uspješna prijava!");
                        MeniRecepcionerForma formaUredi = new MeniRecepcionerForma();
                        formaUredi.Show();

                    }
                }
            }catch
            {
                MessageBox.Show("Niste povezani na internet!", "eKamp", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
                


        }

        private void PrijavaForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            var path = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + path + "\\Resources\\korisnicka_dokumentacija.chm");
        }

        private void helpPictureBox_MouseHover(object sender, EventArgs e)
        {
            toolTipForHelpIcon.SetToolTip(helpPictureBox, "Kliknite na ikonu ili pritisnite tipku F1");
        }

        private void helpPictureBox_Click(object sender, EventArgs e)
        {
            var path = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + path + "\\Resources\\korisnicka_dokumentacija.chm");
        }

        
    }
}
