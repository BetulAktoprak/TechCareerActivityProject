using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCareerActivityProject.DAL.Models
{
    public class Stage : BaseModel
    {
        public string StageName { get; set; }
        public string StageType { get; set; }
        public string StageLocation { get; set; }
        public string StageImage { get; set; }
        public string StageDescription { get; set; }
        public string StageTime { get; set; }
    }
}
