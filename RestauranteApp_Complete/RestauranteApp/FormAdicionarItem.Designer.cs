namespace RestauranteApp
{
    partial class FormAdicionarItem
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPedidoId, txtItemId, txtDesc, txtPreco;
        private System.Windows.Forms.Button btnBuscar, btnAdicionar;
        private System.Windows.Forms.Label lblPedido;

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
            this.Text = "Adicionar Item ao Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Width = 420;
            this.Height = 300;

            var lbl1 = new System.Windows.Forms.Label() { Left = 20, Top = 20, Width = 200, Text = "ID do Pedido:" };
            this.Controls.Add(lbl1);
            txtPedidoId = new System.Windows.Forms.TextBox() { Left = 20, Top = 45, Width = 120, Name = "txtPedidoId" };
            this.Controls.Add(txtPedidoId);
            btnBuscar = new System.Windows.Forms.Button() { Left = 160, Top = 43, Width = 120, Text = "Buscar", Name = "btnBuscar" };
            btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.Controls.Add(btnBuscar);

            lblPedido = new System.Windows.Forms.Label() { Left = 20, Top = 80, Width = 360, Text = "" };
            this.Controls.Add(lblPedido);

            var lbl2 = new System.Windows.Forms.Label() { Left = 20, Top = 110, Width = 200, Text = "ID do Item:" };
            this.Controls.Add(lbl2);
            txtItemId = new System.Windows.Forms.TextBox() { Left = 20, Top = 135, Width = 120, Name = "txtItemId" };
            this.Controls.Add(txtItemId);

            var lbl3 = new System.Windows.Forms.Label() { Left = 160, Top = 110, Width = 200, Text = "Descrição:" };
            this.Controls.Add(lbl3);
            txtDesc = new System.Windows.Forms.TextBox() { Left = 160, Top = 135, Width = 200, Name = "txtDesc" };
            this.Controls.Add(txtDesc);

            var lbl4 = new System.Windows.Forms.Label() { Left = 20, Top = 170, Width = 200, Text = "Preço (use \".\" ex: 12.50):" };
            this.Controls.Add(lbl4);
            txtPreco = new System.Windows.Forms.TextBox() { Left = 20, Top = 195, Width = 120, Name = "txtPreco" };
            this.Controls.Add(txtPreco);

            btnAdicionar = new System.Windows.Forms.Button() { Left = 160, Top = 190, Width = 120, Text = "Adicionar", Name = "btnAdicionar" };
            btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            this.Controls.Add(btnAdicionar);
        }
    }
}
