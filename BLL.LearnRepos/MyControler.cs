using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.AdventureWorks;
using AutoMapper;

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
            var dbSalesList = from p in unitOfWork.SalesPRepository.Get() select p;
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

        public List<MapOrderHeader> GetSalesOrderBetween(int startId, int endId)
        {

            ////Radi Static Verzija
            //Mapper.Initialize(n => n.CreateMap<SalesOrderHeader, MapOrderHeader>()); 

            MapperConfiguration config = new MapperConfiguration(cfg => cfg.CreateMap<SalesOrderHeader, MapOrderHeader>());
            IMapper mapper = config.CreateMapper();

            var dbOrderHeader = unitOfWork.SalesOrderHeaderRepos.Get();
            List<MapOrderHeader> lstOrderHeader = new List<MapOrderHeader>();

            if (dbOrderHeader.Any())
            {
                ////Radi Static Verzija
                //try
                //{
                //    var xlstOrderHeader = Mapper.Map<IEnumerable<SalesOrderHeader>, IEnumerable<MapOrderHeader>>(dbOrderHeader);
                //    lstOrderHeader = xlstOrderHeader.Where(x => x.SalesOrderID > startId && x.SalesOrderID < endId).ToList();
                //}
                //catch (Exception e)
                //{
                //    e.ToString();
                //}

                try
                {
                    foreach (var order in dbOrderHeader.Where(x => x.SalesOrderID > startId && x.SalesOrderID < endId))
                    {
                        MapOrderHeader dto = mapper.Map<MapOrderHeader>(order);
                        lstOrderHeader.Add(dto);

                    }
                }
                catch (Exception e)
                {

                    e.ToString();
                }

            }


            return lstOrderHeader;
        }

        //public List<MapOrderHeader> GetSalesOrderBetween(int startId, int endId)
        //{
        //    var dbOrderHeader = unitOfWork.SalesOrderHeaderRepos.Get();
        //    List<MapOrderHeader> lstOrderHeader = new List<MapOrderHeader>();

        //    if (dbOrderHeader.Any())
        //    {
        //        lstOrderHeader = dbOrderHeader
        //            .Where(x => x.SalesOrderID > startId && x.SalesOrderID < endId)
        //            .Select(x => new MapOrderHeader
        //            {
        //                SalesOrderID = x.SalesOrderID,
        //                SalesOrderNumber = x.SalesOrderNumber,
        //                OrderDate = x.OrderDate,
        //                SubTotal = x.SubTotal,
        //                PurchaseOrderNumber = x.PurchaseOrderNumber
        //            })
        //            .ToList();
        //    }


        //    return lstOrderHeader;
        //}
    }

}
