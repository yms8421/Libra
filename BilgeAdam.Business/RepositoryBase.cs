using BilgeAdam.Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Business
{
    public abstract class RepositoryBase : IDisposable
    {
        public RepositoryBase()
        {
            Context = new LibraContext();
        }
        public LibraContext Context { get; set; }

        ~RepositoryBase()
        {
            if (Context != null)
            {
                Context.Dispose();
                Context = null;
            }
        }

        public void Dispose()
        {
            Context.Dispose();
            Context = null;
        }
    }
}
