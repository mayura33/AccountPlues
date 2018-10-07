using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Models
{
	public class Expences
	{
		public int ExpenceId { get; set; }
		public string ExpenceDetail { get; set; }
		public decimal ExpenceCost { get; set; }
		public DateTime ExpenceDate { get; set; }
		public DateTime LastModifiedDate { get; set; }
	}
}
