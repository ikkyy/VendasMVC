using System;

namespace SalesWebMvc.Models
{
    public class VendasRecord
    {
        public int Id { get; set; }
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
