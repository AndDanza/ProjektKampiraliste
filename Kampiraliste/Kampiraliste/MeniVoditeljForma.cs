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
    public partial class MeniVoditeljForma : Form
    {
        public MeniVoditeljForma()
        {
            InitializeComponent();
        }

        private void otvorPopisZaposlenikaAkcija_Click(object sender, EventArgs e)
        {
            ZaposleniciForma instancaZaposlenikForma = new ZaposleniciForma();
            instancaZaposlenikForma.ShowDialog();
        }

        private void otvoriPopisCjenikaAkcija_Click(object sender, EventArgs e)
        {
            CjenikForma instancaCjenikForma = new CjenikForma();
            instancaCjenikForma.ShowDialog();
        }

        private void otvoriPrijavuGostaAction_Click(object sender, EventArgs e)
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

        private void otvoriStatistikuAkcija_Click(object sender, EventArgs e)
        {
            PrikazStatistikeForma instancaStatistikaForma = new PrikazStatistikeForma();
            instancaStatistikaForma.Show();
        }

        private void stornoRacunaAkcija_Click(object sender, EventArgs e)
        {
            StorniranjeRacunaForma instancaStornoForma = new StorniranjeRacunaForma();
            instancaStornoForma.Show();
        }

        private void izlazAkcija_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
