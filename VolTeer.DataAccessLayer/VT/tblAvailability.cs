//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VolTeer.DataAccessLayer.VT
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAvailability
    {
        public tblAvailability()
        {
            this.tblAvailability1 = new HashSet<tblAvailability>();
        }
    
        public System.Guid VolID { get; set; }
        public int AddrID { get; set; }
        public int AvailID { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public System.DateTime AvailStart { get; set; }
        public System.DateTime AvailEnd { get; set; }
        public string RecurrenceRule { get; set; }
        public Nullable<int> RecurrenceParentID { get; set; }
        public string Reminder { get; set; }
        public string Annotations { get; set; }
    
        public virtual ICollection<tblAvailability> tblAvailability1 { get; set; }
        public virtual tblAvailability tblAvailability2 { get; set; }
        public virtual tblVolAddress tblVolAddress { get; set; }
        public virtual tblVolunteer tblVolunteer { get; set; }
    }
}
