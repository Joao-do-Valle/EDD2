namespace RestauranteApp
{
    partial class FormNovoPedido
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnCriar;

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
            this.Text = "Criar Novo Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Width = 360;
            this.Height = 200;

            var lbl = new System.Windows.Forms.Label() { Left = 20, Top = 20, Width = 300, Text = "Nome do cliente:" };
            this.Controls.Add(lbl);

            txtCliente = new System.Windows.Forms.TextBox() { Left = 20, Top = 50, Width = 300, Name = "txtCliente" };
            this.Controls.Add(txtCliente);

            btnCriar = new System.Windows.Forms.Button() { Left = 20, Top = 90, Width = 120, Text = "Criar Pedido", Name = "btnCriar" };
            btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            this.Controls.Add(btnCriar);
        }
    }
}
