namespace RestauranteApp
{
    partial class FormConsultarPedido
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPedidoId, txtResultado;
        private System.Windows.Forms.Button btnConsultar;

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
            this.Text = "Consultar Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Width = 520;
            this.Height = 380;

            var lbl = new System.Windows.Forms.Label() { Left = 20, Top = 20, Width = 200, Text = "ID do Pedido:" };
            this.Controls.Add(lbl);
            txtPedidoId = new System.Windows.Forms.TextBox() { Left = 20, Top = 45, Width = 120, Name = "txtPedidoId" };
            this.Controls.Add(txtPedidoId);

            btnConsultar = new System.Windows.Forms.Button() { Left = 160, Top = 43, Width = 120, Text = "Consultar", Name = "btnConsultar" };
            btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            this.Controls.Add(btnConsultar);

            txtResultado = new System.Windows.Forms.TextBox() { Left = 20, Top = 90, Width = 460, Height = 220, Multiline = true, ScrollBars = System.Windows.Forms.ScrollBars.Vertical, ReadOnly = true, Name = "txtResultado" };
            this.Controls.Add(txtResultado);
        }
    }
}
