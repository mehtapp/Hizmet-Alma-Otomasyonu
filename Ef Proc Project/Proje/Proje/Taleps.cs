//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje
{
    using System;
    using System.Collections.Generic;
    
    public partial class Taleps
    {
        public int TalepNo { get; set; }
        public Nullable<int> HizmetNo { get; set; }
        public Nullable<int> MusteriNo { get; set; }
        public string MusteriNot { get; set; }
        public Nullable<bool> TalepDurumu { get; set; }
    
        public virtual Hizmetlers Hizmetlers { get; set; }
        public virtual Musterilers Musterilers { get; set; }
    }
}