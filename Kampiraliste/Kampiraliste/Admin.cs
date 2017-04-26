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
    public partial class Admin : Form
    {
        KampiralisteEntiteti ef;
        public Admin()
        {
            ef = new KampiralisteEntiteti();
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
        private void UcitajZaposlenike(object sender, EventArgs e)
        {
            zaposleniciLista.Items.Clear();
            foreach (var zaposlenik in ef.zaposleniks)
            {
                string noviRed = zaposlenik.ime + " " + zaposlenik.prezime;
                zaposleniciLista.Items.Add(noviRed);


                tablicaZaposlenika.RowCount = tablicaZaposlenika.RowCount + 1;
                tablicaZaposlenika.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                tablicaZaposlenika.Controls.Add(new Label() { Text = zaposlenik.ime }, 1, tablicaZaposlenika.RowCount - 1);
                tablicaZaposlenika.Controls.Add(new Label() { Text = zaposlenik.prezime }, 2, tablicaZaposlenika.RowCount - 1);
                tablicaZaposlenika.Controls.Add(new Label() { Text = zaposlenik.korisnicko_ime }, 3, tablicaZaposlenika.RowCount - 1);
                tablicaZaposlenika.Controls.Add(new Label() { Text = zaposlenik.lozinka }, 4, tablicaZaposlenika.RowCount - 1);
                tablicaZaposlenika.Controls.Add(new Label() { Text = zaposlenik.tip.ToString() }, 5, tablicaZaposlenika.RowCount - 1);

            }
        }

        private void tablicaZaposlenika_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
