using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.AdventureWorks;

//[BusinessEntityID]
//      ,[TerritoryID]
//      ,[SalesQuota]
//      ,[Bonus]
//      ,[CommissionPct]
//      ,[SalesYTD]
//      ,[SalesLastYear]
//      ,[rowguid]
//      ,[ModifiedDate]

namespace BLL.LearnRepos
{
    public class MyControler
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public List<MySalesPerson> GetTen()
        {
            var dbSalesList = from p in unitOfWork.UserRepository.Get() select p;
            var salesList = new List<MySalesPerson>();
            if (dbSalesList.Any())
            {
                foreach (var user in dbSalesList.Take(10))
                {
                    salesList.Add(new MySalesPerson()
                    {
                         Bonus = user.Bonus,
                          CommissionPct=user.CommissionPct,
                           SalesYTD=user.SalesYTD,
                            TerritoryID=user.TerritoryID

                    });
                }
            }
            return salesList;
            //ViewBag.FirstName = "My First Name";
            //ViewData["FirstName"] = "My First Name";
            //if (TempData.Any())
            //{
            //    var tempData = TempData["TempData Name"];
            //}
            //return View(salesP);
        }

        public List<MySalesPerson> GetTest()
        {
            return new List<MySalesPerson>
            {
                new MySalesPerson { Bonus = 100.0m, SalesYTD = 111.5m },
                new MySalesPerson { Bonus = 122.0m, SalesYTD = 111.5m }
            };
        }
    }

    public class MySalesPerson
    {
        public int BusinessEntityID { get; set; }
        public Nullable<int> TerritoryID { get; set; }
        public Nullable<decimal> SalesQuota { get; set; }
        public decimal Bonus { get; set; }
        public decimal CommissionPct { get; set; }
        public decimal SalesYTD { get; set; }
        public decimal SalesLastYear { get; set; }
        public System.Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
