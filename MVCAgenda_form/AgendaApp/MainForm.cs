using System;
using System.Windows.Forms;

namespace AgendaApp
{
    public partial class MainForm : Form
    {
        Contatos contatos = new Contatos();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Contato c = new Contato(txtNome.Text, txtEmail.Text, 
                new Data(int.Parse(txtDia.Text), int.Parse(txtMes.Text), int.Parse(txtAno.Text)));

            Telefone t = new Telefone(txtTipo.Text, txtNumero.Text, chkPrincipal.Checked);
            c.adicionarTelefone(t);

            contatos.adicionar(c);
            MessageBox.Show("Contato adicionado!");
            AtualizarLista();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Contato c = new Contato(txtNome.Text, txtEmail.Text, null);
            if (contatos.remover(c))
                MessageBox.Show("Contato removido!");
            else
                MessageBox.Show("Contato não encontrado.");
            AtualizarLista();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            listContatos.Items.Clear();
            foreach (var c in contatos.Agenda)
            {
                listContatos.Items.Add(c.ToString());
            }
        }
    }
}
