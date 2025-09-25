namespace AgendaApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.CheckBox chkPrincipal;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox listContatos;

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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.chkPrincipal = new System.Windows.Forms.CheckBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.listContatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // txtNome
            this.txtNome.Location = new System.Drawing.Point(12, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Nome";
            this.txtNome.Size = new System.Drawing.Size(200, 23);

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(12, 41);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(200, 23);

            // txtDia
            this.txtDia.Location = new System.Drawing.Point(12, 70);
            this.txtDia.Name = "txtDia";
            this.txtDia.PlaceholderText = "Dia";
            this.txtDia.Size = new System.Drawing.Size(40, 23);

            // txtMes
            this.txtMes.Location = new System.Drawing.Point(58, 70);
            this.txtMes.Name = "txtMes";
            this.txtMes.PlaceholderText = "Mês";
            this.txtMes.Size = new System.Drawing.Size(40, 23);

            // txtAno
            this.txtAno.Location = new System.Drawing.Point(104, 70);
            this.txtAno.Name = "txtAno";
            this.txtAno.PlaceholderText = "Ano";
            this.txtAno.Size = new System.Drawing.Size(60, 23);

            // txtTipo
            this.txtTipo.Location = new System.Drawing.Point(12, 99);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.PlaceholderText = "Tipo";
            this.txtTipo.Size = new System.Drawing.Size(60, 23);

            // txtNumero
            this.txtNumero.Location = new System.Drawing.Point(78, 99);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PlaceholderText = "Número";
            this.txtNumero.Size = new System.Drawing.Size(134, 23);

            // chkPrincipal
            this.chkPrincipal.AutoSize = true;
            this.chkPrincipal.Location = new System.Drawing.Point(12, 128);
            this.chkPrincipal.Name = "chkPrincipal";
            this.chkPrincipal.Size = new System.Drawing.Size(71, 19);
            this.chkPrincipal.Text = "Principal";

            // btnAdicionar
            this.btnAdicionar.Location = new System.Drawing.Point(12, 153);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);

            // btnRemover
            this.btnRemover.Location = new System.Drawing.Point(93, 153);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.Text = "Remover";
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);

            // btnListar
            this.btnListar.Location = new System.Drawing.Point(174, 153);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.Text = "Listar";
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);

            // listContatos
            this.listContatos.Location = new System.Drawing.Point(12, 182);
            this.listContatos.Size = new System.Drawing.Size(360, 200);

            // MainForm
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.chkPrincipal);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.listContatos);
            this.Name = "MainForm";
            this.Text = "AgendaApp";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
