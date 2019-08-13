using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Abstractions
{
    public interface IProducerService
    {
        int AddProducer(Producer producer);
        IEnumerable<Producer> GetAll();
    }
}
