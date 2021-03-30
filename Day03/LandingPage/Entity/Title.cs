using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingPage.Entity {

	public class Title {
		public string title_id { get; set; }
		public string title { get; set; }
		public string type { get; set; }
		public string pub_id { get; set; }
		public string notes { get; set; }
		public Nullable<decimal> price { get; set; }
		public Nullable<decimal> advance { get; set; }
		public int? royalty { get; set; }
		public int? ytd_sales { get; set; }
		public DateTime pubdate {get; set;}

     }
}
