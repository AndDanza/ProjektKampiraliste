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
    public partial class StorniranjeRacunaForma : Form
    {
        private smjestaj odabraniSmjestaj = null;
        public StorniranjeRacunaForma()
        {
            InitializeComponent();
        }
        private void PrikaziRacune()
        {
            BindingList<racun> listaRacuna = null;
            using (var baza = new KampiralisteEntiteti())
            {
                listaRacuna = new BindingList<racun>(baza.racuns.ToList());
            }
            racunBindingSource.DataSource = listaRacuna;
        }

        private void StorniranjeRacunaForma_Load(object sender, EventArgs e)
        {
            PrikaziRacune();
        }

        private void akcijaStornirajRacun_Click(object sender, EventArgs e)
        {
            BindingList<prijava> listaPrijava = new BindingList<prijava>();
            racun odabraniRacun = racunBindingSource.Current as racun;
            if (odabraniRacun != null)
            {
                if (MessageBox.Show("Sigurno želite stornirati odabrani račun?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (var baza = new KampiralisteEntiteti())
                    {
                        baza.racuns.Attach(odabraniRacun);

                        var upit = from prijava in baza.prijavas
                                   where prijava.racun.id == odabraniRacun.id
                                   select prijava;

                        listaPrijava = new BindingList<prijava>(upit.ToList());

                        foreach (var item in listaPrijava)
                        {
                            item.racun_id = null;
                        }
                        odabraniSmjestaj = odabraniRacun.smjestaj as smjestaj;
                        ZauzmiParcelu();

                        baza.racuns.Remove(odabraniRacun);
                        baza.SaveChanges();
                    }
                }
            }
            else {
                MessageBox.Show("Potrebno je odabrati račun koji se želi stornirati!");
            }
            PrikaziRacune();
        }

        private void ZauzmiParcelu()
        {
            using (KampiralisteEntiteti kontekst = new KampiralisteEntiteti())
            {
                odabraniSmjestaj.parcela.slobodno = false;

                kontekst.SaveChanges();
            }
        }
    }
}
