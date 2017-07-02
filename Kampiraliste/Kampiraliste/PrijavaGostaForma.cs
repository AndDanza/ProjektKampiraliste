using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using PretvornikDatumDLL;
using System.Windows.Forms;

namespace Kampiraliste
{
    public partial class PrijavaGostaForma : Form
    {
        KampiralisteEntiteti kontekst = null;
        zaposlenik prijavljeniZaposlenik = null;

        private BindingList<drzava> listaDrzavaStan = null;
        private BindingList<drzava> listaDrzavaRod = null;
        private BindingList<vrsta_dokumenta> listaDokumenata = null;
        private BindingList<status_osobe> listaStatusaOsobe = null;
        private BindingList<smjestaj> listaSmjestaja = null;

        private prijava azurirajPrijavu = null;

        /// <summary>
        /// Konstruktor forme kod unosa novog gosta.
        /// </summary>
        public PrijavaGostaForma(zaposlenik prijavljeni)
        { 
            InitializeComponent();
            this.kontekst = new KampiralisteEntiteti();
            this.prijavljeniZaposlenik = prijavljeni;
        }

        /// <summary>
        /// Konstruktor forme prilikom ažuriranja prijave.
        /// </summary>
        /// <param name="ulazPrijava">Objekt klase prijava koji se ažurira</param>
        /// <param name="ulazniKontekst">Kontekst baze podataka</param>
        public PrijavaGostaForma(prijava ulazPrijava, KampiralisteEntiteti ulazniKontekst, zaposlenik prijavljeni)
        {
            InitializeComponent();
            this.kontekst = ulazniKontekst;
            this.azurirajPrijavu = ulazPrijava;
            this.prijavljeniZaposlenik = prijavljeni;
        }

        /// <summary>
        /// Početno popunjavanje forme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrijavaGostaForma_Load(object sender, EventArgs e)
        {
            UcitajMoguceOdabire();

            if (this.azurirajPrijavu != null)
            {
                UcitajPrijavu();
            }
        }

        /// <summary>
        /// Pokretanje forme za unos smještaja te osvježavanje combobox-a smještaja.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pokreniUnosSmjestaj_Click(object sender, EventArgs e)
        {
            UnosSmjestajForma formaSmjestaj = new UnosSmjestajForma(kontekst);
            formaSmjestaj.ShowDialog();

            if (this.azurirajPrijavu == null)
            {
                var upit = kontekst.smjestajs.Where(s => s.prijavas.Count() < s.broj_osoba);
                this.listaSmjestaja = new BindingList<smjestaj>(upit.ToList());
            }
            else
            {
                this.listaSmjestaja = new BindingList<smjestaj>(kontekst.smjestajs.ToList());
            }

            smjestajBindingSource.DataSource = this.listaSmjestaja;
        }

        /// <summary>
        /// Učitava podatke iz baze podataka u combobox-eve
        /// </summary>
        private void UcitajMoguceOdabire()
        {
            this.listaDrzavaStan = new BindingList<drzava>(kontekst.drzavas.ToList());
            this.listaDrzavaRod = new BindingList<drzava>(kontekst.drzavas.ToList());
            this.listaDokumenata = new BindingList<vrsta_dokumenta>(kontekst.vrsta_dokumenta.ToList());
            this.listaStatusaOsobe = new BindingList<status_osobe>(kontekst.status_osobe.ToList());
            this.listaSmjestaja = new BindingList<smjestaj>(kontekst.smjestajs.ToList());

            if(this.azurirajPrijavu == null)
            {
                var upit = kontekst.smjestajs.Where(s => s.prijavas.Count() < s.broj_osoba);
                this.listaSmjestaja = new BindingList<smjestaj>(upit.ToList());
            }
            else
            {
                this.listaSmjestaja = new BindingList<smjestaj>(kontekst.smjestajs.ToList());
            }
            

            drzavaRodBindingSource.DataSource = this.listaDrzavaRod;
            drzavaStanBindingSource.DataSource = this.listaDrzavaStan;
            vrstadokumentaBindingSource.DataSource = this.listaDokumenata;
            statusosobeBindingSource.DataSource = this.listaStatusaOsobe;
            smjestajBindingSource.DataSource = this.listaSmjestaja;
        }

        /// <summary>
        /// Pohrana novog gosta u bazu podataka.
        /// </summary>
        /// <returns>Povratna vrijednos je objekt tipa klase "gost".</returns>
        private gost NoviGost()
        {
            vrsta_dokumenta dokument = unosVrstaDoc.SelectedItem as vrsta_dokumenta;
            drzava drzavaStan = unosDrzavaStan.SelectedItem as drzava;
            drzava drzavaRod = unosDrzavaRod.SelectedItem as drzava;
            string spol = unosSpolMuski.Checked ? spol = "M" : spol = "Ž";

            gost krairajGosta = new gost
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

            kontekst.gosts.Add(krairajGosta);
            kontekst.SaveChanges();

            return krairajGosta;
        }

