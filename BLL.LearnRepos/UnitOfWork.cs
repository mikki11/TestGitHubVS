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
        private GenericRepository<SalesPerson> userRepository;

        public GenericRepository<SalesPerson> UserRepository
        {
            get
            {
                if (this.userRepository == null)
                    this.userRepository = new GenericRepository<SalesPerson>(context);
                return userRepository;
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
