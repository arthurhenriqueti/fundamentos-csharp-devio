using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros
{
    public class Locadora
    {
        List<Carro> carros = new List<Carro>();

        public void AdicionarCarro(Carro carro)
        {
            carros.Add(carro);
        }

        public void ExibirCarros()
        {
            foreach (Carro item in carros)
            {
                item.ExibirDetalhes();
            }
        }

        public void AtualizarCarro(int indice, Carro carro)
        {
            carros[indice] = carro;
        }

        public void DeletarCarro(int indice)
        {
            carros.RemoveAt(indice);
        }
    }
}