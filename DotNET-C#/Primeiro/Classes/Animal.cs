using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro
{
    internal class Animal : IAnimal
    {
        public String Nome { get; set; }
        public String Especie { get; set; }
        public Pessoa Dono { get; set; }

        void IAnimal.Nome(string nome) { this.Nome = nome; }

        void IAnimal.Especie(string nome) { Especie = nome; }

        void IAnimal.Dono(Pessoa nome) { Dono = nome; }

    }
}
