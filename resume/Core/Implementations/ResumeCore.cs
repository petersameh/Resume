using resume.Core.Interfaces;
using resume.DataAccess.DataModels;
using resume.DataAccess.Interfaces;
using resume.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resume.Core.Implementations
{
    public class ResumeCore : IResumeCore
    {
        IResumeDAL _resumeDAL;
        ConfigHelper _configHelper;
        public ResumeCore(IResumeDAL resumeDAL, ConfigHelper configHelper)
        {
            _resumeDAL = resumeDAL;
            _configHelper = configHelper;
        }
        public ResumeModel RetrieveResumeModel()
        {
            var personalInfoThemeId = _configHelper.GetPersonalInformationThemeId();
            var resume = _resumeDAL.RetrieveResumeModel(personalInfoThemeId);
            return resume;
        }
    }
}
