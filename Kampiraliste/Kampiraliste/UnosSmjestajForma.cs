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
    public partial class UnosSmjestajForma : Form
    {
        KampiralisteEntiteti kontekst = null;
        private BindingList<vrsta_smjestaja> listaSmjestaja = null;
        private BindingList<parcela> listaParcela = null;

        public UnosSmjestajForma(KampiralisteEntiteti prosljedeniKontekst)
        {
            InitializeComponent();
            this.kontekst = prosljedeniKontekst;
        }

        /// <summary>
        /// Ucitavanje combobox-eva za odabir vrste smještaja i parcele na kojoj će se smještaj nalaziti.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnosSmjestajForma_Load(object sender, EventArgs e)
        {
            listaSmjestaja = new BindingList<vrsta_smjestaja>(this.kontekst.vrsta_smjestaja.ToList());
            listaParcela = new BindingList<parcela>(this.kontekst.parcelas.Where(s => s.slobodno == true).ToList());

            unosVrstaSmjestaja.DataSource = listaSmjestaja;
            unosParcele.DataSource = listaParcela;
        }

        /// <summary>
        /// Pohrana smještaja u bazu podataka.
        /// </summary>
        /// <param name="brojOsoba"></param>
        private void PohraniSmjestaj(int brojOsoba)
        {
            vrsta_smjestaja smjestaj = unosVrstaSmjestaja.SelectedItem as vrsta_smjestaja;
            parcela parcelaSmjestaja = unosParcele.SelectedItem as parcela;

            smjestaj noviSmjestaj = new smjestaj
            {
                vrsta_smjestaja = smjestaj,
                parcela = parcelaSmjestaja,
                broj_osoba = brojOsoba
            };

            parcelaSmjestaja.slobodno = false;

            this.kontekst.smjestajs.Add(noviSmjestaj);
            this.kontekst.SaveChanges();
        }

        private void potvrdiUnosSmjestaja_Click(object sender, EventArgs e)
        {
            int brojOsoba = 0;

            try
            {
                if (int.TryParse(unosBrojOsoba.Text, out brojOsoba))
                {
                    if(brojOsoba < 30)
                    {
                        PohraniSmjestaj(brojOsoba);

                        DialogResult rez = MessageBox.Show("Smještaj unesen");

                        if (rez == DialogResult.OK)
                        {
                            if (unosBrojOsoba.BackColor == Color.LightSalmon)
                            {
                                unosBrojOsoba.BackColor = Color.Empty;
                            }
                            this.Close();
                        }
                    }
                    else
                    {
                        unosBrojOsoba.BackColor = Color.LightSalmon;
                        throw new KampiralisteException("Broj gostiju za smještaj je prevelik!", this.Name);
                    }
                }
                else
                {
                    unosBrojOsoba.BackColor = Color.LightSalmon;
                    throw new KampiralisteException("Neispravno unesen broj gostiju!", this.Name);
                }
            }
            catch (KampiralisteException ex)
            {
                MessageBox.Show(ex.PorukaIznimke, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
