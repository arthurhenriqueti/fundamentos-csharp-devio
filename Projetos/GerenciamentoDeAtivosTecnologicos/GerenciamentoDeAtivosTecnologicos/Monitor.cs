using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeAtivosTecnologicos
{
    public class Monitor : Dispositivos
    {
        public String Tamanho { get; set; }
        public String Resolucao { get; set; }
        public String TaxaAtualizacao { get; set; }
        public String Conexoes { get; set; }

        public Monitor(int id, String nome, String modelo, int anoFabricacao, String tipo, String tamanho, String resolucao, String taxaAtualizacao, String conexoes) : base (id, nome, modelo, anoFabricacao, tipo)
        {
            this.Tamanho = tamanho;
            this.Resolucao = resolucao;
            this.TaxaAtualizacao = taxaAtualizacao;
            this.Conexoes = conexoes;
        }

        public void ExibirInfoMonitor()
        {
            ExibirInfo();
            Console.WriteLine($"Tamanho: {this.Tamanho}");
            Console.WriteLine($"Resolução: {this.Resolucao}");
            Console.WriteLine($"Taxa de Atualização: {this.TaxaAtualizacao}");
            Console.WriteLine($"Conexões: {this.Conexoes}");
        }
    }
}