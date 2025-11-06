namespace Proj_Filas_Atendimento
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGerar = new System.Windows.Forms.Button();
            this.buttonListarSenha = new System.Windows.Forms.Button();
            this.buttonChamar = new System.Windows.Forms.Button();
            this.buttonListarAtendimento = new System.Windows.Forms.Button();
            this.rtxtSenhas = new System.Windows.Forms.RichTextBox();
            this.txtIdGuiche = new System.Windows.Forms.TextBox();
            this.buttonAddGuiche = new System.Windows.Forms.Button();
            this.rtxtAtendimentos = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQtdeGuiches = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGerar
            // 
            this.buttonGerar.Location = new System.Drawing.Point(70, 14);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(75, 23);
            this.buttonGerar.TabIndex = 0;
            this.buttonGerar.Text = "Gerar";
            this.buttonGerar.UseVisualStyleBackColor = true;
            this.buttonGerar.Click += new System.EventHandler(this.buttonGerar_Click);
            // 
            // buttonListarSenha
            // 
            this.buttonListarSenha.Location = new System.Drawing.Point(47, 194);
            this.buttonListarSenha.Name = "buttonListarSenha";
            this.buttonListarSenha.Size = new System.Drawing.Size(125, 23);
            this.buttonListarSenha.TabIndex = 1;
            this.buttonListarSenha.Text = "Listar senha";
            this.buttonListarSenha.UseVisualStyleBackColor = true;
            this.buttonListarSenha.Click += new System.EventHandler(this.buttonListarSenha_Click);
            // 
            // buttonChamar
            // 
            this.buttonChamar.Location = new System.Drawing.Point(551, 10);
            this.buttonChamar.Name = "buttonChamar";
            this.buttonChamar.Size = new System.Drawing.Size(106, 23);
            this.buttonChamar.TabIndex = 2;
            this.buttonChamar.Text = "Chamar";
            this.buttonChamar.UseVisualStyleBackColor = true;
            this.buttonChamar.Click += new System.EventHandler(this.buttonChamar_Click);
            // 
            // buttonListarAtendimento
            // 
            this.buttonListarAtendimento.Location = new System.Drawing.Point(395, 192);
            this.buttonListarAtendimento.Name = "buttonListarAtendimento";
            this.buttonListarAtendimento.Size = new System.Drawing.Size(237, 23);
            this.buttonListarAtendimento.TabIndex = 3;
            this.buttonListarAtendimento.Text = "Listar Atendimento";
            this.buttonListarAtendimento.UseVisualStyleBackColor = true;
            this.buttonListarAtendimento.Click += new System.EventHandler(this.buttonListarAtendimento_Click);
            // 
            // rtxtSenhas
            // 
            this.rtxtSenhas.Location = new System.Drawing.Point(20, 43);
            this.rtxtSenhas.Name = "rtxtSenhas";
            this.rtxtSenhas.Size = new System.Drawing.Size(196, 145);
            this.rtxtSenhas.TabIndex = 4;
            this.rtxtSenhas.Text = "";
            // 
            // txtIdGuiche
            // 
            this.txtIdGuiche.Location = new System.Drawing.Point(450, 11);
            this.txtIdGuiche.Name = "txtIdGuiche";
            this.txtIdGuiche.Size = new System.Drawing.Size(89, 22);
            this.txtIdGuiche.TabIndex = 5;
            // 
            // buttonAddGuiche
            // 
            this.buttonAddGuiche.Location = new System.Drawing.Point(241, 134);
            this.buttonAddGuiche.Name = "buttonAddGuiche";
            this.buttonAddGuiche.Size = new System.Drawing.Size(86, 23);
            this.buttonAddGuiche.TabIndex = 6;
            this.buttonAddGuiche.Text = "Adicionar";
            this.buttonAddGuiche.UseVisualStyleBackColor = true;
            this.buttonAddGuiche.Click += new System.EventHandler(this.buttonAddGuiche_Click);
            // 
            // rtxtAtendimentos
            // 
            this.rtxtAtendimentos.Location = new System.Drawing.Point(345, 41);
            this.rtxtAtendimentos.Name = "rtxtAtendimentos";
            this.rtxtAtendimentos.Size = new System.Drawing.Size(335, 145);
            this.rtxtAtendimentos.TabIndex = 7;
            this.rtxtAtendimentos.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Guiche:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Qtdw Guichês";
            // 
            // lblQtdeGuiches
            // 
            this.lblQtdeGuiches.AutoSize = true;
            this.lblQtdeGuiches.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeGuiches.Location = new System.Drawing.Point(269, 98);
            this.lblQtdeGuiches.Name = "lblQtdeGuiches";
            this.lblQtdeGuiches.Size = new System.Drawing.Size(31, 33);
            this.lblQtdeGuiches.TabIndex = 10;
            this.lblQtdeGuiches.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 239);
            this.Controls.Add(this.lblQtdeGuiches);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtAtendimentos);
            this.Controls.Add(this.buttonAddGuiche);
            this.Controls.Add(this.txtIdGuiche);
            this.Controls.Add(this.rtxtSenhas);
            this.Controls.Add(this.buttonListarAtendimento);
            this.Controls.Add(this.buttonChamar);
            this.Controls.Add(this.buttonListarSenha);
            this.Controls.Add(this.buttonGerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGerar;
        private System.Windows.Forms.Button buttonListarSenha;
        private System.Windows.Forms.Button buttonChamar;
        private System.Windows.Forms.Button buttonListarAtendimento;
        private System.Windows.Forms.RichTextBox rtxtSenhas;
        private System.Windows.Forms.TextBox txtIdGuiche;
        private System.Windows.Forms.Button buttonAddGuiche;
        private System.Windows.Forms.RichTextBox rtxtAtendimentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQtdeGuiches;
    }
}

