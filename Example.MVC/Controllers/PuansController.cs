using Example.MVC.Core.Entities;
using Example.MVC.Data.Context;
using Microsoft.AspNetCore.Mvc;

namespace Example.MVC.Controllers
{
    public class PuansController : Controller
    {
        private readonly ILogger<PuansController> _logger;
        private readonly ExampleMVCDbContext _exampleMVCDbContext;
        public PuansController(
            ILogger<PuansController> logger,
            ExampleMVCDbContext exampleMVCDbContext
            )
        {
            _logger = logger;
            _exampleMVCDbContext = exampleMVCDbContext;
        }
        public IActionResult Index()
        {
            var datas = _exampleMVCDbContext.Notlars.Select(x => new Notlar
            {
                Id = x.Id,
                VizeNotu = x.VizeNotu,
                FinalNotu = x.FinalNotu,
                Ortalama = x.Ortalama,
                DersId = x.DersId,
                OgrenciId = x.OgrenciId
            }).ToList();
            return View(datas);
        }
    }
}
