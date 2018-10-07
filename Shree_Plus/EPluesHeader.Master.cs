using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shree_Plus
{
	public partial class EPluesHeader : System.Web.UI.MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (IsPostBack) return;
			if (string.IsNullOrEmpty(Convert.ToString(Session["IsValidUser"])))
			{
				//Response.Redirect("Login.aspx");
			}
		}

		protected void btnLogOut_Click(object sender, EventArgs e)
		{
			Session.RemoveAll();
			Response.Redirect("Login.aspx");
		}
	}
}