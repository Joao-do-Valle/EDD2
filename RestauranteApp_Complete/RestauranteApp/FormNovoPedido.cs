using System;
using System.Windows.Forms;
using RestauranteApp.Models;

namespace RestauranteApp
{
    public partial class FormNovoPedido : Form
    {
        private Restaurante restaurante;
        public FormNovoPedido(Restaurante r)
        {
            InitializeComponent();
            restaurante = r;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string cliente = txtCliente.Text.Trim();
            if (string.IsNullOrEmpty(cliente))
            {
                MessageBox.Show("Informe o nome do cliente.");
                return;
            }
            var pedido = new Pedido { Cliente = cliente };
            if (restaurante.NovoPedido(pedido))
            {
                MessageBox.Show($"Pedido criado. ID: {pedido.Id}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível criar pedido. Limite diário atingido (50).");
            }
        }
    }
}
