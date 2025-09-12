using System;
using System.Windows.Forms;
using RestauranteApp.Models;

namespace RestauranteApp
{
    public partial class FormCancelarPedido : Form
    {
        private Restaurante restaurante;
        public FormCancelarPedido(Restaurante r)
        {
            InitializeComponent();
            restaurante = r;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPedidoId.Text, out int id)) { MessageBox.Show("ID inválido"); return; }
            if (restaurante.CancelarPedido(id)) MessageBox.Show("Pedido cancelado com sucesso."); else MessageBox.Show("Pedido não encontrado.");
        }
    }
}
