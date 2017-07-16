using System.Collections.Generic;

namespace FullContactSharp
{
    public class PersonData
	{
		public int status { get; set; }
		public string requestId { get; set; }
		public double likelihood { get; set; }
		public List<Photo> photos { get; set; }
		public ContactInfo contactInfo { get; set; }
		public List<SocialProfile> socialProfiles { get; set; }
	}
}
