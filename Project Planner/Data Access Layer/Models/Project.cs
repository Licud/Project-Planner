using System;
using System.Collections.Generic;

namespace Data_Access_Layer.Models
{
    class Project
    {

        public int ProjectId { get; set; }

        public string strName { get; set; }

        public string strAim { get; set; }

        public string strDetails { get; set; }

        public string strStatus { get; set; }

        public string strCurrentVersion { get; set; }

        public DateTime dtmCreatedDate { get; set; }

        public DateTime dtmFinishedDate { get; set; }

        public DateTime dtmProjectedFinishedDate { get; set; }

        public virtual IEnumerable<Technology> technologies { get; set; }

        public virtual IEnumerable<Objective> objectives { get; set; }

        public virtual IEnumerable<Features> features { get; set; }

        public virtual IEnumerable<Bug> bugs { get; set; }

        public virtual IEnumerable<Task> tasks { get; set; }

    }
}