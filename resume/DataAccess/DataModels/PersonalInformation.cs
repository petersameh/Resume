using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resume.DataAccess.DataModels
{
    public class PersonalInformation
    {
		public int Id { get; set; }
		public string Title { get; set; }
		public string Name { get; set; }
		public string NameAbbreviation { get; set; }
		public string Phone { get; set; }
		public string MilitaryService { get; set; }
		public string Email { get; set; }
		public string Website { get; set; }
		public string About { get; set; }
		public string ProfilePictureUrl { get; set; }
		public string CoverPhotoUrl { get; set; }
	}
}
