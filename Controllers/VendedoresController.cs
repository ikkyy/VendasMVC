using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorService;
        private readonly DepartamentoService _departamentoService;

        public VendedoresController(VendedorService vendedorService, DepartamentoService departamentoService)
        {
            _vendedorService = vendedorService;
            _departamentoService = departamentoService;
        }
        public IActionResult Index()
        {
            var lista = _vendedorService.FindAll();
            return View(lista);
        }

        public IActionResult Novo()
        {
            var departamentos = _departamentoService.FindAll();
            var viewModel = new VendedorFormViewModel{Departamentos = departamentos};
            return View(viewModel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken] // Garante a segurança do form.
        public IActionResult Novo(Vendedor vendedor)
        {
            _vendedorService.Inserir(vendedor);
            return RedirectToAction(nameof(Index));
            // nameOf melhora a manutenção do sistema no futuro, caso mude o Index.
        }
    }
}
