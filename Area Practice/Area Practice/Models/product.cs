//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Area_Practice.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int productId { get; set; }
        public int userId { get; set; }
        public string productName { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public System.DateTime createdDate { get; set; }
        public System.DateTime updatedDate { get; set; }
        public int category1Id { get; set; }
        public bool isEnable { get; set; }
        public int category2Id { get; set; }
        public Nullable<int> dealerId { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Category Category1 { get; set; }
        public virtual Dealer Dealer { get; set; }
        public virtual user user { get; set; }
    }
}
