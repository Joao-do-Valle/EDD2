using System;
using System.Windows.Forms;
using RestauranteApp.Models;

namespace RestauranteApp
{
    public partial class FormRemoverItem : Form
    {
        private Restaurante restaurante;
        public FormRemoverItem(Restaurante r)
        {
            InitializeComponent();
            restaurante = r;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPedidoId.Text, out int idPedido)) { MessageBox.Show("ID pedido inválido"); return; }
            var p = restaurante.BuscarPedidoPorId(idPedido);
            if (p == null) { MessageBox.Show("Pedido não encontrado"); return; }
            if (!int.TryParse(txtItemId.Text, out int idItem)) { MessageBox.Show("ID item inválido"); return; }
            if (p.RemoverItem(idItem)) MessageBox.Show("Item removido com sucesso."); else MessageBox.Show("Item não encontrado.");
        }
    }
}
