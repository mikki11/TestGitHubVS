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

}
