using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Servicios;

namespace WebApplication1.Controllers
{
    public class LocalesController : Controller
    {

        private ILocalServicio _localServicio;
        public LocalesController()
        {
            VestimentasDBContext dbContext = new VestimentasDBContext();
            _localServicio = new LocalServicio(dbContext);
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
            _localServicio.Alta(local);
            return Redirect("/locales");
        }

        public IActionResult Modificar(int id)
        {
            Local local = _localServicio.ObtenerPorId(id);
            return View(local);
        }

        [HttpPost]
        public IActionResult Modificar(Local local)
        {
            _localServicio.Modificar(local);
            return Redirect("/locales");
        }

        public IActionResult Borrar(int id)
        {
            Local local = _localServicio.ObtenerPorId(id);
            _localServicio.Borrar(local);
            return Redirect("/locales");
        }

    }
}
