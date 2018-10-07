using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Models
{
	public class PurchaseDetails
	{
		public int GoodsId { get; set; }
		public decimal StockAmount { get; set; }
		public DateTime PurchaseDate { get; set; }
		public DateTime LastModifiedDate { get; set; }
		public int IsArchived { get; set; }
	}
}
