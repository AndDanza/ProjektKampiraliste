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
    public partial class MeniVoditeljForma : Form
    {
        KampiralisteEntiteti ef;
        zaposlenik prijavljeniZaposlenik = null;
        public MeniVoditeljForma(zaposlenik prijavljeni)
        {
            ef = new KampiralisteEntiteti();
            InitializeComponent();
            this.prijavljeniZaposlenik = prijavljeni;
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
            PrijavaGostaForma instancaPrijavaGostaForma = new PrijavaGostaForma(this.prijavljeniZaposlenik);
            instancaPrijavaGostaForma.ShowDialog();
        }

        private void otvoriRadSPrijavamaAkcija_Click(object sender, EventArgs e)
        {
            RadSPrijavamaForma instancaRadSPrijavamaForma = new RadSPrijavamaForma(this.prijavljeniZaposlenik);
            instancaRadSPrijavamaForma.Show();
        }

        private void otvoriIzdavanjeRacunaAkcija_Click(object sender, EventArgs e)
        {
            IzdavanjeRacunaForma instancaRacunForma = new IzdavanjeRacunaForma(this.prijavljeniZaposlenik);
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

        private void MeniVoditeljForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            var path = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + path + "\\Resources\\korisnicka_dokumentacija.chm");
        }

        private void pictureBoxHelp_Click(object sender, EventArgs e)
        {
            var path = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + path + "\\Resources\\korisnicka_dokumentacija.chm");
        }
    }
}
