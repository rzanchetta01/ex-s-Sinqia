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

        protected int nRodas;
        protected string cor;
        protected string placa;
        protected int nPortas;

        public Automovel(int nRodas, string cor, string placa, int nPortas)
        {
            this.nRodas = nRodas;
            this.cor = cor;
            this.placa = placa;
            this.nPortas = nPortas;
        }

        public abstract void AbrirPortaMalas();
        public abstract void AbrirPorta();
        public abstract void Descicao();
        public abstract void Desligar();
        public abstract void Ligar();

        public virtual void Acelerar()
        {
            Console.WriteLine("Carro acelerando");
        }

        public virtual void Frear()
        {
            Console.WriteLine("Carro freando");
        }
    }
}
