using Microsoft.Reporting.WinForms;
using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Kampiraliste
{
    public partial class KnjigaGostijuForma : Form
    {
        private bool straniGost;
        public KnjigaGostijuForma(bool vrsta)
        {
            InitializeComponent(vrsta);
            this.straniGost = vrsta;
        }
        
        private void UcitajStraneGoste()
        {
            // TODO: This line of code loads data into the 'kampiralisteDataSet.KnjigaStranihGostiju' table. You can move, or remove it, as needed.
            this.KnjigaStranihGostijuTableAdapter.Fill(this.kampiralisteDataSet.KnjigaStranihGostiju);

            this.pregledKnjigeGostiju.RefreshReport();
        }

        private void UcitajDomaceGoste()
        {
            // TODO: This line of code loads data into the 'kampiralisteDataSet.KnjigaDomacihGostiju' table. You can move, or remove it, as needed.
            this.KnjigaDomacihGostijuTableAdapter.Fill(this.kampiralisteDataSet.KnjigaDomacihGostiju);

            this.pregledKnjigeGostiju.RefreshReport();
        }
   
        private void KnjigaGostijuForma_Load(object sender, EventArgs e)
        {
            PageSettings ps = new PageSettings();
            ps.Landscape = true;
            ps.PaperSize = new PaperSize("A4", 827, 1170);
            ps.PaperSize.RawKind = (int)PaperKind.A4;
            pregledKnjigeGostiju.SetPageSettings(ps);

            if (!this.straniGost)
            {
                UcitajDomaceGoste();
            }
            else
            {
                UcitajStraneGoste();
            }

            this.pregledKnjigeGostiju.RefreshReport();
        }
    }
}