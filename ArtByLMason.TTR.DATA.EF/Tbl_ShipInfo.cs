//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArtByLMason.TTR.DATA.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_ShipInfo
    {
        public int ShipInfoId { get; set; }
        public Nullable<int> ShippingDetailId { get; set; }
        public Nullable<int> MemberId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    
        public virtual Tbl_ShippingDetails Tbl_ShippingDetails { get; set; }
    }
}
