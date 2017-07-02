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
    public partial class IzdavanjeRacunaForma : Form
    {
        private smjestaj odabraniSmjestaj = null;
        private static Random random = new Random();
        zaposlenik prijavljeniZaposlenik = null;
        BindingList<prijava> listaPrijava = null;

        public IzdavanjeRacunaForma(zaposlenik prijavljeni)
        {
            InitializeComponent();
            this.prijavljeniZaposlenik = prijavljeni;
        }


        private void PrikaziParcele()
        {
            BindingList<parcela> listaParcela = null;
            using (var baza = new KampiralisteEntiteti())
            {
                listaParcela = new BindingList<parcela>(baza.parcelas.Where(p => p.slobodno == false).ToList());
            }
            parcelaBindingSource.DataSource = listaParcela;
        }

        private void IzdavanjeRacunaForma_Load(object sender, EventArgs e)
        {
            PrikaziParcele();
        }

        private void odabirParcele_SelectedIndexChanged(object sender, EventArgs e)
        {
            ispisSviGosti.Items.Clear();
            ispisOdabraniGosti.Items.Clear();
            parcela odabranaParcela = odabirParcele.SelectedItem as parcela;

            using (KampiralisteEntiteti kontekst = new KampiralisteEntiteti())
            {
                if (odabranaParcela != null)
                {
                    kontekst.parcelas.Attach(odabranaParcela);

                    odabraniSmjestaj = odabranaParcela.smjestajs.LastOrDefault() as smjestaj;

                    ispisOznakeSmjestaja.Text = odabraniSmjestaj.oznaka;

                    var upit = from prijava in kontekst.prijavas
                               where prijava.smjestaj.id == odabraniSmjestaj.id && prijava.racun==null
                               select prijava;
                    this.listaPrijava = new BindingList<prijava>(upit.ToList());

                    foreach (var item in listaPrijava)
                    {
                        ispisSviGosti.Items.Add(item as prijava);
                    }
                }
            }

        }

        private void ispisSviGosti_DoubleClick(object sender, EventArgs e)
        {
            if (ispisSviGosti.SelectedItem != null)
            {
                ispisOdabraniGosti.Items.Add(ispisSviGosti.SelectedItem);
                ispisSviGosti.Items.Remove(ispisSviGosti.SelectedItem);
                using (var kontekst = new KampiralisteEntiteti()) {
                    decimal ukupniIznos = UkupniIznosRacuna(null,kontekst);
                    ispisRacuna.Text = Convert.ToString(ukupniIznos) + " kn";
                }
            }
        }

        private void ispisOdabraniGosti_DoubleClick(object sender, EventArgs e)
        {
            if (ispisOdabraniGosti.SelectedItem != null)
            {
                ispisSviGosti.Items.Add(ispisOdabraniGosti.SelectedItem);
                ispisOdabraniGosti.Items.Remove(ispisOdabraniGosti.SelectedItem);
                using (var kontekst = new KampiralisteEntiteti())
                {
                    decimal ukupniIznos = UkupniIznosRacuna(null, kontekst);
                    ispisRacuna.Text = Convert.ToString(ukupniIznos) + " kn";
                }
            }
        }

        private void akcijaKreirajRacun_Click(object sender, EventArgs e)
        {
            if (ispisOdabraniGosti.Items.Count > 0)
            {
                racun kreiraniRacun=KreirajRacun();
                KreirajStavke(kreiraniRacun);
                MessageBox.Show("Račun je kreiran!");
            }

            else {
                MessageBox.Show("Niste odabrali goste za koje želite izdati račun!");
            }
        }

        private racun KreirajRacun()
        {
            racun noviRacun = null;
            using (KampiralisteEntiteti kontekst = new KampiralisteEntiteti())
            {
                kontekst.smjestajs.Attach(odabraniSmjestaj);
                kontekst.zaposleniks.Attach(this.prijavljeniZaposlenik);

                noviRacun = new racun()
                {
                    smjestaj = odabraniSmjestaj as smjestaj,
                    smjestaj_id = odabraniSmjestaj.id,
                    zaposlenik = this.prijavljeniZaposlenik,
                    JIR = RandomString(),
                    ZIR = RandomString(),
                    iznos = 0,
                    datum_vrijeme_izdavanja = DateTime.Now
                };
                kontekst.racuns.Add(noviRacun);
                kontekst.SaveChanges();
            }
            return noviRacun;
        }


        public static string RandomString()
        {
            const string znakovi = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(znakovi, 20)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        public void KreirajStavke(racun kreiraniRacun)
        {
            decimal ukupniIznos = 0;
            int brOsobaUSmjestaju = 0;

            using (KampiralisteEntiteti kontekst = new KampiralisteEntiteti())
            {
                kontekst.smjestajs.Attach(odabraniSmjestaj);
                brOsobaUSmjestaju = odabraniSmjestaj.prijavas.Count;
                ukupniIznos +=UkupniIznosRacuna(kreiraniRacun,kontekst);
                ispisRacuna.Text = Convert.ToString(ukupniIznos)+" kn";
                kreiraniRacun.iznos = ukupniIznos;
                kontekst.SaveChanges();
            }
            OslobodiParcelu(brOsobaUSmjestaju);
        }



        private void OslobodiParcelu(int brojOsoba)
        {
            using (KampiralisteEntiteti kontekst = new KampiralisteEntiteti()) {
                kontekst.smjestajs.Attach(odabraniSmjestaj);
                odabraniSmjestaj.broj_osoba = brojOsoba;
                odabraniSmjestaj.parcela.slobodno = true;

                kontekst.SaveChanges();
            }
        }

        private decimal UkupniIznosRacuna(racun kreiraniRacun, KampiralisteEntiteti kontekst)
        {
                decimal ukupniIznos = 0;
                kontekst.smjestajs.Attach(odabraniSmjestaj);
                List<prijava> listaStavki = ispisOdabraniGosti.Items.Cast<prijava>().ToList();
                int brOsobaUSmjestaju = odabraniSmjestaj.prijavas.Count;
                
                foreach (var item in listaStavki)
                {
                    int razlikaDatuma = (item.datum_odjave - item.datum_prijave).Days;
                    if (kreiraniRacun != null)
                    {
                        item.racun = kreiraniRacun;
                    }
                    ukupniIznos += item.status_osobe.iznos * razlikaDatuma + ((item.smjestaj.vrsta_smjestaja.iznos) / brOsobaUSmjestaju) * razlikaDatuma;
                }
            return ukupniIznos;
        }
    }
}
