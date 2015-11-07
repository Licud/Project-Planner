using System;

namespace Data_Access_Layer.Models
{
    public class TimeLog
    {

        public int TimeLogId { get; set; }

        public string strDetails { get; set; }

        public double dblTime { get; set; }

        public DateTime dtmCreatedDate { get; set; }

        public virtual Task task { get; set; }

        public int TaskId { get; set; }

    }
}