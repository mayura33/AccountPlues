using Services;
using System;
using System.Collections.Generic;
using System.Data;
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
			if (IsPostBack) return;
			InitilizePage();
		}

		void InitilizePage()
		{
			DateTime currentTime = DateTime.Now;
			DateTime previousMonthDate= currentTime.AddDays(-30);
			ServiceLayer serviceLayer = new ServiceLayer();
			radFromDate.SelectedDate = previousMonthDate;
			radToDate.SelectedDate = currentTime;
			DataTable sellsDetailsdt = serviceLayer.GetSellsDetails(radToDate.SelectedDate.Value,radFromDate.SelectedDate.Value);
			DataTable purchaseDetailsdt = serviceLayer.GetPurchaseDetails(radToDate.SelectedDate.Value, radFromDate.SelectedDate.Value);
			DataTable expenseDetailsdt = serviceLayer.GetExpenseDetails(radToDate.SelectedDate.Value, radFromDate.SelectedDate.Value);

			grdPurchase.DataSource = purchaseDetailsdt;
			grdPurchase.DataBind();

			grdSells.DataSource = sellsDetailsdt;
			grdSells.DataBind();

			grdExpense.DataSource = expenseDetailsdt;
			grdExpense.DataBind();

			Int64 totalPurchase = Convert.ToInt64(purchaseDetailsdt.Compute("Sum(StockAmount)", string.Empty));
			lblTotalPurchase.Text= Convert.ToString(totalPurchase) + " ₹";
			Int64 totalSells = Convert.ToInt64(sellsDetailsdt.Compute("Sum(Amount)", string.Empty));
			lblSells.Text = Convert.ToString(totalSells) + " ₹";
			Int64 totalExpense = Convert.ToInt64(expenseDetailsdt.Compute("Sum(ExpenceCost)", string.Empty));
			lblExpense.Text = Convert.ToString(totalExpense) + " ₹"; 
			lblTotalProfit.Text = (totalSells* 6.5/ 100).ToString() + " ₹";
		}

		protected void btnSubmit_Click(object sender, EventArgs e)
		{
			InitilizePage();
		}

	}
}
