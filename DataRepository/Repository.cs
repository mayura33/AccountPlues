using Data_Models;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DataRepository 
{
	public class Repository : BaseRepository
	{
		#region INSERT

		public bool InsertStock(PurchaseDetails purchaseDetails)
		{
			SqlCommand cmd = GetCommand("spInsertStock");
			cmd.Parameters.AddWithValue("@StockAmount", purchaseDetails.StockAmount);
			cmd.Parameters.AddWithValue("@PurchaseDate", purchaseDetails.PurchaseDate);
			int rowAffected = cmd.ExecuteNonQuery();
			con.Close();
			return rowAffected > 0 ? true : false;
		}

		public bool InsertSells(SellsDetail sellsDetail)
		{
			SqlCommand cmd = GetCommand("spInsertSells");
			cmd.Parameters.AddWithValue("@SellsDate", sellsDetail.SellsDate);
			cmd.Parameters.AddWithValue("@Details", sellsDetail.Details);
			cmd.Parameters.AddWithValue("@VehicleId", sellsDetail.VehicleId);
			cmd.Parameters.AddWithValue("@Amount", sellsDetail.Amount);
			cmd.Parameters.AddWithValue("@WarehourseId", sellsDetail.WarehouseId);
			int rowAffected = cmd.ExecuteNonQuery();
			con.Close();
			return rowAffected > 0 ? true : false;
		}

		public bool InsertExpence(Expences expences)
		{
			SqlCommand cmd = GetCommand("spInsertExpence");
			cmd.Parameters.AddWithValue("@ExpenceDetails", expences.ExpenceDetail);
			cmd.Parameters.AddWithValue("@ExpenceCost", expences.ExpenceCost);
			cmd.Parameters.AddWithValue("@ExpenceDate", expences.ExpenceDate);
			int rowAffected = cmd.ExecuteNonQuery();
			con.Close();
			return rowAffected > 0 ? true : false;
		}

		#endregion

		#region SELECT/GET

		public bool CheckIsUserValid(LoginUser login)
		{
			SqlParameter[] parameters =
			{
				new SqlParameter("@UserName",login.userName),
				new SqlParameter("@Password",login.Password)
			};
			return Convert.ToInt16(SqlHelper.ExecuteScalar(con, "userLogin", parameters)) > 0 ? true : false;
		}

		public DataTable GetPurchaseDetails()
		{
			SqlCommand cmd = GetCommand("spGetPurchase");
			cmd.CommandType = CommandType.StoredProcedure;
			return GetCommandDataTable(cmd);
		}

		public DataTable GetSellsDetails()
		{
			SqlCommand cmd = GetCommand("spGetSells");
			return GetCommandDataTable(cmd);
		}

		public DataTable GetVehiclesDetails()
		{
			SqlCommand cmd = GetCommand("spGetVehicles");
			return GetCommandDataTable(cmd);
		}

		public DataTable GetWarehouseDetails()
		{
			SqlCommand cmd = GetCommand("spGetWarehouse");
			return GetCommandDataTable(cmd);
		}

		public DataTable GetExpences()
		{
			SqlCommand cmd = GetCommand("spGetExpences");
			return GetCommandDataTable(cmd);
		}

		public DataTable GetPurchaseDetails(DateTime fromDate, DateTime toDate)
		{
			SqlCommand cmd = GetCommand("spGetPurchaseFilterd");
			cmd.Parameters.AddWithValue("@StartDate", fromDate);
			cmd.Parameters.AddWithValue("@EndDate", toDate);
			return GetCommandDataTable(cmd);
		}

		public DataTable GetSellsDetails(DateTime fromDate, DateTime toDate)
		{
			SqlCommand cmd = GetCommand("spGetSellsFilterd");
			cmd.Parameters.AddWithValue("@StartDate", fromDate);
			cmd.Parameters.AddWithValue("@EndDate", toDate);
			return GetCommandDataTable(cmd);
		}

		public DataTable GetexpenseDetails(DateTime fromDate, DateTime toDate)
		{
			SqlCommand cmd = GetCommand("spGetExpenseFilterd");
			cmd.Parameters.AddWithValue("@StartDate", fromDate);
			cmd.Parameters.AddWithValue("@EndDate", toDate);
			return GetCommandDataTable(cmd);
		}

		#endregion

	}
}
