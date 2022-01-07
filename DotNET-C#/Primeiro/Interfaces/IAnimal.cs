using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro
{
    public interface IAnimal
    {
        void Nome(String nome);
        void Especie(String nome);
        void Dono(String nome);
    }

    public class Animal : IAnimal
    {
        public String nome { get; set; }
        public String Especie { get; set; }
        public String Dono { get; set; }

        void IAnimal.Nome(string nome) { this.nome = nome; }

        void IAnimal.Especie(string nome) { Especie = nome; }

        void IAnimal.Dono(string nome) { Dono = nome; }
    }
}
