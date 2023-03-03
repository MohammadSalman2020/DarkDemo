//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DarkDemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCustomerInfo
    {
        public tblCustomerInfo()
        {
            this.tblCustomerChecks = new HashSet<tblCustomerCheck>();
            this.tblCameraImages = new HashSet<tblCameraImage>();
            this.tblScannerImages = new HashSet<tblScannerImage>();
        }
    
        public int CustomerID { get; set; }
        public string CusFirstname { get; set; }
        public string CusMiddlename { get; set; }
        public string Cuslastname { get; set; }
        public string CusAddress { get; set; }
        public string CusCity { get; set; }
        public string CusState { get; set; }
        public Nullable<int> CusZipCode { get; set; }
        public string CusDriverLicense { get; set; }
        public Nullable<System.DateTime> CusDOB { get; set; }
        public string CusCellPhone { get; set; }
        public string CusWorkPhone { get; set; }
        public string CusSSn { get; set; }
        public Nullable<bool> IsBad { get; set; }
    
        public virtual ICollection<tblCustomerCheck> tblCustomerChecks { get; set; }
        public virtual ICollection<tblCameraImage> tblCameraImages { get; set; }
        public virtual ICollection<tblScannerImage> tblScannerImages { get; set; }
    }
}
