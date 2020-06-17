using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

/// Qnd um seeding service é criado, ele vai receber automaticamente uma instancia do context.
namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;
        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Departamento.Any() || _context.Vendedor.Any() || _context.VendasRecord.Any())
            {
                return; // Banco de dados já foi populado.
            }
            Departamento d1 = new Departamento(1, "Computadores");
            Departamento d2 = new Departamento(2, "Eletrônicos");
            Departamento d3 = new Departamento(3, "Moda");
            Departamento d4 = new Departamento(4, "Livros");

            Vendedor s1 = new Vendedor(1, "Reinaldo Borin", "reinaldo@email.com.br", new DateTime(1984, 4, 21), 1000, d1);
            Vendedor s2 = new Vendedor(2, "Luana Borin", "luana@email.com.br", new DateTime(1984, 4, 21), 1200, d2);
            Vendedor s3 = new Vendedor(3, "Robson Borin", "robson@email.com.br", new DateTime(1984, 4, 21), 1600, d3);
            Vendedor s4 = new Vendedor(4, "Raquel Borin", "raquel@email.com.br", new DateTime(1984, 4, 21), 2000, d4);

            VendasRecord r1 = new VendasRecord(1, new DateTime(2018, 09, 25), 11000.0, VendasStatus.Efetuada, s1);
            VendasRecord r2 = new VendasRecord(2, new DateTime(2018, 09, 4), 7000.0, VendasStatus.Efetuada, s2);
            VendasRecord r3 = new VendasRecord(3, new DateTime(2018, 09, 13), 4000.0, VendasStatus.Cancelada, s4);
            VendasRecord r4 = new VendasRecord(4, new DateTime(2018, 09, 1), 8000.0, VendasStatus.Efetuada, s1);
            VendasRecord r5 = new VendasRecord(5, new DateTime(2018, 09, 21), 3000.0, VendasStatus.Efetuada, s3);
            VendasRecord r6 = new VendasRecord(6, new DateTime(2018, 09, 15), 2000.0, VendasStatus.Efetuada, s1);
            VendasRecord r7 = new VendasRecord(7, new DateTime(2018, 09, 28), 13000.0, VendasStatus.Efetuada, s2);
            VendasRecord r8 = new VendasRecord(8, new DateTime(2018, 09, 11), 4000.0, VendasStatus.Efetuada, s4);
            VendasRecord r9 = new VendasRecord(9, new DateTime(2018, 09, 14), 11000.0, VendasStatus.Pendente, s1);
            VendasRecord r10 = new VendasRecord(10, new DateTime(2018, 09, 7), 9000.0, VendasStatus.Efetuada, s1);
            VendasRecord r11 = new VendasRecord(11, new DateTime(2018, 09, 13), 6000.0, VendasStatus.Efetuada, s2);
            VendasRecord r12 = new VendasRecord(12, new DateTime(2018, 09, 25), 7000.0, VendasStatus.Pendente, s3);
            VendasRecord r13 = new VendasRecord(13, new DateTime(2018, 09, 29), 10000.0, VendasStatus.Efetuada, s4);
            VendasRecord r14 = new VendasRecord(14, new DateTime(2018, 09, 4), 3000.0, VendasStatus.Efetuada, s2);
            VendasRecord r15 = new VendasRecord(15, new DateTime(2018, 09, 12), 4000.0, VendasStatus.Efetuada, s1);
            VendasRecord r16 = new VendasRecord(16, new DateTime(2018, 10, 5), 2000.0, VendasStatus.Efetuada, s4);
            VendasRecord r17 = new VendasRecord(17, new DateTime(2018, 10, 1), 12000.0, VendasStatus.Efetuada, s1);
            VendasRecord r18 = new VendasRecord(18, new DateTime(2018, 10, 24), 6000.0, VendasStatus.Efetuada, s3);
            VendasRecord r19 = new VendasRecord(19, new DateTime(2018, 10, 22), 8000.0, VendasStatus.Efetuada, s2);
            VendasRecord r20 = new VendasRecord(20, new DateTime(2018, 10, 15), 8000.0, VendasStatus.Efetuada, s1);
            VendasRecord r21 = new VendasRecord(21, new DateTime(2018, 10, 17), 9000.0, VendasStatus.Efetuada, s2);
            VendasRecord r22 = new VendasRecord(22, new DateTime(2018, 10, 24), 4000.0, VendasStatus.Efetuada, s4);
            VendasRecord r23 = new VendasRecord(23, new DateTime(2018, 10, 19), 11000.0, VendasStatus.Cancelada, s2);
            VendasRecord r24 = new VendasRecord(24, new DateTime(2018, 10, 12), 8000.0, VendasStatus.Efetuada, s2);
            VendasRecord r25 = new VendasRecord(25, new DateTime(2018, 10, 31), 7000.0, VendasStatus.Efetuada, s3);
            VendasRecord r26 = new VendasRecord(26, new DateTime(2018, 10, 6), 5000.0, VendasStatus.Efetuada, s4);
            VendasRecord r27 = new VendasRecord(27, new DateTime(2018, 10, 13), 9000.0, VendasStatus.Pendente, s1);
            VendasRecord r28 = new VendasRecord(28, new DateTime(2018, 10, 7), 4000.0, VendasStatus.Efetuada, s3);
            VendasRecord r29 = new VendasRecord(29, new DateTime(2018, 10, 23), 12000.0, VendasStatus.Efetuada, s2);
            VendasRecord r30 = new VendasRecord(30, new DateTime(2018, 10, 12), 5000.0, VendasStatus.Efetuada, s2);

            _context.Departamento.AddRange(d1, d2, d3, d4);

            _context.Vendedor.AddRange(s1, s2, s3, s4);

            _context.VendasRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();

        }
    }
}
