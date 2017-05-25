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

        /// <summary>
        /// Pokretanje forme za unos smještaja te osvježavanje combobox-a smještaja.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            drzavaRodBindingSource.DataSource = this.listaDrzavaRod;
            drzavaStanBindingSource.DataSource = this.listaDrzavaStan;
            vrstadokumentaBindingSource.DataSource = this.listaDokumenata;
            statusosobeBindingSource.DataSource = this.listaStatusaOsobe;
            smjestajBindingSource.DataSource = this.listaSmjestaja;
        }

        private void UnosGosta()
        {
            MessageBox.Show("Vaš gost ne postoji u bazi!");

            vrsta_dokumenta dokument = unosVrstaDoc.SelectedItem as vrsta_dokumenta;
            drzava drzavaStan = unosDrzavaStan.SelectedItem as drzava;
            drzava drzavaRod = unosDrzavaRod.SelectedItem as drzava;
            string spol = unosSpolMuski.Checked ? spol = "M" : spol = "Ž";

            using (var baza = new KampiralisteEntiteti())
            {
                baza.vrsta_dokumenta.Attach(dokument);
                baza.drzavas.Attach(drzavaStan);
                baza.drzavas.Attach(drzavaRod);

                gost noviGost = new gost
                {
                    spol = spol,
                    ime = unosIme.Text,
                    prezime = unosPrezime.Text,
                    vrsta_dokumenta = dokument,
                    broj_dokumenta = unosBrojDoc.Text,
                    drzava1 = drzavaRod,
                    drzava = drzavaStan,
                    datum_rodenja = DateTime.Parse(unosDatumRodenja.Text)
                };

                baza.gosts.Add(noviGost);
                baza.SaveChanges();
            }
        }

        private int ProvjeraGosta()
        {
            int gostPostoji = 0;

            string ime = unosIme.Text;
            string prezime = unosPrezime.Text;
            string drzavaRodenja = (unosDrzavaRod.SelectedItem as drzava).id;
            
            try
            {
                DateTime datumRodenja = DateTime.Parse(unosDatumRodenja.Text);

                if (String.IsNullOrEmpty(ime) || String.IsNullOrEmpty(prezime) || String.IsNullOrEmpty(drzavaRodenja) || String.IsNullOrEmpty(unosDatumRodenja.Text))
                {
                    throw new Exception();
                }
                else
                {
                    using (var baza = new KampiralisteEntiteti())
                    {
                        gostPostoji = (from b in baza.gosts
                                       where b.ime == ime && b.prezime == prezime && b.drzava_id_rodenja == drzavaRodenja && b.datum_rodenja == datumRodenja
                                       select b.id).FirstOrDefault();
                    }

                    
                }
            }
            catch
            {
                MessageBox.Show("Nisu uneseni svi podaci !!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gostPostoji = -1;
            }

            return gostPostoji;
        }

        private void potvrdiPrijavu_Click(object sender, EventArgs e)
        {
            int idGosta = ProvjeraGosta();

            if (idGosta == 0)
            {
                UnosGosta();
            }
            else if (idGosta != -1)
            {
                MessageBox.Show("Uneseni gost postoji");
            }
            
        }
    }
}
