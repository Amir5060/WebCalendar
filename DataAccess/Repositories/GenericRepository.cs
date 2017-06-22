using Dapper;
using DataAccess.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperExtensions;


namespace DataAccess.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private IConnectionFactory connectionFactory;
        public GenericRepository(IConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }
        public async Task<dynamic> Add(TEntity entity)
        {
            return await connectionFactory.GetConnection.InsertAsync<TEntity>(entity);
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<dynamic> Update(TEntity entity)
        {
            return await connectionFactory.GetConnection.UpdateAsync(entity);
        }

        public TEntity Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return connectionFactory.GetConnection.Query<TEntity>("");            
        }
    }
}
