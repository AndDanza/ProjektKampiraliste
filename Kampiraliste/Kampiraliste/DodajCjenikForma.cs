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
    public partial class DodajCjenikForma : Form
    {
        public DodajCjenikForma()
        {
            InitializeComponent();
        }

        private void dodajNoviCjenik_Click(object sender, EventArgs e)
        {
            DialogResult rezultatUpita = MessageBox.Show("Jeste li sigurni da želite dodati novi cjenik?", "Dodavanje cjenika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rezultatUpita == DialogResult.Yes)
            {
                using (var ef = new KampiralisteEntiteti())
                {
                    vrsta_smjestaja vrsta = new vrsta_smjestaja
                    {
                        naziv = unosNaziv.Text,
                        iznos = decimal.Parse(unosCijena.Text)
                    };

                    ef.vrsta_smjestaja.Add(vrsta);
                    ef.SaveChanges();
                    this.Close();

                }
            }
        }
    }
}
