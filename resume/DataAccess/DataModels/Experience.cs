using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resume.DataAccess.DataModels
{
    public class Experience
    {
		public int Id { get; set; }
		public string JobTitle { get; set; }
		public string CompanyName { get; set; }
		public DateTime DateFrom { get; set; }
		public DateTime? DateTo { get; set; }
		public string Description { get; set; }
		public virtual ICollection<Responsibility> Responsibilities { get; set; }
	}
}
