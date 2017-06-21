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
    public partial class MeniRecepcionerForma : Form
    {
        public MeniRecepcionerForma()
        {
            InitializeComponent();
        }

        private void otvoriPrijavuGostaAkcija_Click(object sender, EventArgs e)
        {
            PrijavaGostaForma instancaPrijavaGostaForma = new PrijavaGostaForma();
            instancaPrijavaGostaForma.ShowDialog();
        }

        private void otvoriRadSPrijavamaAkcija_Click(object sender, EventArgs e)
        {
            RadSPrijavamaForma instancaRadSPrijavamaForma = new RadSPrijavamaForma();
            instancaRadSPrijavamaForma.Show();
        }

        private void otvoriIzdavanjeRacunaAkcija_Click(object sender, EventArgs e)
        {
            IzdavanjeRacunaForma instancaRacunForma = new IzdavanjeRacunaForma();
            instancaRacunForma.Show();
        }

        private void izlazAkcija_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
