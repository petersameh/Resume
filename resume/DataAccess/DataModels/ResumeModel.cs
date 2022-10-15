using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resume.DataAccess.DataModels
{
    public class ResumeModel
    {
		public PersonalInformation PersonalInformationModel { get; set; }
		public List<SocialProfile> SocialProfileModels { get; set; }
		public List<Experience> ExperienceModels { get; set; }
		public List<Education> EducationModels { get; set; }
		public List<Skill> SkillModels { get; set; }
		public List<Blog> BlogModels { get; set; }
	}
}
