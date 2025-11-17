using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public partial class FrmMenu : Form
{
    private Cadastro cadastro;

    public FrmMenu()
    {
        
        this.Text = "Menu Principal - Controle de Acesso e Logs";
        this.Width = 350;
        this.Height = 550;

        cadastro = Cadastro.Download();

        DisplayMenu();
    }

    private void DisplayMenu()
    {
        this.Controls.Clear();

        int top = 20;
        int left = 20;
        int width = 300;
        int height = 30;
        int spacing = 40;

        string[] menuOptions = new string[]
        {
            "1. Cadastrar Ambiente",
            "2. Consultar Ambiente",
            "3. Excluir Ambiente",
            "4. Cadastrar Usuário",
            "5. Consultar Usuário",
            "6. Excluir Usuário",
            "7. Conceder Permissão de Acesso",
            "8. Revogar Permissão de Acesso",
            "9. Registrar Acesso",
            "10. Consultar Logs de Acesso",
            "0. Sair e Salvar"
        };

        for (int i = 0; i < menuOptions.Length; i++)
        {
            Button btn = new Button();
            btn.Text = menuOptions[i];
            btn.Left = left;
            btn.Top = top + (i * spacing);
            btn.Width = width;
            btn.Height = height;

           
            btn.Tag = i + 1;
            if (i == 10) btn.Tag = 0; 

            btn.Click += MenuButton_Click;
            this.Controls.Add(btn);
        }
    }

    private void MenuButton_Click(object sender, EventArgs e)
    {
        Button clickedButton = sender as Button;
        int option = (int)clickedButton.Tag;

        switch (option)
        {
            case 1: CadastrarAmbiente(); break;
            case 2: ConsultarAmbiente(); break;
            case 3: ExcluirAmbiente(); break;
            case 4: CadastrarUsuario(); break;
            case 5: ConsultarUsuario(); break;
            case 6: ExcluirUsuario(); break;
            case 7: GerenciarPermissao(true); break; 
            case 8: GerenciarPermissao(false); break; 
            case 9: RegistrarAcesso(); break;
            case 10: ConsultarLogs(); break;
            case 0: SairAplicacao(); break;
        }
    }

  
    private void CadastrarAmbiente()
    {
        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do novo Ambiente:", "Cadastro", ""), out int id) &&
            !string.IsNullOrWhiteSpace(Microsoft.VisualBasic.Interaction.InputBox("Digite o Nome do Ambiente:", "Cadastro", "")))
        {
            string nome = Microsoft.VisualBasic.Interaction.InputBox("Digite o Nome do Ambiente:", "Cadastro", "");
            if (cadastro.PesquisarAmbiente(id) == null)
            {
                cadastro.AdicionarAmbiente(new Ambiente(id, nome));
                MessageBox.Show("Ambiente cadastrado com sucesso.", "Sucesso");
            }
            else
            {
                MessageBox.Show("Erro: ID de ambiente já existe.", "Erro de Cadastro");
            }
        }
    }

    private void ConsultarAmbiente()
    {
        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do Ambiente para consulta:", "Consulta", ""), out int id))
        {
            Ambiente ambiente = cadastro.PesquisarAmbiente(id);
            if (ambiente != null)
            {
                MessageBox.Show(ambiente.ToString(), "Resultado da Consulta");
            }
            else
            {
                MessageBox.Show("Ambiente não encontrado.", "Erro");
            }
        }
    }

    private void ExcluirAmbiente()
    {
        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do Ambiente para exclusão:", "Excluir", ""), out int id))
        {
            Ambiente ambiente = cadastro.PesquisarAmbiente(id);
            if (ambiente != null)
            {
                if (cadastro.RemoverAmbiente(ambiente))
                {
                    MessageBox.Show("Ambiente removido com sucesso.", "Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao tentar remover o ambiente.", "Erro de Exclusão");
                }
            }
            else
            {
                MessageBox.Show("Ambiente não encontrado.", "Erro");
            }
        }
    }

    private void CadastrarUsuario()
    {
        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do novo Usuário:", "Cadastro", ""), out int id))
        {
            string nome = Microsoft.VisualBasic.Interaction.InputBox("Digite o Nome do Usuário:", "Cadastro", "");
            if (!string.IsNullOrWhiteSpace(nome) && cadastro.PesquisarUsuario(id) == null)
            {
                cadastro.AdicionarUsuario(new Usuario(id, nome));
                MessageBox.Show("Usuário cadastrado com sucesso.", "Sucesso");
            }
            else
            {
                MessageBox.Show("Erro: ID de usuário já existe ou nome inválido.", "Erro de Cadastro");
            }
        }
    }

    private void ConsultarUsuario()
    {
        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do Usuário para consulta:", "Consulta", ""), out int id))
        {
            Usuario usuario = cadastro.PesquisarUsuario(id);
            if (usuario != null)
            {
                string permissoes = string.Join(", ", usuario.Ambientes.Select(a => a.Nome));
                MessageBox.Show($"{usuario.ToString()}\nPermissões: {permissoes}", "Resultado da Consulta");
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.", "Erro");
            }
        }
    }

    private void ExcluirUsuario()
    {
        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do Usuário para exclusão:", "Excluir", ""), out int id))
        {
            Usuario usuario = cadastro.PesquisarUsuario(id);
            if (usuario != null)
            {
                if (cadastro.RemoverUsuario(usuario))
                {
                    MessageBox.Show("Usuário removido com sucesso.", "Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro: O usuário possui permissões ativas. Revogue todas antes de excluir.", "Erro de Exclusão");
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.", "Erro");
            }
        }
    }

    private void GerenciarPermissao(bool conceder)
    {
        string acao = conceder ? "Conceder" : "Revogar";

        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox($"Digite o ID do Usuário para {acao} Permissão:", acao, ""), out int userId) &&
            int.TryParse(Microsoft.VisualBasic.Interaction.InputBox($"Digite o ID do Ambiente para {acao} Permissão:", acao, ""), out int ambId))
        {
            Usuario u = cadastro.PesquisarUsuario(userId);
            Ambiente a = cadastro.PesquisarAmbiente(ambId);

            if (u == null || a == null)
            {
                MessageBox.Show("Usuário ou Ambiente não encontrados.", "Erro");
                return;
            }

            bool sucesso;
            if (conceder)
            {
                sucesso = u.ConcederPermissao(a);
                if (sucesso)
                    MessageBox.Show("Permissão concedida com sucesso.", "Sucesso");
                else
                    MessageBox.Show("Erro: O usuário já possui permissão para este ambiente.", "Erro");
            }
            else
            {
                sucesso = u.RevogarPermissao(a);
                if (sucesso)
                    MessageBox.Show("Permissão revogada com sucesso.", "Sucesso");
                else
                    MessageBox.Show("Erro: Permissão não encontrada para este usuário/ambiente.", "Erro");
            }
        }
    }

    private void RegistrarAcesso()
    {
        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do Usuário que tenta acessar:", "Registrar Acesso", ""), out int userId) &&
            int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do Ambiente de acesso:", "Registrar Acesso", ""), out int ambId))
        {
            Usuario u = cadastro.PesquisarUsuario(userId);
            Ambiente a = cadastro.PesquisarAmbiente(ambId);

            if (u == null || a == null)
            {
                MessageBox.Show("Usuário ou Ambiente não encontrados.", "Erro");
                return;
            }

            bool autorizado = u.Ambientes.Any(amb => amb.Id == a.Id);

            Log novoLog = new Log
            {
                DtAcesso = DateTime.Now,
                Usuario = u,
                TipoAcesso = autorizado 
            };

            a.RegistrarLog(novoLog);

            string resultado = autorizado ? "AUTORIZADO" : "NEGADO";
            MessageBox.Show($"Acesso de {u.Nome} ao ambiente {a.Nome} foi {resultado}. Log registrado.", resultado);
        }
    }

    private void ConsultarLogs()
    {
        if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Digite o ID do Ambiente para consulta de logs:", "Consulta de Logs", ""), out int ambId))
        {
            Ambiente a = cadastro.PesquisarAmbiente(ambId);
            if (a == null)
            {
                MessageBox.Show("Ambiente não encontrado.", "Erro");
                return;
            }

            string filtroStr = Microsoft.VisualBasic.Interaction.InputBox("Filtrar logs (A=Autorizado, N=Negado, T=Todos):", "Filtragem", "T").ToUpper();

            IEnumerable<Log> logsFiltrados = a.Logs.AsEnumerable();

            if (filtroStr == "A")
            {
                logsFiltrados = logsFiltrados.Where(l => l.TipoAcesso == true);
            }
            else if (filtroStr == "N")
            {
                logsFiltrados = logsFiltrados.Where(l => l.TipoAcesso == false);
            }

            string resultadoLogs = $"Logs do Ambiente {a.Nome} ({logsFiltrados.Count()} ocorrências):\n";
            foreach (var log in logsFiltrados)
            {
                string status = log.TipoAcesso ? "Autorizado" : "Negado";
                resultadoLogs += $"{log.DtAcesso.ToShortTimeString()} - Usuário: {log.Usuario.Nome} ({status})\n";
            }

            MessageBox.Show(resultadoLogs, "Logs de Acesso");
        }
    }

    private void SairAplicacao()
    {
        try
        {
            cadastro.Upload();
            MessageBox.Show("Dados salvos com sucesso em data.json.", "Salvamento");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao salvar dados: {ex.Message}", "Erro Crítico");
        }

        Application.Exit();
    }
}