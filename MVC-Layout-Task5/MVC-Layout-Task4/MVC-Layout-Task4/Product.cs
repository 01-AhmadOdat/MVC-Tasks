//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Layout_Task4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int product_ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Category_ID { get; set; }
        public string description { get; set; }
        public Nullable<double> price { get; set; }
        public Nullable<int> quantity { get; set; }
        public string ImageProduct { get; set; }
        public Nullable<double> newPrice { get; set; }
    }
}