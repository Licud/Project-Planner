
namespace Data_Access_Layer.Models
{
    class Features
    {

        public int FeaturesId { get; set; }

        public string strDetails { get; set; }

        public string strVersionImplementation { get; set; }

        public virtual Project project { get; set; }

        public int ProjectId { get; set; }
    }
}