using JRShop.Dominio.Entidades;
using JRShop.Dominio.Interfaces;
using JRShop.Infra.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace JRShop.Infra.Repositorios
{
    public class RepositorioUsuario : RepositorioBase<Usuario>, IUsuario
    {
        public RepositorioUsuario(Contexto contexto) : base(contexto)
        {

        }

        public bool ObterUsuarioPeloNome(string email, string senha)
        {
            var senhaEncriptada = Encriptar(senha);
            var rest = DbSet.Where(x => x.Email == email && x.Senha == senhaEncriptada).FirstOrDefault();
            if (rest != null)
            {
                return true;
            }
            return false;
        }

        public string Encriptar(string senha)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(senha));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

            senha = strBuilder.ToString();
            return senha;
        }
    }
}
