﻿using System;
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
    public partial class MeniRecepcionerForma : Form
    {
        zaposlenik prijavljeniZaposlenik = null;
        public MeniRecepcionerForma(zaposlenik prijavljeni)
        {
            InitializeComponent();
            this.prijavljeniZaposlenik = prijavljeni;
        }

        private void otvoriPrijavuGostaAkcija_Click(object sender, EventArgs e)
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

        private void izlazAkcija_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MeniRecepcionerForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            var path = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + path + "\\Resources\\korisnicka_dokumentacija.chm");
        }

        private void helpPictureBox_Click(object sender, EventArgs e)
        {
            var path = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + path + "\\Resources\\korisnicka_dokumentacija.chm");
        }
    }
}
