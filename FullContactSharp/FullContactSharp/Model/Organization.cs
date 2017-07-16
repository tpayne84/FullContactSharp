using System.Collections.Generic;

namespace FullContactSharp
{
	public class Organization
	{
		public string name { get; set; }
		public int approxEmployees { get; set; }
		public string founded { get; set; }
		public string overview { get; set; }
		public ContactInfo contactInfo { get; set; }
		public List<Link> links { get; set; }
		public List<Image> images { get; set; }
		public List<string> keywords { get; set; }
	}
}
