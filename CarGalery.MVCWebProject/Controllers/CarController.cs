using CarGalery.Business.Abstract;
using CarGalery.Business.CrossCuttingConcerns.DependencyResolvers.Ninject;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarGalery.MVCWebProject.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            var carService = InstanceFactory.Get<ICarService>();
            var list = carService.GetAll();
            return View(list);
        }
    }
}
