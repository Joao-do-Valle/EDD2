namespace RestauranteApp
{
    partial class FormMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Text = "Sistema de Pedidos - Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Width = 420;
            this.Height = 520;

            var btnNovo = new System.Windows.Forms.Button() { Left = 100, Top = 30, Width = 200, Height = 40, Text = "1 - Criar novo pedido", Name = "btnNovoPedido" };
            btnNovo.Click += new System.EventHandler(this.btnNovoPedido_Click);
            this.Controls.Add(btnNovo);

            var btnAddItem = new System.Windows.Forms.Button() { Left = 100, Top = 90, Width = 200, Height = 40, Text = "2 - Adicionar item ao pedido", Name = "btnAdicionarItem" };
            btnAddItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            this.Controls.Add(btnAddItem);

            var btnRemItem = new System.Windows.Forms.Button() { Left = 100, Top = 150, Width = 200, Height = 40, Text = "3 - Remover item do pedido", Name = "btnRemoverItem" };
            btnRemItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            this.Controls.Add(btnRemItem);

            var btnConsultar = new System.Windows.Forms.Button() { Left = 100, Top = 210, Width = 200, Height = 40, Text = "4 - Consultar pedido", Name = "btnConsultarPedido" };
            btnConsultar.Click += new System.EventHandler(this.btnConsultarPedido_Click);
            this.Controls.Add(btnConsultar);

            var btnCancelar = new System.Windows.Forms.Button() { Left = 100, Top = 270, Width = 200, Height = 40, Text = "5 - Cancelar pedido", Name = "btnCancelarPedido" };
            btnCancelar.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            this.Controls.Add(btnCancelar);

            var btnListar = new System.Windows.Forms.Button() { Left = 100, Top = 330, Width = 200, Height = 40, Text = "6 - Listar todos os pedidos", Name = "btnListarPedidos" };
            btnListar.Click += new System.EventHandler(this.btnListarPedidos_Click);
            this.Controls.Add(btnListar);

            var btnSair = new System.Windows.Forms.Button() { Left = 100, Top = 390, Width = 200, Height = 40, Text = "0 - Sair", Name = "btnSair" };
            btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.Controls.Add(btnSair);
        }
    }
}
