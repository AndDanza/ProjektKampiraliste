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
        private BindingList<drzava> listaDrzavaStan = null;
        private BindingList<drzava> listaDrzavaRod = null;
        private BindingList<vrsta_dokumenta> listaDokumenata = null;
        private BindingList<status_osobe> listaStatusaOsobe = null;
        private BindingList<smjestaj> listaSmjestaja = null;

        public PrijavaGostaForma()
        { 
            InitializeComponent();
        }

        private void pokreniUnosSmjestaj_Click(object sender, EventArgs e)
        {
            UnosSmjestajForma formaSmjestaj = new UnosSmjestajForma();
            formaSmjestaj.ShowDialog();

            using (var baza = new KampiralisteEntiteti())
            {
                this.listaSmjestaja = new BindingList<smjestaj>(baza.smjestajs.ToList());
            }

            odabirSmjestajaUnos.DataSource = this.listaSmjestaja;
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
                this.listaDrzavaStan = new BindingList<drzava>(baza.drzavas.ToList());
                this.listaDrzavaRod = new BindingList<drzava>(baza.drzavas.ToList());
                this.listaDokumenata = new BindingList<vrsta_dokumenta>(baza.vrsta_dokumenta.ToList());
                this.listaStatusaOsobe = new BindingList<status_osobe>(baza.status_osobe.ToList());
                this.listaSmjestaja = new BindingList<smjestaj>(baza.smjestajs.ToList());
            }

            unosDrzavaRod.DataSource = this.listaDrzavaRod;
            unosDrzavaStan.DataSource = this.listaDrzavaStan;
            unosVrstaDoc.DataSource = this.listaDokumenata;
            unosStatus.DataSource = this.listaStatusaOsobe;
            odabirSmjestajaUnos.DataSource = this.listaSmjestaja;
        }
    }
}
