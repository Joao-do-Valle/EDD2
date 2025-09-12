using System;
using System.Collections.Generic;
using System.Linq;

namespace RestauranteApp.Models
{
    [Serializable]
    public class Restaurante
    {
        private int proxPedido;
        public List<Pedido> Pedidos { get; set; }

        public Restaurante()
        {
            proxPedido = 1;
            Pedidos = new List<Pedido>();
        }

        public bool NovoPedido(Pedido pedido)
        {
            if (Pedidos.Count >= 50) return false;
            pedido.Id = proxPedido++;
            Pedidos.Add(pedido);
            return true;
        }

        public Pedido BuscarPedidoPorId(int id)
        {
            return Pedidos.FirstOrDefault(p => p.Id == id);
        }

        public bool CancelarPedido(int id)
        {
            var p = BuscarPedidoPorId(id);
            if (p == null) return false;
            Pedidos.Remove(p);
            return true;
        }

        public double SomaGeral()
        {
            return Pedidos.Sum(p => p.CalcularTotal());
        }
    }
}
