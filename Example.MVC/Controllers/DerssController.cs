using Example.MVC.Core.Entities;
using Example.MVC.Data.Context;
using Microsoft.AspNetCore.Mvc;

namespace Example.MVC.Controllers
{
    public class DerssController : Controller
    {
        
        private readonly ILogger<DerssController> _logger;
        private readonly ExampleMVCDbContext _exampleMVCDbContext;
        public DerssController(
            ILogger<DerssController> logger,
            ExampleMVCDbContext exampleMVCDbContext
            )
        {
            _logger = logger;
            _exampleMVCDbContext = exampleMVCDbContext;
        }
        public IActionResult Index()
        {
            var datas = _exampleMVCDbContext.Derslers.Select(x => new Dersler
            {
                Id = x.Id,
                DersAdi = x.DersAdi
            }).ToList();
            return View(datas);
        }
    }
}