        /// <summary>
        /// Na temelju unesenih podataka provjerava se postoji li gost u bazi podataka.
        /// </summary>
        /// <returns>Objekt tipa klase gost ili null ukoliko nije pronađen</returns>
        private gost PostojiGostUBazi()
        {
            gost gostPostoji = null;

            string ime = unosIme.Text;
            string prezime = unosPrezime.Text;
            string drzavaRodenja = (unosDrzavaRod.SelectedItem as drzava).id;
            string spol = unosSpolMuski.Checked ? "M" : "Ž";

            if (String.IsNullOrEmpty(ime) || String.IsNullOrEmpty(prezime) || String.IsNullOrEmpty(drzavaRodenja) || String.IsNullOrEmpty(unosDatumRodenja.Text))
            {
                throw new KampiralisteException("Nisu uneseni podaci o gostu!", this.Name);
            }
            else
            {
                DateTime datumRodenja = DateTime.Parse(unosDatumRodenja.Text);

                gostPostoji = (from b in kontekst.gosts
                               where b.ime == ime && b.prezime == prezime && b.drzava_id_rodenja == drzavaRodenja && b.datum_rodenja == datumRodenja && b.spol == spol
                               select b).FirstOrDefault();
            }

            return gostPostoji;
        }

        /// <summary>
        /// Odgovara ili odabrani status unesenom datumu rođenja
        /// </summary>
        private void ProvjeraStatusa()
        {
            if(!String.IsNullOrEmpty(unosDatumRodenja.Text))
            {
                DateTime uneseniDatum;
                if(!DateTime.TryParse(unosDatumRodenja.Text, out uneseniDatum))
                {
                    throw new KampiralisteException("Datum rođenja je neispravno unesen", this.Name);
                }               
                DateTime trenutniDatum = DateTime.Now;

                status_osobe odabraniStatus = unosStatusOsobe.SelectedItem as status_osobe;

                int godine = trenutniDatum.Year - uneseniDatum.Year;
                if (trenutniDatum.Month < uneseniDatum.Month || (trenutniDatum.Month == uneseniDatum.Month && trenutniDatum.Day < uneseniDatum.Day))
                {
                    godine--;
                }

                switch(odabraniStatus.id)
                {
                    case 1:
                        if (godine > 12)
                        {
                            throw new KampiralisteException("Uneseni gost stariji je od 12 godina!", this.Name);
                        }
                        break;
                    case 2:
                        if(godine < 12 || godine > 18)
                        {
                            throw new KampiralisteException("Uneseni gost nije u rasponu od 12 do 18 godina starosti!", this.Name);
                        }
                        break;
                    case 3:
                        if(godine < 18)
                        {
                            throw new KampiralisteException("Uneseni gost mlađi je od 18 godina!", this.Name);
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Pohrana prijave za danog gosta u bazu podataka.
        /// </summary>
        /// <param name="prijaviGosta">Objekt tipa gost za kojeg se unosi prijava.</param>
        private void PohraniPrijavu(gost prijaviGosta)
        {
            string orgDolaska = unosOsobno.Checked ? "O" : "A";
            smjestaj odabraniSmjestaj = odabirSmjestajaUnos.SelectedItem as smjestaj;
            status_osobe odabraniStatus = unosStatusOsobe.SelectedItem as status_osobe;

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
                    zaposlenik = this.prijavljeniZaposlenik,
                    smjestaj = odabraniSmjestaj
                };

                kontekst.prijavas.Add(prijavaGosta);
                kontekst.SaveChanges();
            }
        }

        /// <summary>
        /// Prilikom uspješne prijave resetiraju se odabiri u combobox-evim i podaci u textbox-evim.
        /// </summary>
        private void ResetirajFormu()
        {
            //reset textboxeva
            if (unosSpolZenski.Checked)
                unosSpolMuski.Checked = true;
            unosIme.Text = "";
            unosBrojDoc.Text = "";
            unosDatumRodenja.Text = "";
            if (unosAgencijski.Checked)
                unosOsobno.Checked = true;

            //reset comboboxeva
            unosVrstaDoc.SelectedIndex = 0;
            unosDrzavaRod.SelectedIndex = 0;
            unosDrzavaStan.SelectedIndex = 0;
            unosStatusOsobe.SelectedIndex = 0;
        }

        /// <summary>
        /// Ako gost postoji, ažuriraju se podaci. Ukoliko je pronađena prijava za ažuriranje (korisnik želi 
        /// ažurirati podatke) ažuriraju se svi podaci o gostu.
        /// </summary>
        /// <param name="izmjeniGosta">Objekt tipa klase gost (sadrži podatke o gostu koje je je potrebno izmjeniti)</param>
        private void AzurirajGosta(gost izmjeniGosta)
        {
            kontekst.gosts.Attach(izmjeniGosta);

            vrsta_dokumenta noviDokument = unosVrstaDoc.SelectedItem as vrsta_dokumenta;
            drzava novaDrzavaStan = unosDrzavaStan.SelectedItem as drzava;
            
            //ako je učitana prijava za ažuriranje potrebno je izmjeniti sve podatke o gostu
            //u suprotnom ažurira se samo dio podataka o gostu
            if(this.azurirajPrijavu != null)
            {
                drzava novaDrzavaRod = unosDrzavaRod.SelectedItem as drzava;
                string spol = unosSpolMuski.Checked ? spol = "M" : spol = "Ž";

                izmjeniGosta.spol = spol;
                izmjeniGosta.ime = unosIme.Text;
                izmjeniGosta.prezime = unosPrezime.Text;
                izmjeniGosta.drzava1 = novaDrzavaRod;
                izmjeniGosta.datum_rodenja = DateTime.Parse(unosDatumRodenja.Text);
            }

            izmjeniGosta.vrsta_dokumenta = noviDokument;
            izmjeniGosta.broj_dokumenta = unosBrojDoc.Text;
            izmjeniGosta.drzava = novaDrzavaStan;
            
            kontekst.SaveChanges();
        }

        /// <summary>
        /// Ažurira podatke o prijavi i pohranjuje u bzau.
        /// </summary>
        private void AzurirajPrijavu()
        {
            kontekst.prijavas.Attach(this.azurirajPrijavu);

            AzurirajGosta(this.azurirajPrijavu.gost1);

            status_osobe noviStatusOsobe = unosStatusOsobe.SelectedItem as status_osobe;
            string noviOrgDolaska = unosOsobno.Checked ? "O" : "A";
            smjestaj noviSmjestaj = odabirSmjestajaUnos.SelectedItem as smjestaj;

            this.azurirajPrijavu.status_osobe = noviStatusOsobe;
            this.azurirajPrijavu.organizacija_dolaska = noviOrgDolaska;
            this.azurirajPrijavu.datum_prijave = DateTime.Parse(unosDatumDolaska.Text);
            this.azurirajPrijavu.datum_odjave = DateTime.Parse(unosDatumOdlaska.Text);
            this.azurirajPrijavu.smjestaj = noviSmjestaj;

            kontekst.SaveChanges();
        }

        /// <summary>
        /// Unos nove prijave (unos/ažuriranje gosta i unos nove prijave). Ako postoji gost ažurira zapise
        /// u suprotnom kreira novi zapis.
        /// </summary>
        private void NovaPrijava()
        {
            gost pohranjeniGost = PostojiGostUBazi();

            if (pohranjeniGost == null)
            {
                pohranjeniGost = NoviGost();
            }
            else
            {
                AzurirajGosta(pohranjeniGost);
            }

            PohraniPrijavu(pohranjeniGost);
        }

        private void potvrdiPrijavu_Click(object sender, EventArgs e)
        {
            try
            {
                ProvjeraStatusa();
                UsporedbaDatumDolaskaOdlaska();

                if (this.azurirajPrijavu == null)
                {
                    NovaPrijava();
                }
                else
                {
                    AzurirajPrijavu();
                }

                MessageBox.Show("Gost je uspješno prijavljen", "Uspješna prijava", MessageBoxButtons.OK,MessageBoxIcon.Information);

                UcitajMoguceOdabire();
                ResetirajFormu();
                
                if(this.azurirajPrijavu != null)
                {
                    this.Close();
                }
            }
            catch(KampiralisteException ex)
            {
                MessageBox.Show(ex.PorukaIznimke, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Iz objekta tipa klase "prijava" učitava podatke u formu.
        /// </summary>
        private void UcitajPrijavu()
        {
            kontekst.prijavas.Attach(this.azurirajPrijavu);

            if(this.azurirajPrijavu.gost1.spol == "M")
            {
                unosSpolMuski.Checked = true;
            }
            else
            {
                unosSpolZenski.Checked = true;
            }
            unosIme.Text = this.azurirajPrijavu.gost1.ime;
            unosPrezime.Text = this.azurirajPrijavu.gost1.prezime;
            unosVrstaDoc.SelectedIndex = unosVrstaDoc.FindStringExact(this.azurirajPrijavu.gost1.vrsta_dokumenta.naziv);
            unosBrojDoc.Text = this.azurirajPrijavu.gost1.broj_dokumenta;
            unosDrzavaStan.SelectedIndex = unosDrzavaStan.FindStringExact(this.azurirajPrijavu.gost1.drzava.naziv);
            unosDrzavaRod.SelectedIndex = unosDrzavaRod.FindStringExact(this.azurirajPrijavu.gost1.drzava1.naziv);
            unosDatumRodenja.Text = this.azurirajPrijavu.gost1.datum_rodenja.ToString("yyyy-MM-dd");
            unosStatusOsobe.SelectedIndex = unosStatusOsobe.FindStringExact(this.azurirajPrijavu.status_osobe.naziv);
            if (this.azurirajPrijavu.organizacija_dolaska == "O")
            {
                unosOsobno.Checked = true;
            }
            else
            {
                unosAgencijski.Checked = true;
            }
            odabirSmjestajaUnos.SelectedIndex = odabirSmjestajaUnos.FindStringExact(this.azurirajPrijavu.smjestaj.oznaka);
            unosDatumDolaska.Text = this.azurirajPrijavu.datum_prijave.ToString("yyyy-MM-dd");
            unosDatumOdlaska.Text = this.azurirajPrijavu.datum_odjave.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// Prilikom promjene indeksa (odabira statusa) provjerava se odgovara li status godinama osobe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unosStatusOsobe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ProvjeraStatusa();
            }
            catch (KampiralisteException ex)
            {
                MessageBox.Show(ex.PorukaIznimke, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Prilikom zatvaranja forme dispose-a kontekst za pristup bazi podataka.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrijavaGostaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.azurirajPrijavu == null)
                kontekst.Dispose();
        }

        private void UsporedbaDatumDolaskaOdlaska()
        {
            DateTime datumDolaska, datumOdlaska;

            if (DateTime.TryParse(unosDatumDolaska.Text, out datumDolaska) && DateTime.TryParse(unosDatumOdlaska.Text, out datumOdlaska))
            {
                if (datumDolaska > datumOdlaska)
                {
                    throw new KampiralisteException("Datum dolaska ne može biti nakon datum odlaska!", this.Name);
                }
            }
            else
            {
                throw new KampiralisteException("Datum u neispravnom formatu!", this.Name);
            }
        }    


        /// <summary>
        /// Pokreće PretvornikDatumDLL i vraća ispravni format datuma
        /// </summary>
        /// <param name="ulazniNiz">Podaci dobalvjeni s ulaza</param>
        /// <returns>Formatirani datum spreman za rad</returns>
        private string PretvorbaUnosaDatum(string ulazniNiz)
        {
            string izlazniNiz = "";
            try
            {
                izlazniNiz = PretvornikDatum.PretvoriDatum(ulazniNiz);
                if (izlazniNiz == "greska")
                {
                    throw new KampiralisteException("Datum rođenja je u neispravnom formatu!", this.Name);
                }
            }
            catch (KampiralisteException ex)
            {
                MessageBox.Show(ex.PorukaIznimke, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return izlazniNiz;
        }

        private void unosDatumRodenja_Leave(object sender, EventArgs e)
        {
            string ulazniNiz = unosDatumRodenja.Text;
            unosDatumRodenja.Text = PretvorbaUnosaDatum(ulazniNiz);
        }


        private void unosDatumDolaska_Leave(object sender, EventArgs e)
        {
            string ulazniNiz = unosDatumDolaska.Text;
            unosDatumDolaska.Text = PretvorbaUnosaDatum(ulazniNiz);
        }

        private void unosDatumOdlaska_Leave(object sender, EventArgs e)
        {
            string ulazniNiz = unosDatumOdlaska.Text;
            unosDatumOdlaska.Text = PretvorbaUnosaDatum(ulazniNiz);
        }

        private void UputeUnosDatuma(Control mjestoPrikaza)
        {
            ToolTip pomocDatum = new ToolTip();
            pomocDatum.AutomaticDelay = 0;
            pomocDatum.AutoPopDelay = 20000;
            string poruka = "Unos datuma na formi sadrži automatsko formatiranje datuma.\r\n";
            if (mjestoPrikaza.Name == "helpDatumRodenja")
                poruka += "Formati unosa: d.m.yy, dd.mm.yy, dd.mm.yyyy, d.m.y \r\n";
            else
                poruka += "Formati unosa: d.m, dd.mm, ddmm\r\n";
            poruka += "Brojevi moraju biti odvojeni zarezom (,) ili točkom (.)";
            pomocDatum.SetToolTip(mjestoPrikaza, poruka);
        }

        private void helpDatumRodenja_MouseHover(object sender, EventArgs e)
        {
            UputeUnosDatuma(sender as Control);
        }

        private void helpDatumDolaska_MouseHover(object sender, EventArgs e)
        {
            UputeUnosDatuma(sender as Control);
        }
    }
}
