using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Servicios;

namespace WebApplication1.Controllers
{
    public class PrendasController : Controller
    {
        private ILocalServicio _localServicio;
        private IPrendaServicio _prendaServicio;
        private ITipoPrendaServicio _tipoPrendaServicio;
        public PrendasController()
        {
            VestimentasDBContext dbContext = new VestimentasDBContext();
            _localServicio = new LocalServicio(dbContext);
            _prendaServicio = new PrendaServicio(dbContext);
            _tipoPrendaServicio = new TipoPrendaServicio(dbContext);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Alta()
        {
            ViewBag.TodasTipoPrendas = _tipoPrendaServicio.ObtenerTodos();
            return View();
        }


        [HttpPost]
        public IActionResult Alta(Prendum prenda)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.TodasPrendas = _prendaServicio.ObtenerTodos();
                return View(prenda);
            }

            _prendaServicio.Alta(prenda);
            return View(prenda);
        }
    }
}
