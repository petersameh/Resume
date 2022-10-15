using Microsoft.EntityFrameworkCore;
using resume.DataAccess.DataModels;
using resume.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resume.DataAccess.Implementations
{
    public class ResumeDAL : IResumeDAL
    {
        ResumeDbContext _resumeDbContext;
        public ResumeDAL(ResumeDbContext resumeDbContext)
        {
            _resumeDbContext = resumeDbContext;
        }
        public ResumeModel RetrieveResumeModel(int personalInfoThemeId = 1)
        {
           var resumeModel = new ResumeModel 
            {
                SkillModels = _resumeDbContext.Skills.ToList(),
                SocialProfileModels = _resumeDbContext.SocialProfiles.ToList(),
                BlogModels = _resumeDbContext.Blogs.ToList(),
                EducationModels = _resumeDbContext.Educations.ToList(),
                ExperienceModels = _resumeDbContext.Experiences.Include(e => e.Responsibilities).ToList(),
                PersonalInformationModel = _resumeDbContext.PersonalInformation.Where(p => p.Id == personalInfoThemeId).FirstOrDefault()
            };
            return resumeModel;
        }
    }
}
