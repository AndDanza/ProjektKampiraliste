//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kampiraliste
{
    using System;
    using System.Collections.Generic;
    
    public partial class smjestaj
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public smjestaj()
        {
            this.prijavas = new HashSet<prijava>();
            this.racuns = new HashSet<racun>();
        }
    
        public int id { get; set; }
        public int broj_osoba { get; set; }
        public int vrsta_smjestaja_id { get; set; }
        public int parcela_id { get; set; }
        public string oznaka { get; set; }
    
        public virtual parcela parcela { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prijava> prijavas { get; set; }
        public virtual vrsta_smjestaja vrsta_smjestaja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<racun> racuns { get; set; }
    }
}
