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

        BindingList<prijava> listaPrijava=null;
        public IzdavanjeRacunaForma()
        {
            InitializeComponent();
        }

        
        private void PrikaziParcele()
        {
            BindingList<parcela> listaParcela = null;
            using (var baza = new KampiralisteEntiteti())
            {
                listaParcela = new BindingList<parcela>(baza.parcelas.Where(p=>p.slobodno==false).ToList());
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

                    smjestaj dohvaceniSmjestaj = odabranaParcela.smjestajs.LastOrDefault() as smjestaj;

                    ispisOznakeSmjestaja.Text = dohvaceniSmjestaj.oznaka;

                    var upit = from prijava in kontekst.prijavas
                               where prijava.smjestaj.id == dohvaceniSmjestaj.id
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
            }
        }

        private void ispisOdabraniGosti_DoubleClick(object sender, EventArgs e)
        {
            if (ispisOdabraniGosti.SelectedItem != null)
            {
                ispisSviGosti.Items.Add(ispisOdabraniGosti.SelectedItem);
                ispisOdabraniGosti.Items.Remove(ispisOdabraniGosti.SelectedItem);
            }
        }
    }
}