using Data_Models;
using DataRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
	}
}
