using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.AdventureWorks;

namespace BLL.LearnRepos
{
    public class UnitOfWork : IDisposable
    {
        private AdventureWorks2014Entities context = new AdventureWorks2014Entities();
        private GenericRepository<SalesPerson> _salesPRepository;
        private GenericRepository<SalesOrderDetail> _salesOrderDetailRepos;
        private GenericRepository<SalesOrderHeader> _salesOrderHeaderRepos;

        public GenericRepository<SalesPerson> SalesPRepository
        {
            get
            {
                if (this._salesPRepository == null)
                    this._salesPRepository = new GenericRepository<SalesPerson>(context);
                return _salesPRepository;
            }
        }


        public GenericRepository<SalesOrderHeader> SalesOrderHeaderRepos
        {
            get
            {
                if (this._salesOrderHeaderRepos == null)
                    this._salesOrderHeaderRepos = new GenericRepository<SalesOrderHeader>(context);
                return _salesOrderHeaderRepos;
            }
        }

        public GenericRepository<SalesOrderDetail> SalesOrderDetailRepos
        {
            get
            {
                if (this._salesOrderDetailRepos == null)
                    this._salesOrderDetailRepos = new GenericRepository<SalesOrderDetail>(context);
                return _salesOrderDetailRepos;
            }
        }


        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
