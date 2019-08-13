using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AppService.Abstractions;
using Entities;
using imdbapp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace imdbapp.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService moviesService;
        private readonly IActorService actorService;
        private readonly IProducerService producerService;
        public MoviesController(IMoviesService moviesService,IActorService actorService, IProducerService producerService)
        {
            this.moviesService = moviesService;
            this.actorService = actorService;
            this.producerService = producerService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddMovie()
        {
            var actors = actorService.GetAll();
            var producers = producerService.GetAll();
            var actorslist = new List<SelectListItem>();
            var producerslist = new List<SelectListItem>();
            foreach (var a in actors)
            {
                actorslist.Add(new SelectListItem { Text = a.name , Value = a.actorid.ToString()});
            }
            foreach (var a in producers)
            {
                producerslist.Add(new SelectListItem { Text = a.name, Value = a.producerid.ToString() });
            }
            ViewBag.actors = actorslist;
            ViewBag.producers = producerslist;
            return View();
        }
        [HttpPost]
        public IActionResult AddMovie(ViewMovies movies)
        {
            
            {
                var sPath = "C:/Users/m1043011/Pictures/Screenshots/Screenshot (47).png";
                //Open FileStream to read file
                FileInfo fInfo = new FileInfo(sPath);
                FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
                long numBytes = fInfo.Length;
                //Use BinaryReader to read file stream into byte array.
                BinaryReader br = new BinaryReader(fStream);
                movies.poster = br.ReadBytes((int)numBytes);
                int status =0;
                foreach (var item in movies.Actors)
                {
                    var movie = new Movies { actorid = int.Parse(item.Value), plot = movies.plot, poster = movies.poster, producerid = movies.producerid, yearofrelease = movies.yearofrelease };
                    status = moviesService.AddMovie(movie);
                }
                ViewBag.SuccessMsg = status == 1 ? "movie created successfully" : "unable to process at this time .. Sorry....";
            }
            return RedirectToAction("AddMovie");
        }
        public IActionResult GetAll()
        {
            var res = moviesService.GetAll();
            var actors = actorService.GetAll();
            var producers = producerService.GetAll();
           
            ViewBag.actors = actors;
            ViewBag.producers = producers;
            return View(res);
        }
    }
}