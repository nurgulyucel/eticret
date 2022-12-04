using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eTicaretMvc.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        KullaniciManager km = new KullaniciManager(new EfKullaniciDal());
        [HttpGet]
        public IActionResult GetAll()
        {
            var studentvalues = km.GetAll();
            return View(studentvalues);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(KullaniciController student)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(KullaniciController student)
        {
            return View();
        } 

    }
}