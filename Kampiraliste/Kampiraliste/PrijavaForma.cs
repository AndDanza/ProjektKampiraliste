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
    public partial class PrijavaForma : Form
    {
        KampiralisteEntiteti ef;
        zaposlenik prijavljeniZaposlenik;
        public PrijavaForma()
        {
            ef = new KampiralisteEntiteti();
            InitializeComponent();
            //zaposlenik zaposlenik = new zaposlenik();
            prijavljeniZaposlenik = new zaposlenik();
        }

        private void zapamtiMeCheckedChanged(object sender, EventArgs e)
        {
            

        }
        
        private void PrijaviMe(object sender, EventArgs e)
        {
            bool provjeraPrijave = false;
            
            foreach (var zaposlenik in ef.zaposleniks)
            {
                if (zaposlenik.korisnicko_ime == korisnickoIme.Text && zaposlenik.lozinka == lozinka.Text)
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

            if(prijavljeniZaposlenik.vrsta_zaposlenika == 1)
            {
                MessageBox.Show("Uspješna prijava!");
                Admin formaUredi = new Admin();
                formaUredi.ShowDialog();
            }

            if (prijavljeniZaposlenik.vrsta_zaposlenika == 2)
            {
                MessageBox.Show("Uspješna prijava!");
                Radnik formaUredi = new Radnik();
                formaUredi.ShowDialog();
            }


        }
    }
}
