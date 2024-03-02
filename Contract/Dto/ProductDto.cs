using System.ComponentModel.DataAnnotations;

namespace Contract.Dto
{
	public class ProductDto
	{
		public int id { get; set; }
		[Required(ErrorMessage = "Ürün adı zorunludur.")]
		public string name { get; set; }
		public int quantity { get; set; }
		public decimal price { get; set; }
		public string description { get; set; }
		public string priceCurrency
		{
			set
			{
				priceCurrency = value;
			}
			get { return String.Format("{0:C}", price); }
		}
	}
}
