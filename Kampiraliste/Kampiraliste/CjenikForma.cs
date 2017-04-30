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
        public CjenikForma()
        {
            InitializeComponent();
            BindingList<zaposlenik> listaZaposlenika;
            using (var ef = new KampiralisteEntiteti())
            {
                listaZaposlenika = new BindingList<zaposlenik>(ef.zaposleniks.ToList());
            }
            cjenikBindingSource.DataSource = listaZaposlenika;
        }
    }
}
