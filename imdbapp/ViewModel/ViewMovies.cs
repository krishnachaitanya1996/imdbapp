using Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace imdbapp.ViewModel
{
    public class ViewMovies : Movies
    {
        public List<SelectListItem> Actors { get; set; }
    }
}
