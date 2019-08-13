using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Abstractions
{
    public interface IMoviesService
    {
        int AddMovie(Movies movie);
        IEnumerable<Movies> GetAll();
    }
}
