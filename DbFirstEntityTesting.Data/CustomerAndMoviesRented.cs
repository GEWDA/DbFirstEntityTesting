//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbFirstEntityTesting.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerAndMoviesRented
    {
        public int RMID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Title { get; set; }
        public Nullable<decimal> Rental_Cost { get; set; }
        public Nullable<System.DateTime> DateRented { get; set; }
        public Nullable<System.DateTime> DateReturned { get; set; }
    }
}
