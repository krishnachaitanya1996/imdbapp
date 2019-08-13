using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Abstractions
{
    public interface IActorService
    {
        int AddActor(Actor actor);
        IEnumerable<Actor> GetAll();
    }
}
