//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Magazine.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class review
    {
        public int USER_id { get; set; }
        public int FILE_id { get; set; }
        public string Comment { get; set; }
        public int STATUS_id { get; set; }
    
        public virtual file file { get; set; }
        public virtual status status { get; set; }
        public virtual user user { get; set; }
    }
}
