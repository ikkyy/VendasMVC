using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNET.Models;

namespace ASPNET.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> lista = new List<Departamento>();
            lista.Add(new Departamento {Id = 1, Nome = "Eletônicos"});
            lista.Add(new Departamento {Id = 2, Nome = "Moda"});

            return View(lista);
        }
    }
}
