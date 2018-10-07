using Data_Models;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DataRepository
{
	public class Repository
	{
		SqlConnection con;

		public Repository()
		{
			con = new SqlConnection(ConfigurationManager.ConnectionStrings["localDbConnectionString"].ConnectionString);
		}

		#region INSERT

		public bool InsertStock(PurchaseDetails purchaseDetails)
		{
			SqlCommand cmd = new SqlCommand("spInsertStock", con);
			cmd.Parameters.AddWithValue("@StockAmount", purchaseDetails.StockAmount);
			cmd.Parameters.AddWithValue("@PurchaseDate", purchaseDetails.PurchaseDate);
			cmd.CommandType = CommandType.StoredProcedure;
			con.Open();
			int rowAffected = cmd.ExecuteNonQuery();
			con.Close();
			return rowAffected > 0 ? true : false;
		}

		public bool InsertSells(SellsDetail sellsDetail)
		{
			SqlCommand cmd = new SqlCommand("spInsertSells", con);
			cmd.Parameters.AddWithValue("@SellsDate", sellsDetail.SellsDate);
			cmd.Parameters.AddWithValue("@Details", sellsDetail.Details);
			cmd.Parameters.AddWithValue("@VehicleId", sellsDetail.VehicleId);
			cmd.Parameters.AddWithValue("@Amount", sellsDetail.Amount);
			cmd.Parameters.AddWithValue("@WarehourseId", sellsDetail.WarehouseId);
			cmd.CommandType = CommandType.StoredProcedure;
			con.Open();
			int rowAffected = cmd.ExecuteNonQuery();
			con.Close();
			return rowAffected > 0 ? true : false;
		}

		public bool InsertExpence(Expences expences)
		{
			SqlCommand cmd = new SqlCommand("spInsertExpence", con);
			cmd.Parameters.AddWithValue("@ExpenceDetails", expences.ExpenceDetail);
			cmd.Parameters.AddWithValue("@ExpenceCost", expences.ExpenceCost);
			cmd.Parameters.AddWithValue("@ExpenceDate", expences.ExpenceDate);
			cmd.CommandType = CommandType.StoredProcedure;
			con.Open();
			int rowAffected = cmd.ExecuteNonQuery();
			con.Close();
			return rowAffected > 0 ? true : false;
		}

		#endregion

		#region SELECT/GET

		public bool checkIsUserValid(LoginUser login)
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
			SqlCommand cmd = new SqlCommand("spGetPurchase", con);
			cmd.CommandType = CommandType.StoredProcedure; cmd.CommandType = CommandType.StoredProcedure;
			con.Open();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();
			return dt;

		}

		public DataTable GetSellsDetails()
		{
			SqlCommand cmd = new SqlCommand("spGetSells", con);
			cmd.CommandType = CommandType.StoredProcedure; cmd.CommandType = CommandType.StoredProcedure;
			con.Open();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();
			return dt;
		}

		public DataTable GetVehiclesDetails()
		{
			SqlCommand cmd = new SqlCommand("spGetVehicles", con);
			cmd.CommandType = CommandType.StoredProcedure; cmd.CommandType = CommandType.StoredProcedure;
			con.Open();
			SqlDataReader rdr = cmd.ExecuteReader();
			var dataTable = new DataTable();
			dataTable.Load(rdr);
			con.Close();
			return dataTable;
		}

		public DataTable GetWarehouseDetails()
		{
			SqlCommand cmd = new SqlCommand("spGetWarehouse", con);
			cmd.CommandType = CommandType.StoredProcedure; cmd.CommandType = CommandType.StoredProcedure;
			con.Open();
			SqlDataReader rdr = cmd.ExecuteReader();
			var dataTable = new DataTable();
			dataTable.Load(rdr);
			con.Close();
			return dataTable;
		}

		public DataTable GetExpences()
		{
			SqlCommand cmd = new SqlCommand("spGetExpences", con);
			cmd.CommandType = CommandType.StoredProcedure; cmd.CommandType = CommandType.StoredProcedure;
			con.Open();
			SqlDataReader rdr = cmd.ExecuteReader();
			var dataTable = new DataTable();
			dataTable.Load(rdr);
			con.Close();
			return dataTable;
		}

		#endregion

	}
}
