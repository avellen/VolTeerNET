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
    
    public partial class tblProject
    {
        public tblProject()
        {
            this.tblVendorProjContacts = new HashSet<tblVendorProjContact>();
        }
    
        public System.Guid ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDesc { get; set; }
        public Nullable<int> AddrID { get; set; }
        public Nullable<bool> ActiveFlg { get; set; }
    
        public virtual tblVendAddress tblVendAddress { get; set; }
        public virtual ICollection<tblVendorProjContact> tblVendorProjContacts { get; set; }
    }
}
