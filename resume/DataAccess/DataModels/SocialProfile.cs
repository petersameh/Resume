using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resume.DataAccess.DataModels
{
    public class SocialProfile
    {
        public int Id { get; set; }
        public string SocialNetworkName { get; set; }
        public string IconUrl { get; set; }
        public string ProfileUrl { get; set; }
    }
}
