//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class FeaturedVideo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<int> VideoId { get; set; }
    
        public virtual Video Video { get; set; }
    }
}
