﻿using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kampiraliste
{
    public partial class RadSPrijavamaForma : Form
    {
        private BindingList<prijava> listaPrijava = null;
        KampiralisteEntiteti kontekst = null;

        public RadSPrijavamaForma()
        {
            InitializeComponent();
            kontekst = new KampiralisteEntiteti();
        }

        /// <summary>
        /// Učitavanje svih prijava prema odabranom parametru
        /// </summary>
        /// <param name="sortBy">Određuje stupac prema kojem se sortiraju prijave te je li uzlazno ili silazno</param>
        private void UcitajPrijave(int sortBy)
        {
            aktivnePrijaveListBox.Items.Clear();

            switch (sortBy)
            {
                case 1:
                    this.listaPrijava = new BindingList<prijava>(kontekst.prijavas.OrderBy(s => s.datum_prijave).ToList());
                    break;
                case 2:
                    this.listaPrijava = new BindingList<prijava>(kontekst.prijavas.OrderByDescending(s => s.datum_prijave).ToList());
                    break;
                case 3:
                    this.listaPrijava = new BindingList<prijava>(kontekst.prijavas.OrderByDescending(s => s.datum_odjave).ToList());
                    break;
                case 4:
                    this.listaPrijava = new BindingList<prijava>(kontekst.prijavas.OrderBy(s => s.datum_odjave).ToList());
                    break;
            };

            foreach (var item in listaPrijava)
            {
                aktivnePrijaveListBox.Items.Add((prijava)item);
            }
        }
        
        private void RadSPrijavamaForma_Load(object sender, EventArgs e)
        {
            UcitajPrijave(1);
        }

        /// <summary>
        /// Na dupli klik zčitava se odabrana prijava u formu PrijavaGostaForma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aktivnePrijaveListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            prijava azurirajPrijavu = aktivnePrijaveListBox.SelectedItem as prijava;
            PrijavaGostaForma instancaPrijavaGostaForma = new PrijavaGostaForma(azurirajPrijavu, kontekst);
            instancaPrijavaGostaForma.ShowDialog();

            UcitajPrijave(1);
            unosDolazakUzlazno.Checked = true;
        }

        private void akcijaFiltriraj_Click(object sender, EventArgs e)
        {
            if (unosDolazakUzlazno.Checked)
                UcitajPrijave(1);
            else if (unosDolazakSilazno.Checked)
                UcitajPrijave(2);
            else if (unosOdlazakSilazno.Checked)
                UcitajPrijave(3);
            else
                UcitajPrijave(4);
        }

        /// <summary>
        /// Otvara report s prikazom svih gostiju koji su još u kampiralištu, a nisu državljani RH
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void izradiKnjiguStranihAkcija_Click(object sender, EventArgs e)
        {
            KnjigaGostijuForma pregledStranihGostiju = new KnjigaGostijuForma(true);
            pregledStranihGostiju.ShowDialog();
        }

        /// <summary>
        /// Prikazuje report s državljanima RH koji su još uvijek u kampiralištu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void izradiKnjiguDomacihAkcija_Click(object sender, EventArgs e)
        {
            KnjigaGostijuForma pregledStranihGostiju = new KnjigaGostijuForma(false);
            pregledStranihGostiju.ShowDialog();
        }

        /// <summary>
        /// Dispose-anje konteksta prilikom zatvaranja forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadSPrijavamaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            kontekst.Dispose();
        }
    }
}
