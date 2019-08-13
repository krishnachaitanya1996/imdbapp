using DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        IActorRepository  actorRepository {get;}
        IProducerRepository producerRepository { get; }
        IMoviesRepository moviesRepository { get;}
    }
}
