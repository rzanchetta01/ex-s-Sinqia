using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exAbstractAutomovel.Veiculos
{
    class Esportivo : Automovel
    {

        public Esportivo(int nRodas, string cor, string placa, int nPortas) : base(nRodas, cor, placa, nPortas)
        {

        }

        public override void AbrirPorta()
        {
            Console.WriteLine("Abrindo portas do esportivo");
        }

        public override void AbrirPortaMalas()
        {
            Console.WriteLine("Abrindo porta malas do esportivo");
        }

        public override void Descicao()
        {
            Console.WriteLine($"Esse esportivo tem {nRodas} rodas, é {nPortas} portas, com a cor: {cor} e placa {placa}");
        }

        public override void Desligar()
        {
            Console.WriteLine("Esportivo desligando");
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