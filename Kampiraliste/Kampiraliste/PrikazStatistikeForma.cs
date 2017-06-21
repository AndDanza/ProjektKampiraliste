using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kampiraliste
{
    public partial class PrikazStatistikeForma : Form
    {
        //private BindingList<drzava> listaDrzava = null;
        public PrikazStatistikeForma()
        {
            InitializeComponent();
        }

        private void akcijaPrikaziStatPoDatumu_Click(object sender, EventArgs e)
        {
            DateTime datumFiltriranja = DateTime.Parse(unosDatumFiltiranja.Text);
            int brojOsobaHrv = 0;
            int brojOsobaStr = 0;
            using (var baza = new KampiralisteEntiteti()){
                brojOsobaHrv = (from prijave in baza.prijavas
                             where prijave.datum_prijave <= datumFiltriranja &&
                             prijave.datum_odjave >= datumFiltriranja &&
                             prijave.gost1.drzava_id_drzavljanstvo == "HRV"
                             select prijave).Count();
                

            brojOsobaStr = (from prijave in baza.prijavas
                            where prijave.datum_prijave <= datumFiltriranja &&
                            prijave.datum_odjave >= datumFiltriranja &&
                            prijave.gost1.drzava_id_drzavljanstvo != "HRV"
                            select prijave).Count();
            }

            foreach (var series in ispisStatDatumGraf.Series){
                  series.Points.Clear();
                }


            if (brojOsobaHrv != 0 || brojOsobaStr != 0)
            {
                  this.ispisStatDatumGraf.Series["prikazBrojGostiju"].Points.AddXY("Domaći gosti", brojOsobaHrv);
                  this.ispisStatDatumGraf.Series["prikazBrojGostiju"].Points.AddXY("Strani gosti", brojOsobaStr);
            }
            else{
                  MessageBox.Show("Na uneseni datum niste imali gostiju u kampiralištu!");
            }
        }

        private void PrikazStatistikeForma_Load(object sender, EventArgs e)
        {
            List<int> listaBrojeva = new List<int>();
            using (var baza = new KampiralisteEntiteti())
            {
                for (int i = 1; i <= baza.parcelas.Count(); i++)
                {
                    int brojOsoba = (from prijave in baza.prijavas
                                     where prijave.smjestaj.parcela.id == i
                                     && prijave.datum_prijave.Year == DateTime.Now.Year
                                     select prijave).Count();

                    listaBrojeva.Add(brojOsoba);
                }
                int brPomocni = 0;
                for (int i = 1; i < listaBrojeva.Count; i++)
                {
                    if (listaBrojeva.IndexOf(i) == -1)
                    {
                        brPomocni = 0;
                    }
                    else
                    {
                        brPomocni = listaBrojeva.IndexOf(i);
                    }
                    this.ispisStatParceleGraf.Series["prikazPoParceli"].Points.AddXY("Parcela_"+i, brPomocni);
                }
            }
        }
    }
}
