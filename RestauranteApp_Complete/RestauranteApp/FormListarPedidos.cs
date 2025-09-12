using System;
using System.Text;
using System.Windows.Forms;
using RestauranteApp.Models;

namespace RestauranteApp
{
    public partial class FormListarPedidos : Form
    {
        private Restaurante restaurante;
        public FormListarPedidos(Restaurante r)
        {
            InitializeComponent();
            restaurante = r;
            CarregarLista();
        }

        private void CarregarLista()
        {
            var sb = new StringBuilder();
            if (restaurante.Pedidos.Count == 0) sb.AppendLine("Nenhum pedido no dia.");
            foreach (var p in restaurante.Pedidos)
            {
                sb.AppendLine($"Pedido {p.Id} - Cliente: {p.Cliente} - Total: R$ {p.CalcularTotal():F2}");
            }
            sb.AppendLine("\nSoma geral do dia: R$ " + restaurante.SomaGeral().ToString("F2"));
            txtLista.Text = sb.ToString();
        }
    }
}
