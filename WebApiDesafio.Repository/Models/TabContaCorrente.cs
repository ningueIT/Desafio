using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiDesafio.Repository.Models
{
    public class tabContaCorrente
    {
        public int id { get; set; }
        public decimal agencia { get; set; }
        public int conta { get; set; }
        public int usuarioId { get; set; }
    }
}