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
        void Especie(String especie);
        void Dono(Pessoa dono);
    }
}
