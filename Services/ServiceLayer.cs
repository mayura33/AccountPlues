using Data_Models;
using DataRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
	public class ServiceLayer
	{
		private Repository repository;

		public ServiceLayer()
		{
			repository = new Repository();
		}

		public bool CheckIsUserValid(LoginUser login)
		{
			return repository.CheckIsUserValid(login);
		}

		public bool InsertStock(PurchaseDetails purchaseDetails)
		{
			return repository.InsertStock(purchaseDetails);
		}

		public bool InsertSells(SellsDetail sellsDetail)
		{
			return repository.InsertSells(sellsDetail);
		}

		public DataTable GetPurchaseDetails()
		{
			return repository.GetPurchaseDetails();
		}

		public DataTable GetSellsDetails()
		{
			return repository.GetSellsDetails();
		}

		public DataTable GetVehiclesDetails()
		{
			return repository.GetVehiclesDetails();
		}

		public DataTable GetWarehouseDetails()
		{
			return repository.GetWarehouseDetails();
		}

		public DataTable GetExpenceDetails()
		{
			return repository.GetExpences();
		}

		public bool InsertExpence(Expences expences)
		{
			return repository.InsertExpence(expences);
		}

		public DataTable GetSellsDetails(DateTime fromDate, DateTime toDate)
		{
			return repository.GetSellsDetails(fromDate, toDate);
		}

		public DataTable GetPurchaseDetails(DateTime fromDate,DateTime toDate)
		{
			return repository.GetPurchaseDetails(fromDate, toDate);
		}

		public DataTable GetExpenseDetails(DateTime fromDate, DateTime toDate)
		{
			return repository.GetexpenseDetails(fromDate, toDate);
		}
	}
}
