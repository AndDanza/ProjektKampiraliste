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
    public partial class RadSPrijavamaForma : Form
    {
        private BindingList<prijava> listaPrijava = null;
        private gost gostSelect = null;

        public RadSPrijavamaForma()
        {
            InitializeComponent();
        }

        private void UcitajPrijave()
        {
            using (var baza = new KampiralisteEntiteti())
            {

                this.listaPrijava = new BindingList<prijava>(baza.prijavas.ToList());
                foreach (var item in listaPrijava)
                {
                    listBox1.Items.Add((prijava)item);
                }
            }
            gostSelect = new gost();
            //listBox1.DisplayMember = "datum_prijave";
            // prijavaBindingSource.DataSource = listaPrijava;

            
        }



        private void RadSPrijavamaForma_Load(object sender, EventArgs e)
        {
            UcitajPrijave();
        }
    }
}
