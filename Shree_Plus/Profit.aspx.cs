using Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

namespace Shree_Plus
{
	public partial class Profit : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack) return;
			InitilizePage();
		}

		void InitilizePage()
		{
			ServiceLayer serviceLayer = new ServiceLayer();
			Int64 totalPurchase = Convert.ToInt64(serviceLayer.GetPurchaseDetails().Compute("Sum(StockAmount)", string.Empty));
			lblTotalPurchase.Text= Convert.ToString(totalPurchase) + " ₹";
			Int64 totalSells = Convert.ToInt64(serviceLayer.GetSellsDetails().Compute("Sum(Amount)", string.Empty));
			lblSells.Text = Convert.ToString(totalSells) + " ₹";
			lblTotalProfit.Text = (totalSells* 6.5/ 100).ToString() + " ₹";
		}

		protected void btnSubmit_Click(object sender, EventArgs e)
		{
			ServiceLayer serviceLayer = new ServiceLayer();

		}
	}
}
