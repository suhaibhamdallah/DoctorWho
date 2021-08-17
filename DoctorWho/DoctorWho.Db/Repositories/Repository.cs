using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public abstract class Repository<T, VEntity, TId>
        : IRepository<T, VEntity, TId> where T : class
        where VEntity : class,  IModel<TId>
    {
        protected DoctorWhoCoreDbContext context;

        protected Repository(DoctorWhoCoreDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Add new entity to the database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task<T> Create(T entity)
        {
            var entityToCreate = (await context
                .AddAsync(entity))
                .Entity;

            context.SaveChanges();

            return entityToCreate;
        }

        /// <summary>
        /// Delete existence entity from database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual T Delete(T entity)
        {

            var entityToDelete = context
                .Set<T>()
                .Remove(entity)
                .Entity;

            context.SaveChanges();

            return entityToDelete;
        }

        /// <summary>
        /// Update existence entity from database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual T Update(T entity)
        {

            var entityToUpdate = context
                .Set<T>()
                .Update(entity)
                .Entity;

            context.SaveChanges();

            return entityToUpdate;
        }

        /// <summary>
        /// Get entity by id from database table
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual async Task<VEntity> FindById(TId id) 
        {

            return await context
                .Set<VEntity>()
                .FindAsync(id);
        }

        /// <summary>
        /// Return all the entities from database table
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<VEntity>> FindAll()
        {

            return (await context
                .Set<VEntity>()
                .ToListAsync());
        }
    }
}
