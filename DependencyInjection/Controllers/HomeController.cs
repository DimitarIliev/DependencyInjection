using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
using DependencyInjection.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.Controllers
{
    public class HomeController: Controller
    {
        public IRepository repository;
        //public ProductTotalizer totalizer;

        public HomeController(IRepository repo)//, ProductTotalizer total)
        {
            repository = repo;
            //totalizer = total;
        }

        public ViewResult Index([FromServices] ProductTotalizer totalizer)
        {
            //IRepository repo = HttpContext.RequestServices.GetService<IRepository>();
            ViewBag.HomeController = repository.ToString();
            ViewBag.Totalizer = totalizer.Repository.ToString();
            return View(repository.Products);
        }
    }
}
