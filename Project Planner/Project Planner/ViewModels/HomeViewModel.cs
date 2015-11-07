
using Data_Access_Layer.Models;
using System.Collections.Generic;

namespace Project_Planner.Models
{
    public class HomeViewModel
    {

        public Project NewProject { get; set; }

        public IEnumerable<Project> Project { get; set; }

        public Bug Bug { get; set; }

        public Features Features { get; set; }

        public Objective Objectives { get; set; }

        public Task Task { get; set; }

        public Technology Technology { get; set; }

        public TimeLog TimeLog { get; set; }

    }
}