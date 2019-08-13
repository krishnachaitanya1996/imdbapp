using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppService.Abstractions;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace imdbapp.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorService actorService;
        public ActorsController(IActorService actorService)
        {
            this.actorService = actorService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddActor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddActor(Actor actor)
        {
            if (ModelState.IsValid)
            {
                var status = actorService.AddActor(actor);
                ViewBag.SuccessMsg = status == 1 ? "actor created successfully" : "unable to process at this time .. Sorry....";              
            }
            return View();
        }
        public IActionResult GetAll()
        {
            var res = actorService.GetAll();

            return View(res);
        }
    }
}