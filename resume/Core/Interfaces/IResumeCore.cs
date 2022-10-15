using resume.DataAccess.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resume.Core.Interfaces
{
    public interface IResumeCore
    {
        ResumeModel RetrieveResumeModel();
    }
}
