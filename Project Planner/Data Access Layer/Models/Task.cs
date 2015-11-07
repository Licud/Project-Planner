using System;
using System.Collections.Generic;

namespace Data_Access_Layer.Models
{
    public class Task
    {

        public int TaskId { get; set; }

        public string strDetails { get; set; }

        public DateTime dtmCreatedDate { get; set; }

        public DateTime dtmFinishedDate { get; set; }

        public DateTime dtmProjectedFinishedDate { get; set; }

        public string strTaskType { get; set; }

        public virtual Project project { get; set; }

        public int ProjectId { get; set; }

        public virtual IEnumerable<TimeLog> ienumTimeLogs { get; set; }
    }
}

