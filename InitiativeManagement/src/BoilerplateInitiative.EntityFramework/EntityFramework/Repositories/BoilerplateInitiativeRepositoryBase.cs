using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BoilerplateInitiative.EntityFramework.Repositories
{
    public abstract class BoilerplateInitiativeRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<BoilerplateInitiativeDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected BoilerplateInitiativeRepositoryBase(IDbContextProvider<BoilerplateInitiativeDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        //add common methods for all repositories
        public abstract TEntity GetSingleByCondition(Expression<Func<TEntity, bool>> expression, string[] includes = null);

        public abstract IEnumerable<TEntity> GetMulti(Expression<Func<TEntity, bool>> predicate, string[] includes = null);

        public abstract IEnumerable<TEntity> GetMultiPaging(Expression<Func<TEntity, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);

        public abstract bool CheckContains(Expression<Func<TEntity, bool>> predicate);
    }

    public abstract class BoilerplateInitiativeRepositoryBase<TEntity> : BoilerplateInitiativeRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected BoilerplateInitiativeRepositoryBase(IDbContextProvider<BoilerplateInitiativeDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}