//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblRequestToJoin
    {
        public int RequsetNum { get; set; }
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public string RequestStatus { get; set; }
    
        public virtual tblCity tblCity { get; set; }
        public virtual tblRequestToJoinSuperStudent tblRequestToJoinSuperStudent { get; set; }
    }
}