//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kcsara.Training.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrainingRoster
    {
        public TrainingRoster()
        {
            this.TrainingAwards = new HashSet<TrainingAward>();
        }
    
        public System.Guid Id { get; set; }
        public Nullable<System.DateTime> TimeIn { get; set; }
        public Nullable<System.DateTime> TimeOut { get; set; }
        public Nullable<int> Miles { get; set; }
        public string Comments { get; set; }
        public Nullable<int> OvertimeHours { get; set; }
        public System.DateTime LastChanged { get; set; }
        public string ChangedBy { get; set; }
        public Nullable<System.Guid> Person_Id { get; set; }
        public Nullable<System.Guid> Training_Id { get; set; }
    
        public virtual Member Member { get; set; }
        public virtual ICollection<TrainingAward> TrainingAwards { get; set; }
        public virtual Training Training { get; set; }
    }
}
