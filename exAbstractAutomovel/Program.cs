using exAbstractAutomovel.Veiculos;
using System;
using System.Collections.Generic;

namespace exAbstractAutomovel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Automovel> veiculos = new();
            GerarVeiculos(veiculos);

            foreach (var e in veiculos)
            {
                BateriaTestes(e);
                Console.WriteLine("\n\n");
            }
                     
        }
        static void BateriaTestes(Automovel veiculo)
        {
            veiculo.Ligar();
            veiculo.Acelerar();
            veiculo.Frear();
            veiculo.Desligar();
        }

        static void GerarVeiculos(List<Automovel> veiculos)
        {
            veiculos.Add(new Esportivo());
            veiculos.Add(new Sedan());
            veiculos.Add(new SUV());
            veiculos.Add(new Picape());
        }
    }
}
