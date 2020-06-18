using System;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class VendasRecord
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }
        public double Quantidade { get; set; }
        public VendasStatus Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public VendasRecord()
        {
        }

        public VendasRecord(int id, DateTime data, double quantidade, VendasStatus status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantidade = quantidade;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
