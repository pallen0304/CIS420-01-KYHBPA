//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KYHBPA.Data.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class EventFeedback
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public Nullable<int> Event_Id { get; set; }
        public Nullable<int> Member_Id { get; set; }
    
        public virtual Event Event { get; set; }
        public virtual Member Member { get; set; }
    }
}
