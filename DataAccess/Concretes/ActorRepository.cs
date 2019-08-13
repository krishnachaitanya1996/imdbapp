using DataAccess.Abstractions;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concretes
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(IMDBDbContext dbContext) : base(dbContext)
        {

        }
    }
}
