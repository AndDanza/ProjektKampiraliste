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
        KampiralisteEntiteti kontekst = null;

        private BindingList<drzava> listaDrzavaStan = null;
        private BindingList<drzava> listaDrzavaRod = null;
        private BindingList<vrsta_dokumenta> listaDokumenata = null;
        private BindingList<status_osobe> listaStatusaOsobe = null;
        private BindingList<smjestaj> listaSmjestaja = null;

        public PrijavaGostaForma()
        { 
            InitializeComponent();
            this.kontekst = new KampiralisteEntiteti();
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

            this.listaSmjestaja = new BindingList<smjestaj>(kontekst.smjestajs.ToList());
            smjestajBindingSource.DataSource = this.listaSmjestaja;
        }

        /// <summary>
        /// Učitava sve podatke u combobox-eve
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrijavaGostaForma_Load(object sender, EventArgs e)
        {
            this.listaDrzavaStan = new BindingList<drzava>(kontekst.drzavas.ToList());
            this.listaDrzavaRod = new BindingList<drzava>(kontekst.drzavas.ToList());
            this.listaDokumenata = new BindingList<vrsta_dokumenta>(kontekst.vrsta_dokumenta.ToList());
            this.listaStatusaOsobe = new BindingList<status_osobe>(kontekst.status_osobe.ToList());
            this.listaSmjestaja = new BindingList<smjestaj>(kontekst.smjestajs.ToList());

            drzavaRodBindingSource.DataSource = this.listaDrzavaRod;
            drzavaStanBindingSource.DataSource = this.listaDrzavaStan;
            vrstadokumentaBindingSource.DataSource = this.listaDokumenata;
            statusosobeBindingSource.DataSource = this.listaStatusaOsobe;
            smjestajBindingSource.DataSource = this.listaSmjestaja;
        }

        /// <summary>
        /// Pohrana gosta u bazu podataka.
        /// </summary>
        /// <returns>Povratna vrijednos je objekt tipa gost.</returns>
        private gost PohraniGosta()
        {
            vrsta_dokumenta dokument = unosVrstaDoc.SelectedItem as vrsta_dokumenta;
            drzava drzavaStan = unosDrzavaStan.SelectedItem as drzava;
            drzava drzavaRod = unosDrzavaRod.SelectedItem as drzava;
            string spol = unosSpolMuski.Checked ? spol = "M" : spol = "Ž";

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

            kontekst.gosts.Add(noviGost);
            kontekst.SaveChanges();

            return noviGost;
        }

        /// <summary>
        /// Na temelju unesenih podataka provjerava se postoji li gost.
        /// </summary>
        /// <returns>Povratna vrijednost je tipa int, a 0 oznaava da gost ne postoji dok sve različito od 0 predstavlja id gosta.</returns>
        private int ProvjeraGosta()
        {
            int gostPostoji = 0;
            string ime = unosIme.Text;
            string prezime = unosPrezime.Text;
            string drzavaRodenja = (unosDrzavaRod.SelectedItem as drzava).id;

            if (String.IsNullOrEmpty(ime) || String.IsNullOrEmpty(prezime) || String.IsNullOrEmpty(drzavaRodenja) || String.IsNullOrEmpty(unosDatumRodenja.Text))
            {
                throw new KampiralisteException("Nisu uneseni podaci o gostu!", this.Name);
            }
            else
            {
                DateTime datumRodenja = DateTime.Parse(unosDatumRodenja.Text);

                gostPostoji = (from b in kontekst.gosts
                               where b.ime == ime && b.prezime == prezime && b.drzava_id_rodenja == drzavaRodenja && b.datum_rodenja == datumRodenja
                               select b.id).FirstOrDefault();
            }

            return gostPostoji;
        }

        /// <summary>
        /// Pohrana prijave za danog gosta u bazu podataka.
        /// </summary>
        /// <param name="prijaviGosta">Objekt tipa gost za kojeg se unosi prijava.</param>
        private void PohraniPrijavu(gost prijaviGosta)
        {
            //privremeni select zaposlenika za unos prijave
            zaposlenik unioPrijavu = (from b in kontekst.zaposleniks
                        where b.id == 2
                        select b).FirstOrDefault();

            string orgDolaska = unosOsobno.Checked ? "O" : "A";
            smjestaj odabraniSmjestaj = odabirSmjestajaUnos.SelectedItem as smjestaj;
            status_osobe odabraniStatus = unosStatus.SelectedItem as status_osobe;

            if (String.IsNullOrEmpty(unosDatumDolaska.Text) || String.IsNullOrEmpty(unosDatumOdlaska.Text))
            {
                throw new KampiralisteException("Nisu uneseni podaci prijave!", this.Name);
            }
            else
            {
                DateTime datumPrijave = DateTime.Parse(unosDatumDolaska.Text);
                DateTime datumOdjave = DateTime.Parse(unosDatumOdlaska.Text);

                prijava prijavaGosta = new prijava
                {
                    gost1 = prijaviGosta,
                    datum_prijave = datumPrijave,
                    datum_odjave = datumOdjave,
                    organizacija_dolaska = orgDolaska,
                    status_osobe = odabraniStatus,
                    zaposlenik = unioPrijavu,
                    smjestaj = odabraniSmjestaj
                };

                kontekst.prijavas.Add(prijavaGosta);
                kontekst.SaveChanges();
            }
        }

        private void potvrdiPrijavu_Click(object sender, EventArgs e)
        {
            try
            {
                int idGosta = ProvjeraGosta();

                switch (idGosta)
                {
                    case 0:
                        gost pohranjeniGost = PohraniGosta();
                        PohraniPrijavu(pohranjeniGost);
                        break;
                };
            }
            catch(KampiralisteException ex)
            {
                MessageBox.Show(ex.PorukaIznimke, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Metoda koja se aktivira gašenjem forme i briše kontekst entityframwork-a.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrijavaGostaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            kontekst.Dispose();
        }
    }
}
