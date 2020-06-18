using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class VendasRecordsController : Controller
    {
        private readonly VendasRecordService _vendasRecordService;

        public VendasRecordsController(VendasRecordService vendasRecordService)
        {
            _vendasRecordService = vendasRecordService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> BuscaSimples(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = await _vendasRecordService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }
        public IActionResult BuscaAgregada()
        {
            return View();
        }
    }
}
