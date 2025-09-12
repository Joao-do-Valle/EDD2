namespace RestauranteApp
{
    partial class FormRemoverItem
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPedidoId, txtItemId;
        private System.Windows.Forms.Button btnRemover;

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
            this.Text = "Remover Item do Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Width = 360;
            this.Height = 220;

            var lbl1 = new System.Windows.Forms.Label() { Left = 20, Top = 20, Width = 200, Text = "ID do Pedido:" };
            this.Controls.Add(lbl1);
            txtPedidoId = new System.Windows.Forms.TextBox() { Left = 20, Top = 45, Width = 120, Name = "txtPedidoId" };
            this.Controls.Add(txtPedidoId);

            var lbl2 = new System.Windows.Forms.Label() { Left = 20, Top = 80, Width = 200, Text = "ID do Item:" };
            this.Controls.Add(lbl2);
            txtItemId = new System.Windows.Forms.TextBox() { Left = 20, Top = 105, Width = 120, Name = "txtItemId" };
            this.Controls.Add(txtItemId);

            btnRemover = new System.Windows.Forms.Button() { Left = 160, Top = 100, Width = 120, Text = "Remover", Name = "btnRemover" };
            btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            this.Controls.Add(btnRemover);
        }
    }
}
