using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resume.DataAccess.DataModels
{
    public class Education
    {
		public int Id { get; set; }
		public string Degree { get; set; }
		public string InstitutionName { get; set; }
		public string Description { get; set; }
		public decimal GPAScore { get; set; }
		public DateTime DateFrom { get; set; }
		public DateTime? DateTo { get; set; }
	}
}
