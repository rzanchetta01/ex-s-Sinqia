using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exAbstractAutomovel.Veiculos
{
    class Sedan : Automovel
    {

        public Sedan()
        {
        }

        public override void Desligar()
        {
            Console.WriteLine("Sedan desligado");
        }

        public override void Ligar()
        {
            Console.WriteLine("Sedan ligando");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Sedan acelerando");
        }

        public override void Frear()
        {
            Console.WriteLine("Sedan freando");
        }
    }
}
