using resume.DataAccess.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resume.DataAccess.Interfaces
{
    public interface IResumeDAL
    {
        ResumeModel RetrieveResumeModel(int personalInfoThemeId = 1);
    }
}
