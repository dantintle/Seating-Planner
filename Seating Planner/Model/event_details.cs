//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Seating_Planner.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class event_details
    {
        public event_details()
        {
            this.guests = new HashSet<guest>();
            this.seats = new HashSet<seat>();
            this.tables = new HashSet<table>();
        }
    
        public int event_id { get; set; }
        public string event_name { get; set; }
    
        public virtual ICollection<guest> guests { get; set; }
        public virtual ICollection<seat> seats { get; set; }
        public virtual ICollection<table> tables { get; set; }
    }
}