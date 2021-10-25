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
            veiculo.Descicao();
            veiculo.Ligar();
            veiculo.Acelerar();
            veiculo.Frear();
            veiculo.Desligar();
            veiculo.AbrirPorta();
            veiculo.AbrirPortaMalas();       
        }

        static void GerarVeiculos(List<Automovel> veiculos)
        {
            veiculos.Add(new Esportivo(4, "prata", "dpj-4001", 2));
            veiculos.Add(new Sedan(4, "preta", "wpj-2332",4));
            veiculos.Add(new SUV(4, "branca", "asp-5000",4));
            veiculos.Add(new Picape(4,"vermelha", "ase-1313",2));
        }
    }
}
