using Data_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services;
using System.Web.SessionState;

namespace Shree_Plus
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnLogin_Click(object sender, EventArgs e)
		{
			LoginUser login = new LoginUser();
			login.userName = txtUserName.Text;
			login.Password = txtPassword.Text;
			ServiceLayer services = new ServiceLayer();
			if (services.CheckIsUserValid(login))
			{
				SessionIDManager manager = new SessionIDManager();
				string newID = manager.CreateSessionID(Context);
				bool redirected = false;
				bool isAdded = false;
				manager.SaveSessionID(Context, newID, out redirected, out isAdded);
				if (isAdded)
				{
					Session["IsValidUser"] = newID;
					Response.Redirect("DashBoard.aspx");
				}
			}
			else
			{
				Response.Redirect("Login.aspx");
			}
		}
	}
}