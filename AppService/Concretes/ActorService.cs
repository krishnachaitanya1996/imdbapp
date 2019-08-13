using AppService.Abstractions;
using DataAccess;
using DataAccess.Abstractions;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Concretes
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository actorRepository;
        private readonly IUnitOfWork _unitOfWork;
        public ActorService(IUnitOfWork unitOfWork,IActorRepository actorRepository)
        {
            this.actorRepository = actorRepository;
            _unitOfWork = unitOfWork;
        }
        public int AddActor(Actor actor)
        {
            return _unitOfWork.actorRepository.Add(actor);
        }
        public IEnumerable<Actor> GetAll()
        {
            return _unitOfWork.actorRepository.GetAll();
        }
    }
}
