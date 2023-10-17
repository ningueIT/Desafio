using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiDesafio.Repository.Models
{
    public class tabSaldo
    {
        public int id { get; set; }
        public decimal saldo { get; set; }
        public int conta_corrente { get; set; }
    }
}
