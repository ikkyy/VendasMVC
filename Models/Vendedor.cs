using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} obrigatório.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Quantidade de caracteres do {0} precisa ter entre {2} e {1}.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} obrigatório.")]
        [EmailAddress(ErrorMessage = "Digite um e-mail válido.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} obrigatório.")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} deve ser entre {1} e {2}.")]
        [Display(Name = "Salário Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double SalarioBase { get; set; }

        [Required(ErrorMessage = "{0} obrigatório.")]
        [Display(Name = "Data de Aniversário")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        public Departamento Departamento { get; set; }

        [Display(Name = "Departamento")]
        public int DepartamentoId { get; set; }

        public ICollection<VendasRecord> Vendas { get; set; } = new List<VendasRecord>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionaVendas(VendasRecord sr)
        {
            Vendas.Add(sr);
        }
        public void RemoveVendas(VendasRecord sr)
        {
            Vendas.Remove(sr);
        }
        public double TotalVendas(DateTime inicio, DateTime final)
        {
            return Vendas.Where(sr => sr.Data >= inicio && sr.Data <= final).Sum(sr => sr.Quantidade);
        }
    }
}
