//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService1
{
    using System;
    using System.Collections.Generic;
    
    public partial class IMPRUMUT
    {
        public IMPRUMUT()
        {
            this.REVIEWs = new HashSet<REVIEW>();
        }
    
        public int ImprumutId { get; set; }
        public Nullable<int> CarteId { get; set; }
        public Nullable<int> CititorId { get; set; }
        public Nullable<System.DateTime> DataImprumut { get; set; }
        public Nullable<System.DateTime> DataScadenta { get; set; }
        public Nullable<System.DateTime> DataRestituire { get; set; }
    
        public virtual CARTE CARTE { get; set; }
        public virtual CITITOR CITITOR { get; set; }
        public virtual ICollection<REVIEW> REVIEWs { get; set; }
    }
}
