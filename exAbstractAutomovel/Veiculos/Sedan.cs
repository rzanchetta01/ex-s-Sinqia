using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exAbstractAutomovel.Veiculos
{
    class Sedan : Automovel
    {

        public Sedan(int nRodas, string cor, string placa, int nPortas) : base(nRodas, cor, placa, nPortas)
        {

        }

        public override void AbrirPortaMalas()
        {
            Console.WriteLine("Abrindo porta malas do sedan");
        }

        public override void AbrirPorta()
        {
            Console.WriteLine("Abrindo portas do sedan");
        }

        public override void Descicao()
        {
            Console.WriteLine($"Esse sedan tem {nRodas} rodas, é {nPortas} portas, com a cor: {cor} e placa {placa}");
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
