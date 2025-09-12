using System;
using System.Windows.Forms;
using RestauranteApp.Models;

namespace RestauranteApp
{
    public partial class FormConsultarPedido : Form
    {
        private Restaurante restaurante;
        public FormConsultarPedido(Restaurante r)
        {
            InitializeComponent();
            restaurante = r;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPedidoId.Text, out int id)) { MessageBox.Show("ID inválido"); return; }
            var p = restaurante.BuscarPedidoPorId(id);
            if (p == null) { MessageBox.Show("Pedido não encontrado"); return; }
            txtResultado.Text = p.DadosDoPedido();
        }
    }
}
