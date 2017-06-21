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
    public partial class AzurirajCjenikForma : Form
    {
        vrsta_smjestaja vrstaSmjestajaZaIzmjenu;
        public AzurirajCjenikForma()
        {
            InitializeComponent();
        }

        public AzurirajCjenikForma(vrsta_smjestaja vrsta)
        {

            InitializeComponent();
            if (vrsta != null)
            {
                vrstaSmjestajaZaIzmjenu = vrsta;
                unosNaziv.Text = vrsta.naziv;
                unosCijena.Text = vrsta.iznos.ToString();
            }
        }

        private void spremiPromjene_Click(object sender, EventArgs e)
        {
            DialogResult rezultatUpita = MessageBox.Show("Jeste li sigurni da želite ažurirati cjenik?", "Ažuriranje cjenika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rezultatUpita == DialogResult.Yes)
            {
                using (var ef = new KampiralisteEntiteti())
                {

                    ef.vrsta_smjestaja.Attach(vrstaSmjestajaZaIzmjenu);
                    vrstaSmjestajaZaIzmjenu.naziv = unosNaziv.Text;
                    vrstaSmjestajaZaIzmjenu.iznos = decimal.Parse(unosCijena.Text);
                    ef.SaveChanges();
                    this.Close();
                }
            }
        }

     
    }
}
