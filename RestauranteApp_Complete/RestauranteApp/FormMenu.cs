using System;
using System.Windows.Forms;
using RestauranteApp.Models;

namespace RestauranteApp
{
    public partial class FormMenu : Form
    {
        internal Restaurante restaurante;

        public FormMenu()
        {
            InitializeComponent();
            restaurante = new Restaurante();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            using (var f = new FormNovoPedido(restaurante)) f.ShowDialog();
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            using (var f = new FormAdicionarItem(restaurante)) f.ShowDialog();
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            using (var f = new FormRemoverItem(restaurante)) f.ShowDialog();
        }

        private void btnConsultarPedido_Click(object sender, EventArgs e)
        {
            using (var f = new FormConsultarPedido(restaurante)) f.ShowDialog();
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            using (var f = new FormCancelarPedido(restaurante)) f.ShowDialog();
        }

        private void btnListarPedidos_Click(object sender, EventArgs e)
        {
            using (var f = new FormListarPedidos(restaurante)) f.ShowDialog();
        }
    }
}
