using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using WebApiDesafio.Application.Autenticacao;
using WebApiDesafio.Repository;
using WebApiDesafio.Repository.Models;

namespace WebApiPessoa.Application.Autenticacao
{
    public class AutenticacaoService
    {
        private readonly CartaoContext _context;
        public AutenticacaoService(CartaoContext context)
        {
            _context = context;
        }

        public AutenticacaoResponse Autenticar(AutenticacaoRequest request)
        {
            var usuario = _context.Usuarios.FirstOrDefault(x => x.usuario == request.UserName && x.senha == request.Password);
            if (usuario != null)
            {
                var tokenString = GerarTokenJwt(usuario);

                var resposta = new AutenticacaoResponse()
                {
                    Token = tokenString,
                    UsuarioId = usuario.id
                };
                return resposta;
            }
            else
            {
                return null;
            }
        }
        private string GerarTokenJwt(TabUsuario usuario)
        {
            var issuer = "var";
            var audience = "var";
            var key = "f80e8618-ed34-44df-9408-8270d31ed15b";

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]

            {
                new Claim("usuarioId", usuario.id.ToString())
            };
            var token = new JwtSecurityToken(issuer: issuer, claims: claims, audience: audience, expires: DateTime.Now.AddMinutes(180), signingCredentials: credentials);
            var tokenHandler = new JwtSecurityTokenHandler();
            var stringToken = tokenHandler.WriteToken(token);
            return stringToken;
        }
    }
}
