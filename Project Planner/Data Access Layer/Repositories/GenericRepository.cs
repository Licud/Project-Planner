/*
    A generic repository pattern that handles the basic CRUD queries to the database.
*/

using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;

namespace Data_Access_Layer.Repositories
{
    class GenericRepository<TEntity> where TEntity : class
    {

        internal ApplicationDbContext context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(ApplicationDbContext _context)
        {
            this.context = _context;
            dbSet = context.Set<TEntity>();
        }

        public virtual TEntity GetRecordById(int id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAllRecords()
        {
            IQueryable<TEntity> query = dbSet;
            return query.ToList();
        }

        public virtual void AddRecord(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual void DeleteRecordById(int id)
        {
            TEntity entityToDelete = this.GetRecordById(id);
            dbSet.Remove(entityToDelete);
        }

        public virtual void DeleteRecordByEntity(TEntity entity)
        {
            dbSet.Remove(entity);
        }

        public virtual void UpdateRecord(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }

    }
}
