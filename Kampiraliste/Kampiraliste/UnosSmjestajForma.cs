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
        BindingList<vrsta_smjestaja> listaSmjestaja = null;
        BindingList<parcela> listaParcela = null;

        public UnosSmjestajForma()
        {
            InitializeComponent();
        }

        private void UnosSmjestajForma_Load(object sender, EventArgs e)
        {
            using (var baza = new KampiralisteEntiteti())
            {
                listaSmjestaja = new BindingList<vrsta_smjestaja>(baza.vrsta_smjestaja.ToList());
                //LINQ - dohvati parcele koje su slobodne
                listaParcela = new BindingList<parcela>(baza.parcelas.Where(s => s.slobodno == true).ToList());
            }

            unosVrstaSmjestaja.DataSource = listaSmjestaja;
            unosParcele.DataSource = listaParcela;
        }

        private void potvrdiUnosSmjestaja_Click(object sender, EventArgs e)
        {
            try
            {
                int brojOsoba = 0;

                if(int.TryParse(unosBrojOsoba.Text, out brojOsoba))
                {
                    vrsta_smjestaja smjestaj = unosVrstaSmjestaja.SelectedItem as vrsta_smjestaja;
                    parcela parcelaSmjestaja = unosParcele.SelectedItem as parcela;

                    using (var baza = new KampiralisteEntiteti())
                    {
                        baza.vrsta_smjestaja.Attach(smjestaj);
                        baza.parcelas.Attach(parcelaSmjestaja);

                        smjestaj noviSmjestaj = new smjestaj
                        {
                            vrsta_smjestaja = smjestaj,
                            parcela = parcelaSmjestaja,
                            broj_osoba = brojOsoba
                        };

                        baza.smjestajs.Add(noviSmjestaj);
                        baza.SaveChanges();

                        DialogResult rez = MessageBox.Show("Smještaj unesen");

                        if (rez == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                DialogResult kriviUnos = MessageBox.Show("Unesena vrijednost za broj gostiju nije valjana!");
                unosBrojOsoba.Clear();
            }
        }
    }
}
