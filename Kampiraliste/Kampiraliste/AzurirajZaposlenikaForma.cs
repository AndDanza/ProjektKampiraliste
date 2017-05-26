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
    public partial class AzurirajZaposlenikaForma : Form
    {
        zaposlenik zaposlenikZaIzmjenu;
   
        public AzurirajZaposlenikaForma()
        {
            InitializeComponent();
        }

        public AzurirajZaposlenikaForma(zaposlenik za)
        {
            
            InitializeComponent();
            if(za != null)
            {
                textBox1.Text = za.id.ToString();
                zaposlenikZaIzmjenu = za;
            }
                

            if (za == null)
                textBox1.Text = "null";

            textBoxIme.Text = za.ime;
            textBoxPrezime.Text = za.prezime;
            textBoxKorIme.Text = za.korisnicko_ime;
            textBoxVrsta.Text = za.vrsta_zaposlenika.ToString();
            textBoxLozinka.Text = za.lozinka;

            using (var ef = new KampiralisteEntiteti())
            {
                comboBox1.DataSource = ef.zaposleniks.ToList();
                comboBox1.DisplayMember = "ime";
                comboBox1.ValueMember = "id";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ef = new KampiralisteEntiteti())
            {
                comboBox1.DataSource = ef.zaposleniks.ToList();
                comboBox1.DisplayMember = "ime";
                comboBox1.ValueMember = "id";
            }

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null )
            {
                textBox2.Text = comboBox1.SelectedValue.ToString();
            }
            
        }
    }
}
