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
    public partial class PrijavaGostaForma : Form
    {
        BindingList<drzava> listaDrzavaStan = null;
        BindingList<drzava> listaDrzavaRod = null;
        BindingList<vrsta_dokumenta> listaDokumenata = null;
        BindingList<status_osobe> listaStatusaOsobe = null;

        public PrijavaGostaForma()
        {
            InitializeComponent();
        }

        private void pokreniUnosSmjestaj_Click(object sender, EventArgs e)
        {
            UnosSmjestajForma formaSmjestaj = new UnosSmjestajForma();
            formaSmjestaj.Show();
        }

        /// <summary>
        /// Učitava sve podatke u combobox-eve
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrijavaGostaForma_Load(object sender, EventArgs e)
        {
            using (var baza = new KampiralisteEntiteti())
            {
                listaDrzavaStan = new BindingList<drzava>(baza.drzavas.ToList());
                listaDrzavaRod = new BindingList<drzava>(baza.drzavas.ToList());
                listaDokumenata = new BindingList<vrsta_dokumenta>(baza.vrsta_dokumenta.ToList());
                listaStatusaOsobe = new BindingList<status_osobe>(baza.status_osobe.ToList());
            }

            unosDrzavaRod.DataSource = listaDrzavaRod;
            unosDrzavaStan.DataSource = listaDrzavaStan;
            unosVrstaDoc.DataSource = listaDokumenata;
            unosStatus.DataSource = listaStatusaOsobe;
        }
    }
}
