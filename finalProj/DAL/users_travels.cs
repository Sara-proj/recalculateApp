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
    
    public partial class users_travels
    {
        public int id { get; set; }
        public string userId { get; set; }
        public int travelId { get; set; }
        public System.DateTime travelDate { get; set; }
    
        public virtual User User { get; set; }
    }
}
