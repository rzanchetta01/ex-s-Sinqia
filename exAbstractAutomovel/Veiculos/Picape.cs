using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exAbstractAutomovel.Veiculos
{
    class Picape : Automovel
    {

        public Picape()
        {
        }


        public override void Desligar()
        {
            Console.WriteLine("Picape desligado");
        }

        public override void Ligar()
        {
            Console.WriteLine("Picape ligando");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Picape acelerando");
        }

        public override void Frear()
        {
            Console.WriteLine("Picape freando");
        }
    }
}
