using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LocalesController : Controller
    {
        public IActionResult Index()
        {
            using (VestimentasDBContext context = new VestimentasDBContext())
            {
                return View(context.Locals.ToList());
            }
        }

        public IActionResult Alta()
        {
            using (VestimentasDBContext context = new VestimentasDBContext())
            {
                Local l = new Local();
                l.Direccion = "Av Siempreviva 123";
                l.Nombre = "Venta de ropa M. Simpson";
                context.Locals.Add(l);

                context.SaveChanges();
            }
            return Redirect("/locales");
        }
    }
}
