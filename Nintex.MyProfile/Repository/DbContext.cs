using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Nintex.MyProfile.Data;

namespace Nintex.MyProfile.Repository
{
    public class DbContext : NintextProfile, IDbContext
    {
        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}