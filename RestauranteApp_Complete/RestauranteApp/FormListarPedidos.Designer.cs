namespace RestauranteApp
{
    partial class FormListarPedidos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtLista;

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
            this.Text = "Listar Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Width = 520;
            this.Height = 420;

            txtLista = new System.Windows.Forms.TextBox() { Left = 20, Top = 20, Width = 460, Height = 340, Multiline = true, ScrollBars = System.Windows.Forms.ScrollBars.Vertical, ReadOnly = true, Name = "txtLista" };
            this.Controls.Add(txtLista);
        }
    }
}
