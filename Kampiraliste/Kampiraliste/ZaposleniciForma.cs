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
    public partial class ZaposleniciForma : Form
    {
        List<zaposlenik> popis;
        public ZaposleniciForma()
        {
            InitializeComponent();
            //popis = new List<zaposlenik>();

            /*BindingList<zaposlenik> listaZaposlenika;
            using (var ef = new KampiralisteEntiteti())
            {
                listaZaposlenika = new BindingList<zaposlenik>(ef.zaposleniks.ToList());
            }
            zaposlenikDataBinding.DataSource = listaZaposlenika;
            */

            using (var ef = new KampiralisteEntiteti())
            {
                popis = new List<zaposlenik>(ef.zaposleniks.ToList());
            }
            zaposlenikBindingSource.DataSource = popis;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            zaposlenik za = zaposlenikBindingSource.Current as zaposlenik;
            textBoxTest.Text = za.ime;
   
            AzurirajZaposlenikaForma azuriraj = new AzurirajZaposlenikaForma(zaposlenikBindingSource.Current as zaposlenik);
            azuriraj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var ef = new KampiralisteEntiteti())
            {
                zaposlenik za = zaposlenikBindingSource.Current as zaposlenik;
                ef.zaposleniks.Attach(za);
                ef.zaposleniks.Remove(za);
              
                ef.SaveChanges();
            }
           

        }
    }
}
