using Example.MVC.Core.Entities;
using Example.MVC.Data.Context;
using Example.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;

namespace Example.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ExampleMVCDbContext _exampleMVCDbContext;
        public HomeController(
            ILogger<HomeController> logger, ExampleMVCDbContext exampleMVCDbContext )
        {
            _logger = logger;
            _exampleMVCDbContext = exampleMVCDbContext;
        }

        public IActionResult Index()
        {
            var datas = _exampleMVCDbContext.Bolumlers.Select(x=> new Bolumler
            {
                Id = x.Id,
                BolumAdi = x.BolumAdi
            }).ToList();
                //.Where(x=> x.Id != 2)
                //.Include(i=>i.Ogrencilers)
                //.OrderByDescending(x=>x.Id)
                //.Take(1)
                //.ToList();
            return View(datas);
        }
    

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}