using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Repositórios;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio
{
    public class Client
    {
        public Client()
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            var usuario = new Usuario();
            usuarioRepositorio.Adicionar(usuario);
        }
    }
}
