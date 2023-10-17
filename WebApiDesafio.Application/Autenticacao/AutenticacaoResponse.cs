using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiDesafio.Application.Autenticacao
{
    public class AutenticacaoResponse
    {
        public string Token { get; set; }

        public int UsuarioId { get; set; }
    }
}
