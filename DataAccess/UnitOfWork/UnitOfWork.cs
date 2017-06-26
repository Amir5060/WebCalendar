using DataAccess.Connection;
using DataAccess.Entiteis;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly GenericRepository<Plan> _planRepository;
        private readonly IConnectionFactory connection;
        private IDbTransaction transaction;

        public UnitOfWork(GenericRepository<Plan> planRepository, IConnectionFactory connection)
        {
            _planRepository = planRepository;
            this.connection = connection;
            transaction = connection.GetConnection.BeginTransaction();
        }

        public GenericRepository<Plan> UPlanRepository {
            get
            {
                return _planRepository;
            }
        }

        public void Complete()
        {
            transaction.Commit();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls



        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UnitOfWork() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
