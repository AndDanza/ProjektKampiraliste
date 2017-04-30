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
    public partial class VoditeljForma : Form
    {
        KampiralisteEntiteti ef;
        public VoditeljForma()
        {
            ef = new KampiralisteEntiteti();
            InitializeComponent();
        }

        private void otvorPopisZaposlenikaAkcija_Click(object sender, EventArgs e)
        {
            ZaposleniciForma formaUredi = new ZaposleniciForma();
            formaUredi.ShowDialog();
        }

        private void otvoriPopisCjenikaAkcija_Click(object sender, EventArgs e)
        {
            CjenikForma formaUredi = new CjenikForma();
            formaUredi.ShowDialog();
        }

        private void otvoriPrijavuGostaAction_Click(object sender, EventArgs e)
        {
            PrijavaGostaForma urediFormu = new PrijavaGostaForma();
            urediFormu.ShowDialog();
        }
    }
}
