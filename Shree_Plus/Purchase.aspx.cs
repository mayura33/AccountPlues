using Data_Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shree_Plus
{
	public partial class Purchase : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				FillGrid();
			}
		}
		public void FillGrid()
		{
			ServiceLayer serviceLayer = new ServiceLayer();
			grdPurchase.DataSource = serviceLayer.GetPurchaseDetails();
			grdPurchase.DataBind();
		}

		protected void btnSubmit_Click(object sender, EventArgs e)
		{
			PurchaseDetails purchaseDetails = new PurchaseDetails();
			purchaseDetails.StockAmount = Convert.ToDecimal(txtStockAmount.Text);
			purchaseDetails.PurchaseDate = Convert.ToDateTime(RadPurchaseDate.SelectedDate);
			ServiceLayer serviceLayer = new ServiceLayer();
			if (serviceLayer.InsertStock(purchaseDetails))
			{
				txtStockAmount.Text = "";
				RadPurchaseDate.SelectedDate = DateTime.Today;
				FillGrid();
			}
		}
	}
}