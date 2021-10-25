using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exAbstractAutomovel.Veiculos
{
    class Picape : Automovel
    {


        public Picape(int nRodas, string cor, string placa, int nPortas) : base(nRodas, cor, placa, nPortas)
        {

        }

        public override void AbrirPortaMalas()
        {
            Console.WriteLine("Abrindo porta malas da picape");
        }

        public override void AbrirPorta()
        {
            Console.WriteLine("Abrindo portas da picape");
        }

        public override void Descicao()
        {
            Console.WriteLine($"Essa picape tem {nRodas} rodas, é {nPortas} portas, com a cor: {cor} e placa {placa}");
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
