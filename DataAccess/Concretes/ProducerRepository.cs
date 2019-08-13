using DataAccess.Abstractions;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concretes
{
    public class ProducerRepository : GenericRepository<Producer>, IProducerRepository
    {
        public ProducerRepository(IMDBDbContext dbContext):base(dbContext)
        {

        }
    }
}
