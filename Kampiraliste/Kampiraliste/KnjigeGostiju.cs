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
    public partial class KnjigeGostiju : Form
    {
        KampiralisteEntiteti kontekst = null;
        public KnjigeGostiju(KampiralisteEntiteti ulazniKontekst)
        {
            InitializeComponent();
            this.kontekst = ulazniKontekst;
    }

        private void KnjigeGostiju_Load(object sender, EventArgs e)
        {
            this.prijavaBindingSource.DataSource = kontekst.prijavas.ToList();

            this.reportViewer1.RefreshReport();
        }
    }
}
