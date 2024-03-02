using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
	public class ProductEntity
	{
		public int id { get; set; }
		public string name { get; set; }
		public int quantity { get; set; }
		public decimal price { get; set; }
		public string description { get; set; }
	}
}
