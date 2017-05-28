using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;

namespace Kampiraliste
{
    public partial class RadSPrijavamaForma : Form
    {
        private BindingList<prijava> listaPrijava = null;
        KampiralisteEntiteti kontekst = null;

        public RadSPrijavamaForma()
        {
            InitializeComponent();
            kontekst = new KampiralisteEntiteti();
        }

        /// <summary>
        /// Učitavanje svih prijava prema datumu dolaska
        /// </summary>
        /// <param name="sortBy">Određuje stupac prema kojem se sortiraju prijave te je li uzlazno ili silazno</param>
        private void UcitajPrijave(int sortBy)
        {
            aktivnePrijaveListBox.Items.Clear();

            switch (sortBy)
            {
                case 1:
                    this.listaPrijava = new BindingList<prijava>(kontekst.prijavas.OrderBy(s => s.datum_prijave).ToList());
                    break;
                case 2:
                    this.listaPrijava = new BindingList<prijava>(kontekst.prijavas.OrderByDescending(s => s.datum_prijave).ToList());
                    break;
                case 3:
                    this.listaPrijava = new BindingList<prijava>(kontekst.prijavas.OrderByDescending(s => s.datum_odjave).ToList());
                    break;
                case 4:
                    this.listaPrijava = new BindingList<prijava>(kontekst.prijavas.OrderBy(s => s.datum_odjave).ToList());
                    break;
            };

            foreach (var item in listaPrijava)
            {
                aktivnePrijaveListBox.Items.Add((prijava)item);
            }
        }
        
        private void RadSPrijavamaForma_Load(object sender, EventArgs e)
        {
            UcitajPrijave(1);
        }

        /// <summary>
        /// Na dupli klik zčitava se odabrana prijava u formu PrijavaGostaForma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aktivnePrijaveListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            prijava azurirajPrijavu = aktivnePrijaveListBox.SelectedItem as prijava;
            PrijavaGostaForma instancaPrijavaGostaForma = new PrijavaGostaForma(azurirajPrijavu, kontekst);
            instancaPrijavaGostaForma.ShowDialog();

            UcitajPrijave(1);
            unosDolazakUzlazno.Checked = true;
        }

        private void akcijaFiltriraj_Click(object sender, EventArgs e)
        {
            if (unosDolazakUzlazno.Checked)
                UcitajPrijave(1);
            else if (unosDolazakSilazno.Checked)
                UcitajPrijave(2);
            else if (unosOdlazakSilazno.Checked)
                UcitajPrijave(3);
            else
                UcitajPrijave(4);
        }

        private void izradiKnjiguStranihAkcija_Click(object sender, EventArgs e)
        {
            PdfDocument knjigaStranihGostiju = new PdfDocument();
            PdfPage pdfStranica = knjigaStranihGostiju.AddPage();
            pdfStranica.Size = PdfSharp.PageSize.A4;
            pdfStranica.Orientation = PdfSharp.PageOrientation.Landscape;

            XGraphics grafika = XGraphics.FromPdfPage(pdfStranica);

            XPen linija = new XPen(XColor.FromArgb(000, 000, 000), 2.5);
            grafika.DrawLine(linija, 20, 80, 802, 80);
            grafika.DrawLine(linija, 20, 120, 802, 120);

            XTextFormatter format = new XTextFormatter(grafika);

            XFont HeadingFont = new XFont("Times New Roman", 20, XFontStyle.Bold);
            XFont BodyFont = new XFont("Times New Roman", 12);
            XFont BoldBodyFont = new XFont("Times New Roman", 12, XFontStyle.Bold);

            grafika.DrawString("Knjiga stranih gostiju", 
                HeadingFont, XBrushes.Black, new XRect(0, 40, pdfStranica.Width.Point, pdfStranica.Height.Point), XStringFormats.TopCenter);

            format.DrawString("Redni \r\n broj", BoldBodyFont, XBrushes.Black, new XRect(40, 88, pdfStranica.Width.Point, pdfStranica.Height.Point), XStringFormats.TopLeft);
            format.DrawString("Ime", BoldBodyFont, XBrushes.Black, new XRect(110, 95, pdfStranica.Width.Point, pdfStranica.Height.Point), XStringFormats.TopLeft);
            format.DrawString("Prezime", BoldBodyFont, XBrushes.Black, new XRect(180, 95, pdfStranica.Width.Point, pdfStranica.Height.Point), XStringFormats.TopLeft);
            format.DrawString("Datum \r\nrođenja", BoldBodyFont, XBrushes.Black, new XRect(262, 88, pdfStranica.Width.Point, pdfStranica.Height.Point), XStringFormats.TopLeft);
            format.DrawString("Država \r\nrođenja", BoldBodyFont, XBrushes.Black, new XRect(340, 88, pdfStranica.Width.Point, pdfStranica.Height.Point), XStringFormats.TopLeft);

            int noviRed = 140;
            for (int i = 0; i < listaPrijava.Count; i++)
            {
                prijava jednaPrijava = listaPrijava[i];
                string id = jednaPrijava.id.ToString();
                string ime = jednaPrijava.gost1.ime;
                string prezime = jednaPrijava.gost1.prezime;
                string datum = jednaPrijava.gost1.datum_rodenja.ToString("dd-MM-yyyy");
                string drzavaRod = jednaPrijava.gost1.drzava.naziv;

                format.DrawString(id, BodyFont, XBrushes.Black, new XRect(50, noviRed, pdfStranica.Width.Point, pdfStranica.Height.Point), XStringFormats.TopLeft);
                format.DrawString(ime, BodyFont, XBrushes.Black, new XRect(100, noviRed, pdfStranica.Width.Point, pdfStranica.Height.Point), XStringFormats.TopLeft);
                format.DrawString(prezime, BodyFont, XBrushes.Black, new XRect(180, noviRed, pdfStranica.Width.Point, pdfStranica.Height.Point), XStringFormats.TopLeft);
                format.DrawString(datum, BodyFont, XBrushes.Black, new XRect(260, noviRed, pdfStranica.Width.Point, pdfStranica.Height.Point), XStringFormats.TopLeft);
                format.DrawString(drzavaRod, BodyFont, XBrushes.Black, new XRect(340, noviRed, pdfStranica.Width.Point, pdfStranica.Height.Point), XStringFormats.TopLeft);

                noviRed += 40;
            }

            knjigaStranihGostiju.Save("second.pdf");
        }

        private void RadSPrijavamaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            kontekst.Dispose();
        }
    }
}
