using JRShop.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace JRShop.Dominio.Interfaces
{
    public interface IUsuario : IRepositorio<Usuario>
    {

        public bool ObterUsuarioPeloNome(string email, string senha);
    }
}
