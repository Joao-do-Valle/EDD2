namespace RestauranteApp
{
    partial class FormCancelarPedido
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPedidoId;
        private System.Windows.Forms.Button btnCancelar;

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
            this.Text = "Cancelar Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Width = 360;
            this.Height = 200;

            var lbl = new System.Windows.Forms.Label() { Left = 20, Top = 20, Width = 200, Text = "ID do Pedido:" };
            this.Controls.Add(lbl);
            txtPedidoId = new System.Windows.Forms.TextBox() { Left = 20, Top = 45, Width = 120, Name = "txtPedidoId" };
            this.Controls.Add(txtPedidoId);

            btnCancelar = new System.Windows.Forms.Button() { Left = 160, Top = 43, Width = 120, Text = "Cancelar Pedido", Name = "btnCancelar" };
            btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.Controls.Add(btnCancelar);
        }
    }
}
