using System;
using System.Collections.Generic;
using System.Text;

namespace SHAREDCONTEXT
{
    public class EntityBase
    {
        public EntityBase()
        {
            ID = Guid.NewGuid();
        }

        public EntityBase(Guid id, string nome, string sobrenome)
        {
            ID = id;
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public Guid ID { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
    }
}
