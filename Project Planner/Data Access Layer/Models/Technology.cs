
namespace Data_Access_Layer.Models
{
    public class Technology
    {

        public int TechnologyId { get; set; }

        public string strName { get; set; }

        public string strDescription { get; set; }

        public virtual Project project { get; set; }

        public int ProjectId { get; set; }

    }
}
