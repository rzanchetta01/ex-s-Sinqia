using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exAbstractAutomovel.Veiculos
{
    class SUV : Automovel
    {
        public SUV(int nRodas, string cor, string placa, int nPortas) : base(nRodas, cor, placa, nPortas)
        {

        }

        public override void AbrirPortaMalas()
        {
            Console.WriteLine("Abrindo porta malas da suv");
        }

        public override void AbrirPorta()
        {
            Console.WriteLine("Abrindo portas da suv");
        }

        public override void Descicao()
        {
            Console.WriteLine($"Essa suv tem {nRodas} rodas, é {nPortas} portas, com a cor: {cor} e placa {placa}");
        }

        public override void Desligar()
        {
            Console.WriteLine("SUV desligado");
        }

        public override void Ligar()
        {
            Console.WriteLine("SUV ligando");
        }

        public override void Acelerar()
        {
            Console.WriteLine("SUV acelerando");
        }

        public override void Frear()
        {
            Console.WriteLine("SUV freando");
        }
    }
}
