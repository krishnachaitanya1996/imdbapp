using AppService.Abstractions;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Concretes
{
    public class ProducerService : IProducerService
    {
        private readonly IUnitOfWork unitOfWork;
        public ProducerService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public int AddProducer(Producer producer)
        {
            return unitOfWork.producerRepository.Add(producer);
        }
        public IEnumerable<Producer> GetAll()
        {
            return unitOfWork.producerRepository.GetAll();
        }
    }
}
