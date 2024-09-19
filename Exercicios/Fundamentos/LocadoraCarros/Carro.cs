using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros
{
    public class Carro
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Modelo { get; set; }
        public int AnoFabricacao { get; set; }

        public Carro(int id, string nome, string modelo, int anoFabricacao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Modelo = modelo;
            this.AnoFabricacao = anoFabricacao;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"Id: {this.Id}");
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Modelo: {this.Modelo}");
            Console.WriteLine($"Ano de Fabricação: {this.AnoFabricacao}");
            Console.WriteLine("---------------------");
        }
    }
}