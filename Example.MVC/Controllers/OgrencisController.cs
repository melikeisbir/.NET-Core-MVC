using Example.MVC.Core.Entities;
using Example.MVC.Data.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Example.MVC.Controllers
{
    public class OgrencisController : Controller
    {

        private readonly ILogger<OgrencisController> _logger;
        private readonly ExampleMVCDbContext _exampleMVCDbContext;
        public OgrencisController(
            ILogger<OgrencisController> logger,
            ExampleMVCDbContext exampleMVCDbContext
            )
        {
            _logger = logger;
            _exampleMVCDbContext = exampleMVCDbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {

            var datas = _exampleMVCDbContext.Ogrencilers.Select(x => new Ogrenciler
            {
                Id = x.Id,
                Ad = x.Ad,
                Soyad = x.Soyad,
                BolumId = x.BolumId
            }).ToList();
            return View(datas);

           
            //    ViewBag.ogrenciler = _exampleMVCDbContext.Ogrencilers.ToList();
            //return View();
            
        }

        [HttpPost]
        public async Task<IActionResult> Index(Ogrenciler ogrenciekle)
        {
            var ogrenci = _exampleMVCDbContext.Ogrencilers
                .Where(x => x.Ad == ogrenciekle.Ad && x.Soyad == ogrenciekle.Soyad)
                .FirstOrDefault();
            if (ogrenci != null)
                return RedirectToAction("Index", "Ogrencis");

            await _exampleMVCDbContext.AddAsync(ogrenciekle);
            await _exampleMVCDbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Ogrencis");
        }

        public async Task<IActionResult> ogrencikaydisil(int Id)
        {
            var silinecekkisi = await _exampleMVCDbContext.Ogrencilers.FindAsync(Id);
            _exampleMVCDbContext.Remove(silinecekkisi);
            await _exampleMVCDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


            //IActionResult result;
            //if (true)
            //{
            //    return RedirectToAction("Index", "Ogrencis");

            //}
            //else
            //{
            //    return View("Index", "Home");
            //}
            //    var result = await _exampleMVCDbContext.SaveChangesAsync());
            //    if (result.Succeeded)
            //    {
            //        return RedirectToAction("Index","Ogrencis");
            //    }
            //    else
            //    {
            //        return RedirectToAction("Index", "Ogrencis");
            //    }
            //}
        


        [HttpGet]
        public IActionResult ogrencikaydiguncelle(int Id)
        {
            var guncellenecekkisi = _exampleMVCDbContext.Ogrencilers.Find(Id);
            return View(guncellenecekkisi);

        }
     
     
        [HttpPost]
        public IActionResult ogrencikaydiguncelle(Ogrenciler ogrenciler)
        {
            _exampleMVCDbContext.Update(ogrenciler);
            _exampleMVCDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));

        }



    }
}
