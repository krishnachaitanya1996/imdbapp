using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppService.Abstractions;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace imdbapp.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducerService producerService;
        public ProducersController(IProducerService producerService)
        {
            this.producerService = producerService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddProducer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProducer(Producer producer)
        {
            if (ModelState.IsValid)
            {
                var status = producerService.AddProducer(producer);
                ViewBag.SuccessMsg = status == 1 ? "movie created successfully" : "unable to process at this time .. Sorry....";
            }
            return View();
        }

        public IActionResult GetAll()
        {
            var res = producerService.GetAll();
            
            return View(res);
        }

    }
}