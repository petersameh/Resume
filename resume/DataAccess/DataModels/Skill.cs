using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resume.DataAccess.DataModels
{
    public class Skill
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public decimal Progress { get; set; }
        public bool IsPrimary { get; set; }
    }
}
