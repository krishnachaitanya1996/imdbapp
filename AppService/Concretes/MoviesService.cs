using AppService.Abstractions;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Concretes
{
    public class MoviesService : IMoviesService
    {
        private readonly IUnitOfWork unitOfWork;

        public MoviesService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public int AddMovie(Movies movie)
        {
            return unitOfWork.moviesRepository.Add(movie);
        }
        public IEnumerable<Movies> GetAll()
        {
            return unitOfWork.moviesRepository.GetAll();
        }
    }
}
