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
    
    public partial class status_osobe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public status_osobe()
        {
            this.prijavas = new HashSet<prijava>();
        }
    
        public int id { get; set; }
        public string naziv { get; set; }
        public decimal popust { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prijava> prijavas { get; set; }
    }
}
