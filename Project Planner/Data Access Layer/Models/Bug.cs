using System;

namespace Data_Access_Layer.Models
{
    public class Bug
    {

        public int BugId { get; set; }

        public string strDetails { get; set; }

        public DateTime dtmCreatedDate { get; set; }

        public DateTime dtmProjectedFixDate { get; set; }

        public virtual Project project { get; set; }

        public int ProjectId { get; set; }

    }
}