using Example.MVC.Core.Entities;
using Example.MVC.Data.Context;
using Microsoft.AspNetCore.Mvc;

namespace Example.MVC.Controllers
{
    public class BolumsController : Controller
    {
        private readonly ILogger<BolumsController> _logger;
        private readonly ExampleMVCDbContext _exampleMVCDbContext;
        public BolumsController(
            ILogger<BolumsController> logger,
            ExampleMVCDbContext exampleMVCDbContext
            )
        {
            _logger = logger;
            _exampleMVCDbContext = exampleMVCDbContext;
        }
        public IActionResult Index()
        {
            var datas = _exampleMVCDbContext.Bolumlers.Select(x => new Bolumler
            {
                Id = x.Id,
                BolumAdi = x.BolumAdi
            }).ToList();
            return View(datas);
        }
    }
}
