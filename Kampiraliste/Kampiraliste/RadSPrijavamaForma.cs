﻿using System;
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
    public partial class RadSPrijavamaForma : Form
    {
        private BindingList<prijava> listaPrijava = null;
        //private gost gostSelect = null;

        public RadSPrijavamaForma()
        {
            InitializeComponent();
        }

        private void UcitajPrijave()
        {
            aktivnePrijaveListBox.Items.Clear();

            using (var baza = new KampiralisteEntiteti())
            {
                this.listaPrijava = new BindingList<prijava>(baza.prijavas.ToList());
                foreach (var item in listaPrijava)
                {
                    aktivnePrijaveListBox.Items.Add((prijava)item);
                }
            }
        }
        
        private void RadSPrijavamaForma_Load(object sender, EventArgs e)
        {
            UcitajPrijave();
        }

        private void aktivnePrijaveListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            prijava azurirajPrijavu = aktivnePrijaveListBox.SelectedItem as prijava;
            PrijavaGostaForma instancaPrijavaGostaForma = new PrijavaGostaForma(azurirajPrijavu);
            instancaPrijavaGostaForma.ShowDialog();

            UcitajPrijave();
        }
    }
}
