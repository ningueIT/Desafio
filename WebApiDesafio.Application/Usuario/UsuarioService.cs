using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApiDesafio.Repository;
using WebApiDesafio.Repository.Models;

namespace WebApiDesafio.Application.Usuario
{
    public class UsuarioService
    {
        private readonly CartaoContext _context;
        public UsuarioService(CartaoContext context)
        {
            _context = context;
        }

        public bool InserirUsuario(UsuarioRequest request)
        {
            // tray e catch é um tratamento de erro
            try
            {
                var usuario = new TabUsuario()
                {
                    nome = request.Nome,
                    usuario = request.Usuario,
                    senha = request.Senha
                };
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                //é essa linha que faz com que o banco de dados adicione no banco de dados
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            //O que acontecer aqui vai retonar 2 opçoes true se der certo e se não vai falso.
        }

        public List<TabUsuario> ObeterUsuarios()
        // A tabUsuarios representa o ID, Nome, Usuario ,Senha no banco de dados
        {
            try
            {
                var usuarios = _context.Usuarios.ToList();
                //Aqui e ela vai ate o banco de dados na tabela usuários e / O 'ToList' significa me trás tudo !
                return usuarios;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public TabUsuario ObterUsuario(int id)
        {
            try
            {
                var usuario = _context.Usuarios.FirstOrDefault(x => x.id == id);
                // aqui diz, salva na tabela usuários e prucure algum que tenha esse id ou nada.
                return usuario;
            }
            catch
            {
                return null;
            }
        }



        public bool AtualizarUsuario(int id, UsuarioRequest request)
        {
            try
            {
                var usuarioDb = _context.Usuarios.FirstOrDefault(x => x.id == id);
                //db == database
                if (usuarioDb == null)
                    return false;

                usuarioDb.nome = request.Nome;
                // ele vai pegar no request e colocar no nome no DB
                usuarioDb.senha = request.Senha;
                usuarioDb.usuario = request.Usuario;

                _context.Usuarios.Update(usuarioDb);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoverUsuario(int id)
        {
            try
            {
                var UsarioDb = _context.Usuarios.FirstOrDefault(x => x.id == id);
                // O usuarioDb é banco de dados no usuarios e ele só pode ser o primeiro ou nada 
                if (UsarioDb == null)
                    // se usuarioDb for nulo ele retona um falso
                    return false;

                _context.Usuarios.Remove(UsarioDb);
                //vai no banco de dados e remove o UsarioDb
                _context.SaveChanges();
                // e salva no banco de dados
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ColocarUsuario(UsuarioRequest request)
        {
            try
            {
                var usuario = new TabUsuario()
                {
                    nome = request.Nome,
                    usuario = request.Usuario,
                    senha = request.Senha
                };
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

