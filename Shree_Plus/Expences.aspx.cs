using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shree_Plus
{
	public partial class Expences : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				InitilizePage();
;			}
		}
		
		public void InitilizePage()
		{
			ServiceLayer serviceLayer = new ServiceLayer();
			grdExpences.DataSource = serviceLayer.GetExpenceDetails();
			grdExpences.DataBind();
		}

		protected void btnSubmit_Click(object sender, EventArgs e)
		{
			Data_Models.Expences expences = new Data_Models.Expences();
			expences.ExpenceCost = Convert.ToDecimal(txtExpenceCost.Text);
			expences.ExpenceDate = Convert.ToDateTime(RadExpenceDate.SelectedDate);
			expences.ExpenceDetail = txtDetails.InnerText;
			ServiceLayer serviceLayer = new ServiceLayer();
			if (serviceLayer.InsertExpence(expences))
			{
				txtDetails.InnerText = "";
				txtExpenceCost.Text = "";
				RadExpenceDate.SelectedDate = DateTime.Today;
				InitilizePage();
			}
		}
	}
}