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
        public IzdavanjeRacunaForma()
        {
            InitializeComponent();
        }

        private void PrikaziParcele()
        {
            BindingList<parcela> listaParcela = null;
            using (var baza = new KampiralisteEntiteti())
            {
                listaParcela = new BindingList<parcela>(baza.parcelas.ToList());
            }
            parcelaBindingSource.DataSource = listaParcela;
        }

        private void IzdavanjeRacunaForma_Load(object sender, EventArgs e)
        {
            PrikaziParcele();
        }
    }
}
