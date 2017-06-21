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
    public partial class CjenikForma : Form
    {
        private BindingList<vrsta_smjestaja> cjenik;
        public CjenikForma()
        {
            InitializeComponent();

            UcitajCjenik();
        
        }

        private void UcitajCjenik()
        {
            
            using (var ef = new KampiralisteEntiteti())
            {
                cjenik = new BindingList<vrsta_smjestaja>(ef.vrsta_smjestaja.ToList());
            }
            cjenikBindingSource.DataSource = cjenik;
        }

        private void obrisiCjenik_Click(object sender, EventArgs e)
        {
            DialogResult rezultatUpita = MessageBox.Show("Jeste li sigurni da želite obrisati cjenik?", "Brisanje cjenika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if (rezultatUpita == DialogResult.Yes)
                {
                    using (var ef = new KampiralisteEntiteti())
                    {
                        vrsta_smjestaja vrsta = cjenikBindingSource.CurrentRow.DataBoundItem as vrsta_smjestaja;
                        ef.vrsta_smjestaja.Attach(vrsta);
                        ef.vrsta_smjestaja.Remove(vrsta);
                        ef.SaveChanges();
                        UcitajCjenik();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ne možete obrisati cjenik koji se koristi", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void dodajNoviCjenik_Click(object sender, EventArgs e)
        {
            DodajCjenikForma dodajNovi = new DodajCjenikForma();
            dodajNovi.ShowDialog();
            UcitajCjenik();
        }

        private void azurirajCjenik_Click(object sender, EventArgs e)
        {
            vrsta_smjestaja vs = cjenikBindingSource.CurrentRow.DataBoundItem as vrsta_smjestaja;
            AzurirajCjenikForma azuriraj = new AzurirajCjenikForma(vs);
            azuriraj.ShowDialog();
            UcitajCjenik();
        }
    }
}
