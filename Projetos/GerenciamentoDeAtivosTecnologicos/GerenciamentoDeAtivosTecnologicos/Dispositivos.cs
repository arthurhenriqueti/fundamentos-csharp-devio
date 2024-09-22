using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeAtivosTecnologicos
{
    public class Dispositivos
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public String Tipo { get; set; }

        public Dispositivos(int id, String nome, String modelo, int anoFabricacao, String tipo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Modelo = modelo;
            this.AnoFabricacao = anoFabricacao;
            this.Tipo = tipo;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Id: {this.Id}");
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Modelo: {this.Modelo}");
            Console.WriteLine($"Ano de Fabricação: {this.AnoFabricacao}");
            Console.WriteLine($"Tipo: {this.Tipo}");
        }
    }
}