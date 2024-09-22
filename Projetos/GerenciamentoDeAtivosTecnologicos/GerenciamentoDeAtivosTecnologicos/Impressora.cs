using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeAtivosTecnologicos
{
    public class Impressora : Dispositivos
    {
        public String Funcoes { get; set; }
        public String Conexoes { get; set; }

        public Impressora(int id, String nome, String modelo, int anoFabricacao, String tipo, String funcoes, String conexoes) : base (id, nome, modelo, anoFabricacao, tipo)
        {
            this.Funcoes = funcoes;
            this.Conexoes = conexoes;
        }

        public void ExibirInfoImpressora()
        {
            ExibirInfo();
            Console.WriteLine($"Funções: {this.Funcoes}");
            Console.WriteLine($"Conexões: {this.Conexoes}");
        }
    }
}