using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Repositories;

namespace UnitOfWorkPattern.Infr.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        protected MyContext Context { get; set; }

        public UnitOfWork(MyContext Context)
        {
            this.Context = Context;
        }

        // Your repositories here
        // public IClienteRepository Clientes { get { return new ClienteRepository(this.Context); } }

        public void SaveChanges()
        {
            this.Context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Context.Dispose();
            }
        }

    }
}
