//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoaderApiAndAdmin.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Quote
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int TransportOwnerId { get; set; }
        public string QuoteBudget { get; set; }
        public string QuoteStatus { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual User User { get; set; }
    }
}
