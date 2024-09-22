using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeAtivosTecnologicos
{
    public class Notebook : Dispositivos
    {
        public String Processador { get; set; }
        public String Memoria { get; set; }
        public String Armazenamento { get; set; }
        public String SistemaOperacional { get; set; }

        public Notebook(int id, String nome, String modelo, int anoFabricacao, String tipo, String processador, String memoria, String armazenamento, String sistemaOperacional) : base (id, nome, modelo, anoFabricacao, tipo)
        {
            this.Processador = processador;
            this.Memoria = memoria;
            this.Armazenamento = armazenamento;
            this.SistemaOperacional = sistemaOperacional;
        }

        public void ExibirInfoNotebook()
        {
            ExibirInfo();
            Console.WriteLine($"Processador: {this.Processador}");
            Console.WriteLine($"Memória: {this.Memoria}");
            Console.WriteLine($"Armazenamento: {this.Armazenamento}");
            Console.WriteLine($"Sistema Operacional: {this.SistemaOperacional}");
        }
    }
}