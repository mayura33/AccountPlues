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
	public partial class Sells : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				InitilizeForm();
				GetSellsDetails();
			}
		}
		private void GetSellsDetails()
		{
			ServiceLayer serviceLayer = new ServiceLayer();
			grdSells.DataSource= serviceLayer.GetSellsDetails();
			grdSells.DataBind();
		}

		private void InitilizeForm()
		{
			ServiceLayer serviceLayer = new ServiceLayer();
			ddlVehicle.DataSource = serviceLayer.GetVehiclesDetails();
			ddlVehicle.DataTextField = "VehicleDetails";
			ddlVehicle.DataValueField = "ID";
			ddlVehicle.DataBind();
			ddlVehicle.Items.Insert(0, "Select Vehicle");
			ddlWareHourse.DataSource = serviceLayer.GetWarehouseDetails();
			ddlWareHourse.DataTextField = "WarehouseName";
			ddlWareHourse.DataValueField = "ID";
			ddlWareHourse.DataBind();
			ddlWareHourse.Items.Insert(0, "Select WareHourse");
			RadSellDate.SelectedDate = DateTime.Today;
		}


		protected void btnSubmit_Click(object sender, EventArgs e)
		{
			SellsDetail sellsDetail = new SellsDetail();
			sellsDetail.Amount = Convert.ToDecimal(txtSellAmount.Text);
			sellsDetail.Details = txtDetails.InnerText;
			sellsDetail.SellsDate = Convert.ToDateTime(RadSellDate.SelectedDate);
			sellsDetail.VehicleId =Convert.ToInt16(ddlVehicle.SelectedValue);
			sellsDetail.WarehouseId = Convert.ToInt16(ddlWareHourse.SelectedValue);
			ServiceLayer serviceLayer = new ServiceLayer();
			if (serviceLayer.InsertSells(sellsDetail))
			{
				txtSellAmount.Text = "";
				txtDetails.InnerText = "";
				RadSellDate.SelectedDate = DateTime.Today;
			}

			GetSellsDetails();
		}
	}
}