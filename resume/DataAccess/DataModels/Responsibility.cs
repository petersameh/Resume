using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resume.DataAccess.DataModels
{
    public class Responsibility
    {
        public int Id { get; set; }
        public virtual Experience Experience { get; set; }
        public int ExperienceId { get; set; }
        public string Body { get; set; }
    }
}
