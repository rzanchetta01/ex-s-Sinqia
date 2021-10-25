using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exAbstractAutomovel.Veiculos
{
    class Esportivo : Automovel
    {   

        public Esportivo()
        {

        }

        public override void Desligar()
        {
            Console.WriteLine("Esportivo desligado");
        }

        public override void Ligar()
        {
            Console.WriteLine("Esportivo ligando");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Esportivo acelerando");
        }

        public override void Frear()
        {
            Console.WriteLine("Esportivo freando");
        }
    }
}
