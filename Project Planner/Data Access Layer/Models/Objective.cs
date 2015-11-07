
namespace Data_Access_Layer.Models
{
    public class Objective
    {

        public int ObjectiveId { get; set; }

        public string strDescription { get; set; }

        public virtual Project project { get; set; }

        public int ProjectId { get; set; }
    }
}