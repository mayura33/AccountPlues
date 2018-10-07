using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Models
{
	public class SellsDetail
	{
		public int SellsId { get; set; }
		public DateTime SellsDate { get; set; }
		public string Details { get; set; }
		public int VehicleId { get; set; }
		public decimal Amount { get; set; }
		public int WarehouseId { get; set; }
		public DateTime LastModifiedDate { get; set; }
	}
}
