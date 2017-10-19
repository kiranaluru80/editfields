using System;
using System.Collections.Generic;

namespace ReadDataFromJson
{
	public class RatingClass
	{
		public string Rating { get; set; }
		public bool RatingChecked { get; set; }
		public int Rating_ID { get; set; }
		public bool Selected { get; set; }
	}

	public class RootObjectNewTwo
	{
		public string Category { get; set; }
		public string CategoryDesc { get; set; }
		public int Category_ID { get; set; }
		public object Comments { get; set; }
		public List<object> EntBehaviors { get; set; }
		public bool IsActive { get; set; }
		public object JSSE_ID { get; set; }
		public List<object> OrgBehaviors { get; set; }
		public object RatingID { get; set; }
		public List<RatingClass> Ratings { get; set; }
	}
}
