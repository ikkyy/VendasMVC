using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Models;
using SalesWebMvc.Data;

namespace SalesWebMvc.Services
{
    public class VendasRecordService
    {
        private readonly SalesWebMvcContext _context;

        public VendasRecordService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<VendasRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.VendasRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }
            return await result
            .Include(x => x.Vendedor)
            .Include(x => x.Vendedor.Departamento)
            .OrderByDescending(x => x.Data)
            .ToListAsync();
            // Metodos acima faz o Join do MySQL
        }
        public async Task<List<IGrouping<Departamento, VendasRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.VendasRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }
            return await result
            .Include(x => x.Vendedor)
            .Include(x => x.Vendedor.Departamento)
            .OrderByDescending(x => x.Data)
            .GroupBy(x=> x.Vendedor.Departamento)
            .ToListAsync();
            // Metodos acima faz o Join do MySQL
        }
    }
}
