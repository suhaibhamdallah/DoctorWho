﻿using System.Collections.Generic;
using System.Linq;

namespace DoctorWho.Db.Repositories
{
    public abstract class Repository<T, VEntity, TId>
        : IRepository<T, VEntity, TId> where T : class
        where VEntity : class
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
        public virtual T Create(T entity)
        {

            return context
                .Add(entity)
                .Entity;
        }

        /// <summary>
        /// Delete existence entity from database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual T Delete(T entity)
        {

            return context
                .Remove(entity)
                .Entity;
        }

        /// <summary>
        /// Update existence entity from database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual T Update(T entity)
        {

            return context
                .Update(entity)
                .Entity;
        }

        /// <summary>
        /// Get entity by id from database table
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual VEntity FindById(TId id)
        {

            return context
                .Set<VEntity>()
                .Find(id);
        }

        /// <summary>
        /// Return all the entities from database table
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<VEntity> FindAll()
        {
            return context
                .Set<VEntity>()
                .ToList();
        }

        /// <summary>
        /// Save changes that context tracking it to the database
        /// </summary>
        public virtual void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
