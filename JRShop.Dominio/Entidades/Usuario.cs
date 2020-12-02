using System;
using System.Collections.Generic;
using System.Text;

namespace JRShop.Dominio.Entidades
{
    public class Usuario : Entity
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
