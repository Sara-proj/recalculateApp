//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class travel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public travel()
        {
            this.users_travels = new HashSet<users_travels>();
        }
    
        public int travelId { get; set; }
        public string direction { get; set; }
        public double price { get; set; }
        public string sourceArea { get; set; }
        public string sourceRing { get; set; }
        public string destArea { get; set; }
        public string destRing { get; set; }
        public int corporateCode { get; set; }
    
        public virtual contract contract { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<users_travels> users_travels { get; set; }
    }
}
