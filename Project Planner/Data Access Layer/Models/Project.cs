using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data_Access_Layer.Models
{
    public class Project
    {

        public int ProjectId { get; set; }

        [Display(Name="Project Name")]
        public string strName { get; set; }

        [Display(Name = "Aim")]
        public string strAim { get; set; }

        [Display(Name = "Details")]
        public string strDetails { get; set; }

        [Display(Name = "Status")]
        public string strStatus { get; set; }

        [Display(Name = "Current Version")]
        public string strCurrentVersion { get; set; }

        [Display(Name = "Created Date")]
        public DateTime dtmCreatedDate { get; set; }

        [Display(Name = "Finished Date")]
        public DateTime dtmFinishedDate { get; set; }

        [Display(Name = "Projected Finished Date")]
        public DateTime dtmProjectedFinishedDate { get; set; }


        public virtual IEnumerable<Technology> technologies { get; set; }

        public virtual IEnumerable<Objective> objectives { get; set; }

        public virtual IEnumerable<Features> features { get; set; }

        public virtual IEnumerable<Bug> bugs { get; set; }

        public virtual IEnumerable<Task> tasks { get; set; }

    }
}