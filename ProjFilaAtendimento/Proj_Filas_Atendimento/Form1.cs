using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Filas_Atendimento
{
    public partial class Form1 : Form
    {
        Senhas todasSenhas = new Senhas();
        Guiches guiches = new Guiches();
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonGerar_Click(object sender, EventArgs e)
        {
            todasSenhas.gerar();
            MessageBox.Show("Senha gerada com sucesso!");
        }
        private void buttonListarSenha_Click(object sender, EventArgs e)
        {
            rtxtSenhas.Text = string.Empty;
            foreach(Senha s in todasSenhas.FilaSenhas)
            {
                rtxtSenhas.Text += s.dadosParciais();
            }
        }
        private void buttonAddGuiche_Click(object sender, EventArgs e)
        {
            guiches.adicionar(new Guiche(guiches.ListaGuiches.Count));
            lblQtdeGuiches.Text = guiches.ListaGuiches.Count.ToString();
        }
        private void buttonChamar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdGuiche.Text, out int idGuiche))
            {
                MessageBox.Show("Digite um número válido para o guichê!");
                return;
            }
            idGuiche -= 1;
            if (idGuiche >= 0 && idGuiche < guiches.ListaGuiches.Count)
            {
                if (guiches.ListaGuiches[idGuiche].chamar(todasSenhas.FilaSenhas)) 
                    { MessageBox.Show("Senha chamada com sucesso!"); }
                else{ MessageBox.Show("Não há senhas na fila!"); }
            }
            else{ MessageBox.Show("Guichê inválido!"); }
        }
        private void buttonListarAtendimento_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdGuiche.Text, out int idGuiche))
            {
                MessageBox.Show("Digite um número válido para o guichê!");
                return;
            }
            idGuiche -= 1;
            rtxtAtendimentos.Text = string.Empty;
            if (idGuiche >= 0 && idGuiche < guiches.ListaGuiches.Count)
            {
                foreach (Senha s in guiches.ListaGuiches[idGuiche].Atendimento)
                {
                    rtxtAtendimentos.Text += s.dadosCompletos();
                }
            }
            else
            {
                MessageBox.Show("Guichê inválido!");
            }
        }
    }
}
