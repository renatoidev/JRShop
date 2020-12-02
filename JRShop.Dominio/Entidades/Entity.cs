using System;
using System.Collections.Generic;
using System.Text;

namespace JRShop.Dominio.Entidades
{
    public class Entity
    {
        public Entity() => Id = Guid.NewGuid();
        public Guid Id { get; set; }
    }
}
