using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidades.Models;
using Servicios;

namespace WebApplication1.Controllers
{
    public class LocalesController : Controller
    {

        private ILocalServicio _localServicio;
        private IPrendaServicio _prendaServicio;
        public LocalesController()
        {
            VestimentasDBContext dbContext = new VestimentasDBContext();
            _localServicio = new LocalServicio(dbContext);
            _prendaServicio = new PrendaServicio(dbContext);
        }

        public IActionResult Index()
        {
            using (VestimentasDBContext context = new VestimentasDBContext())
            {
                return View(context.Locals.ToList());
            }
        }

        public IActionResult Alta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Alta(Local local)
        {
            if (ModelState.IsValid)
            {
                _localServicio.Alta(local);
                return Redirect("/locales");
            }
            return View(local);
        }

        public IActionResult Modificar(int id)
        {
            ViewBag.TodasPrendas = _prendaServicio.ObtenerTodos();
            Local local = _localServicio.ObtenerPorId(id);
            return View(local);
        }

        [HttpPost]
        public IActionResult Modificar(Local local, int[] prendasLocal)
        {
 if (ModelState.IsValid)
            {
              
            ViewBag.TodasPrendas = _prendaServicio.ObtenerTodos();
            List<Prendum> prendas = _prendaServicio.ObtenerPorIds(prendasLocal);
            _localServicio.Modificar(local, prendas);
            return Redirect("/locales");
 }
            return View(local);
        }

        public IActionResult Borrar(int id)
        {
            Local local = _localServicio.ObtenerPorId(id);
            _localServicio.Borrar(local);
            return Redirect("/locales");
        }

    }
}
