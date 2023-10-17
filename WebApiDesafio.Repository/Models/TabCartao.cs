using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebApiDesafio.Repository.Models
{
    public class tabCartao
    {
        public int id { get; set; }
        public string numero_cartao { get; set; }
        public DateTime data_validade { get; set; }
        public int cvv { get; set; }
        public int conta_corrente { get; set; }
    }
}