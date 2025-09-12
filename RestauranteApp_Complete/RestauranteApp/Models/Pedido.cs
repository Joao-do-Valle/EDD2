using System;
using System.Collections.Generic;
using System.Linq;

namespace RestauranteApp.Models
{
    [Serializable]
    public class Pedido
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public List<Item> Itens { get; set; }

        public Pedido()
        {
            Itens = new List<Item>();
        }

        public bool AdicionarItem(Item item)
        {
            if (Itens.Count < 10)
            {
                Itens.Add(item);
                return true;
            }
            return false;
        }

        public bool RemoverItem(int idItem)
        {
            var item = Itens.FirstOrDefault(i => i.Id == idItem);
            if (item != null)
            {
                Itens.Remove(item);
                return true;
            }
            return false;
        }

        public double CalcularTotal()
        {
            return Itens.Sum(i => i.Preco);
        }

        public string DadosDoPedido()
        {
            var s = $"Pedido {Id} - Cliente: {Cliente}\r\n";
            if (Itens.Count == 0) s += "  (sem itens)\r\n";
            foreach (var it in Itens)
                s += "  " + it.ToString() + "\r\n";
            s += $"Total: R$ {CalcularTotal():F2}\r\n";
            return s;
        }
    }
}
