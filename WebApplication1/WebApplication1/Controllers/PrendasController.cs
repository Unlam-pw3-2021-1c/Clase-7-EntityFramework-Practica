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

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.TodasTipoPrendas = _tipoPrendaServicio.ObtenerTodos();
            List<Prendum> prendas = _prendaServicio.ObtenerTodos();

            return View(prendas);
        }

        [HttpPost]
        public IActionResult Index(int idTipoPrenda)
        {
            ViewBag.TodasTipoPrendas = _tipoPrendaServicio.ObtenerTodos();
            ViewBag.IdTipoPrendaSeleccionada = idTipoPrenda;

            List<Prendum> prendas = _prendaServicio.ObtenerTodosPorTipoPrenda(idTipoPrenda);

            return View(prendas);
        }

        [HttpGet]
        public IActionResult Alta()
        {
            ViewBag.TodasTipoPrendas = _tipoPrendaServicio.ObtenerTodos();
            return View();
        }


        [HttpPost]
        public IActionResult Alta(Prendum prenda, string tipoPrendaNueva)
        {
            ViewBag.TodasTipoPrendas = _tipoPrendaServicio.ObtenerTodos();

            if (!string.IsNullOrEmpty(tipoPrendaNueva))
            {
                TipoPrendum tipoPrenda = new TipoPrendum();
                tipoPrenda.Descripcion = tipoPrendaNueva;

                _tipoPrendaServicio.Alta(tipoPrenda);
                prenda.IdTipoPrenda = tipoPrenda.IdTipoPrenda;
            }

            _prendaServicio.Alta(prenda);
            return Redirect("/Prendas/");
        }
    }
}
