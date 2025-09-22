using System;
using System.Collections.Generic;

namespace ContatosApp
{
    class Program
    {
        static Contatos agenda = new Contatos();

        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("\n===== AGENDA DE CONTATOS =====");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar contato");
                Console.WriteLine("2. Pesquisar contato");
                Console.WriteLine("3. Alterar contato");
                Console.WriteLine("4. Remover contato");
                Console.WriteLine("5. Listar contatos");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao)) opcao = -1;

                switch (opcao)
                {
                    case 1:
                        AdicionarContato();
                        break;
                    case 2:
                        PesquisarContato();
                        break;
                    case 3:
                        AlterarContato();
                        break;
                    case 4:
                        RemoverContato();
                        break;
                    case 5:
                        ListarContatos();
                        break;
                }
            } while (opcao != 0);

            Console.WriteLine("Fim do programa. Pressione uma tecla para sair.");
            Console.ReadKey();
        }

        static void AdicionarContato()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Email: ");
            string email = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Data de nascimento (dd mm aaaa): ");
            var dataParts = (Console.ReadLine() ?? "").Split(new[] {' ', '/'}, StringSplitOptions.RemoveEmptyEntries);
            if (dataParts.Length < 3) { Console.WriteLine("Data inválida."); return; }
            if (!int.TryParse(dataParts[0], out int d) || !int.TryParse(dataParts[1], out int m) || !int.TryParse(dataParts[2], out int a)) { Console.WriteLine("Data inválida."); return; }
            Data dt = new Data(d, m, a);

            Contato c = new Contato(nome, email, dt);

            Console.Write("Quantos telefones deseja adicionar? ");
            if (!int.TryParse(Console.ReadLine(), out int qtd)) qtd = 0;

            for (int i = 0; i < qtd; i++)
            {
                Console.Write($"Tipo do {i+1}º telefone: ");
                string tipo = Console.ReadLine()?.Trim() ?? "";
                Console.Write($"Número do {i+1}º telefone: ");
                string numero = Console.ReadLine()?.Trim() ?? "";
                Console.Write($"É o principal? (s/n): ");
                bool principal = (Console.ReadLine() ?? "").Trim().ToLower() == "s";

                Telefone t = new Telefone(tipo, numero, principal);
                c.AdicionarTelefone(t);
            }

            if (agenda.Adicionar(c))
                Console.WriteLine("Contato adicionado com sucesso!");
            else
                Console.WriteLine("Já existe um contato com este e-mail!");
        }

        static void PesquisarContato()
        {
            Console.Write("Digite o email do contato: ");
            string email = Console.ReadLine()?.Trim() ?? "";
            Contato temp = new Contato("", email, null);
            Contato encontrado = agenda.Pesquisar(temp);
            if (encontrado != null)
                Console.WriteLine(encontrado);
            else
                Console.WriteLine("Contato não encontrado.");
        }

        static void AlterarContato()
        {
            Console.Write("Digite o email do contato a alterar: ");
            string email = Console.ReadLine()?.Trim() ?? "";
            Contato temp = new Contato("", email, null);
            Contato existente = agenda.Pesquisar(temp);
            if (existente == null)
            {
                Console.WriteLine("Contato não encontrado.");
                return;
            }

            Console.Write("Novo nome: ");
            string nome = Console.ReadLine()?.Trim() ?? existente.Nome;
            Console.Write("Nova data de nascimento (dd mm aaaa): ");
            var dataParts = (Console.ReadLine() ?? "").Split(new[] {' ', '/'}, StringSplitOptions.RemoveEmptyEntries);
            if (dataParts.Length < 3) { Console.WriteLine("Data inválida."); return; }
            if (!int.TryParse(dataParts[0], out int d) || !int.TryParse(dataParts[1], out int m) || !int.TryParse(dataParts[2], out int a)) { Console.WriteLine("Data inválida."); return; }
            Data dt = new Data(d, m, a);

            Contato novo = new Contato(nome, email, dt);

            Console.Write("Quantos telefones deseja adicionar? ");
            if (!int.TryParse(Console.ReadLine(), out int qtd)) qtd = 0;

            for (int i = 0; i < qtd; i++)
            {
                Console.Write($"Tipo do {i+1}º telefone: ");
                string tipo = Console.ReadLine()?.Trim() ?? "";
                Console.Write($"Número do {i+1}º telefone: ");
                string numero = Console.ReadLine()?.Trim() ?? "";
                Console.Write($"É o principal? (s/n): ");
                bool principal = (Console.ReadLine() ?? "").Trim().ToLower() == "s";

                Telefone t = new Telefone(tipo, numero, principal);
                novo.AdicionarTelefone(t);
            }

            if (agenda.Alterar(novo))
                Console.WriteLine("Contato alterado com sucesso!");
            else
                Console.WriteLine("Erro ao alterar.");
        }

        static void RemoverContato()
        {
            Console.Write("Digite o email do contato a remover: ");
            string email = Console.ReadLine()?.Trim() ?? "";
            Contato temp = new Contato("", email, null);
            if (agenda.Remover(temp))
                Console.WriteLine("Contato removido com sucesso!");
            else
                Console.WriteLine("Contato não encontrado.");
        }

        static void ListarContatos()
        {
            if (agenda.Agenda.Count == 0) { Console.WriteLine("Nenhum contato cadastrado."); return; }
            foreach (var c in agenda.Agenda)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine(c);
            }
        }
    }
}
