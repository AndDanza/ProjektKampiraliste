using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kampiraliste
{
    class KampiralisteException : ApplicationException
    {
        public string PorukaIznimke;
        private string IzvorIznimke;

        public KampiralisteException(string poruka, string izvor)
        {
            this.PorukaIznimke = poruka;
            this.IzvorIznimke = izvor;
        }
    }
}
