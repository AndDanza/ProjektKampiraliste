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
    public partial class IzdavanjeRacunaForma : Form
    {
        private smjestaj odabraniSmjestaj = null;
        private static Random random = new Random();
        zaposlenik prijavljeniZaposlenik = null;
        BindingList<prijava> listaPrijava = null;

        public IzdavanjeRacunaForma(zaposlenik prijavljeni)
        {
            InitializeComponent();
            prijavljeniZaposlenik = prijavljeni;
        }

        //ispis svih zauzetih parcela
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

        //odabrana parcela -> prikaz prijavljenih gostiju u zadnjem smještaju
        private void odabirParcele_SelectedIndexChanged(object sender, EventArgs e)
        {
            ispisSviGosti.Items.Clear();
            ispisOdabraniGosti.Items.Clear();
            parcela odabranaParcela = odabirParcele.SelectedItem as parcela;

            using (KampiralisteEntiteti kontekst = new KampiralisteEntiteti())
            {
                if (odabranaParcela != null)
                {
                    ispisRacuna.Clear();
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

        //ispis -> svi gosti sa odabrane parcele
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

        //ispis -> odabrani gosti za koje se želi izdati račun
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

        //poziv funkcije za kreiranje računa, osvjezavanje parcela, prikaza iznosa i gostiju
        private void akcijaKreirajRacun_Click(object sender, EventArgs e)
        {
            if (ispisOdabraniGosti.Items.Count > 0)
            {
                racun kreiraniRacun=KreirajRacun();
                KreirajStavke(kreiraniRacun);
                MessageBox.Show("Račun je kreiran!");
                ispisOdabraniGosti.Items.Clear();
                ispisRacuna.Text = null;
                PrikaziParcele();
            }

            else {
                MessageBox.Show("Niste odabrali goste za koje želite izdati račun!");
            }
        }
        
        //kreiranje računa
        private racun KreirajRacun()
        {
            racun noviRacun = null;
            using (KampiralisteEntiteti kontekst = new KampiralisteEntiteti())
            {
                kontekst.smjestajs.Attach(odabraniSmjestaj);

                noviRacun = new racun()
                {
                    smjestaj = odabraniSmjestaj as smjestaj,
                    smjestaj_id = odabraniSmjestaj.id,
                    zaposlenik_id = prijavljeniZaposlenik.id,
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

        //random string za JIR i ZIR na racunu
        public static string RandomString()
        {
            const string znakovi = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(znakovi, 20)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //detalji racuna -> dohvacanje ukupnog iznosa i ispis te oslobađanje parcele
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


        //ako nema gostiju na parceli, oslobodi parcelu u suprotnom je i dalje zauzeta
        private void OslobodiParcelu(int brojOsoba)
        {
            using (KampiralisteEntiteti kontekst = new KampiralisteEntiteti()) {
                kontekst.smjestajs.Attach(odabraniSmjestaj);
                odabraniSmjestaj.broj_osoba = brojOsoba;
                if (ispisSviGosti.Items.Count>0)
                {
                    odabraniSmjestaj.parcela.slobodno = false;
                }
                else
                {
                    odabraniSmjestaj.parcela.slobodno = true;
                }
                

                kontekst.SaveChanges();
            }
        }

        //racun -> izracun ukupnog iznosa prema statusu osobe, broju dana, vrsti smjestaja i broju osoba
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
