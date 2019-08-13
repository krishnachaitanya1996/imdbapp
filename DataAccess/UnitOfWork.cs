using DataAccess.Abstractions;
using DataAccess.Concretes;
using System;

namespace DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        public IActorRepository actorRepository { get; private set; }
        public IMoviesRepository moviesRepository { get; private set; }
        public IProducerRepository producerRepository { get; private set; }
        public IMDBDbContext dbContext { get; private set; }

        

        public UnitOfWork(IMDBDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.actorRepository = new ActorRepository(dbContext);
            this.moviesRepository = new MoviesRepository(dbContext);
            this.producerRepository = new ProducerRepository(dbContext);
                 
        }
        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
