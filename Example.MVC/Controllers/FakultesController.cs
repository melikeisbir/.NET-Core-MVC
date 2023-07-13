using Example.MVC.Core.Entities;
using Example.MVC.Data.Context;
using Microsoft.AspNetCore.Mvc;

namespace Example.MVC.Controllers
{
    public class FakultesController : Controller
    {
        private readonly ILogger<FakultesController> _logger;
        private readonly ExampleMVCDbContext _exampleMVCDbContext;
        public FakultesController(
            ILogger<FakultesController> logger,
            ExampleMVCDbContext exampleMVCDbContext
            )
        {
            _logger = logger;
            _exampleMVCDbContext = exampleMVCDbContext;
        }

        public IActionResult Index()
        {
            var datas = _exampleMVCDbContext.Fakultelers.Select(x => new Fakulteler
            {
                Id = x.Id,
                FakulteAdi = x.FakulteAdi
               
            }).ToList();
            return View(datas);
       
        }
    }
}
