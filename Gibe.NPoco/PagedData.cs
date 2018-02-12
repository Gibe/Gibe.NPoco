using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gibe.NPoco
{
	public class PagedData<T>
	{
		public long CurrentPage { get; set; }
		public long TotalPages { get; set; }
		public long TotalItems { get; set; }
		public long ItemsPerPage { get; set; }
		public List<T> Items { get; set; }
	}
}