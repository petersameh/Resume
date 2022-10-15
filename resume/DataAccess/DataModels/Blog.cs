using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resume.DataAccess.DataModels
{
    public class Blog
    {
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Url { get; set; }
		public string ImageUrl { get; set; }
		public DateTime PublishDate { get; set; }
		public bool IsVideo { get; set; }
	}
}
