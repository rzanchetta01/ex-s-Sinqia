using exAbstractAutomovel.Veiculos.InterfaceVeiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exAbstractAutomovel.Veiculos
{
    public abstract class Automovel : ILigar, IDesligar
    {
        public virtual void Acelerar()
        {
            Console.WriteLine("Carro acelerando");
        }

        public virtual void Frear()
        {
            Console.WriteLine("Carro freando");
        }

        public abstract void Desligar(); 
        public abstract void Ligar();
    }
}
