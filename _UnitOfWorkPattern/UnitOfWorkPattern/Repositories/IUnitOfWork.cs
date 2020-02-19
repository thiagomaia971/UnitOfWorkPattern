using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkPattern.Repositories
{
    public interface IUnitOfWork
    {
        // All Repositories here
        // IClienteRepository Clientes { get; }

        void SaveChanges();

    }
}
