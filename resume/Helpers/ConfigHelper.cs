using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resume.Helpers
{
    public class ConfigHelper
    {
        private IConfiguration _configuration;

        public ConfigHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public int GetPersonalInformationThemeId()
        {
            return int.Parse(_configuration["PersonalInformationThemeId"]);
        }
    }
}
