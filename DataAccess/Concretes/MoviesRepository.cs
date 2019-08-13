using DataAccess.Abstractions;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concretes
{
    public class MoviesRepository : GenericRepository<Movies>,  IMoviesRepository
    {        
        public MoviesRepository(IMDBDbContext dbContext) :base(dbContext)
        {
               
        }
    }
}
