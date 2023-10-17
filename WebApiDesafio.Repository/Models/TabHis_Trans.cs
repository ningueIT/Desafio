using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiDesafio.Repository.Models
{
    public class tabHis_Trans
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public string status { get; set; }
        public int conta_corrente { get; set; }

    }
}
