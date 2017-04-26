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
        public PrijavaForma()
        {
            ef = new KampiralisteEntiteti();
            InitializeComponent();
            zaposlenik zaposlenik = new zaposlenik();
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
                    provjeraPrijave = true;
                    break;
                }
            }

            if (!provjeraPrijave)
            {
                MessageBox.Show("Unjeli ste krivo korisnicko ime ili lozinku!");
                return;
            }
           
            MessageBox.Show("Uspješna prijava!");
        }
    }
}
