//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace footbalform1.mode1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Umumi00
    {
        public int ID { get; set; }
        public string Musteriadi { get; set; }
        public int Musterinomresi { get; set; }
        public int Qiymetler { get; set; }
        public int Necenefer { get; set; }
        public System.DateTime tarix { get; set; }
        public int MeydancaID { get; set; }
    
        public virtual Meydanca00 Meydanca00 { get; set; }
    }
}
