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
    
    public partial class tblCameraImage
    {
        public int ImageID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public byte[] MainImage { get; set; }
    
        public virtual tblCustomerInfo tblCustomerInfo { get; set; }
    }
}
