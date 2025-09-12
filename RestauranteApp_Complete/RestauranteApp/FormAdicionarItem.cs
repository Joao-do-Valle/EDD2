using System;
using System.Windows.Forms;
using RestauranteApp.Models;

namespace RestauranteApp
{
    public partial class FormAdicionarItem : Form
    {
        private Restaurante restaurante;
        public FormAdicionarItem(Restaurante r)
        {
            InitializeComponent();
            restaurante = r;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPedidoId.Text, out int id)) { MessageBox.Show("ID inválido"); return; }
            var p = restaurante.BuscarPedidoPorId(id);
            if (p == null) { MessageBox.Show("Pedido não encontrado"); return; }
            lblPedido.Text = $"Pedido {p.Id} - Cliente: {p.Cliente} - Itens: {p.Itens.Count}/10";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPedidoId.Text, out int id)) { MessageBox.Show("ID inválido"); return; }
            var p = restaurante.BuscarPedidoPorId(id);
            if (p == null) { MessageBox.Show("Pedido não encontrado"); return; }

            if (!int.TryParse(txtItemId.Text, out int idItem)) { MessageBox.Show("ID do item inválido"); return; }
            if (!double.TryParse(txtPreco.Text, out double preco)) { MessageBox.Show("Preço inválido"); return; }
            var item = new Models.Item { Id = idItem, Descricao = txtDesc.Text.Trim(), Preco = preco };
            if (p.AdicionarItem(item))
            {
                MessageBox.Show("Item adicionado com sucesso.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível adicionar item. Limite de 10 itens atingido.");
            }
        }
    }
}
