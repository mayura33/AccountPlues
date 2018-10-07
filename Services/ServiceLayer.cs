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
        public bool CheckIsUserValid(LoginUser login)
        {
            Repository repository = new Repository();
            return repository.checkIsUserValid(login);
        }

		public bool InsertStock(PurchaseDetails purchaseDetails)
		{
			Repository repository = new Repository();
			return repository.InsertStock(purchaseDetails);
		}

		public bool InsertSells(SellsDetail sellsDetail)
		{
			Repository repository = new Repository();
			return repository.InsertSells(sellsDetail);
		}

		public DataTable GetPurchaseDetails()
		{
			Repository repository = new Repository();
			return repository.GetPurchaseDetails();
		}

		public DataTable GetSellsDetails()
		{
			Repository repository = new Repository();
			return repository.GetSellsDetails();
		}

		public DataTable GetVehiclesDetails()
		{
			Repository repository = new Repository();
			return repository.GetVehiclesDetails();
		}

		public DataTable GetWarehouseDetails()
		{
			Repository repository = new Repository();
			return repository.GetWarehouseDetails();
		}

		public DataTable GetExpenceDetails()
		{
			Repository repository = new Repository();
			return repository.GetExpences();
		}

		public bool InsertExpence(Expences expences)
		{
			Repository repository = new Repository();
			return repository.InsertExpence(expences);
		}

	}
}
