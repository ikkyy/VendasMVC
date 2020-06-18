using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class VendasRecordsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BuscaSimples()
        {
            return View();
        }
        public IActionResult BuscaAgregada()
        {
            return View();
        }
    }
}
