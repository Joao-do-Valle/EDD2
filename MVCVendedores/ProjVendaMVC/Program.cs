using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjVendaMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedores equipe = new Vendedores(10);
            int opcao;
            do
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1. Cadastrar vendedor");
                Console.WriteLine("2. Consultar vendedor");
                Console.WriteLine("3. Excluir vendedor");
                Console.WriteLine("4. Registrar venda");
                Console.WriteLine("5. Listar vendedores");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Percentual comissão: ");
                        double perc = double.Parse(Console.ReadLine());
                        if (equipe.AddVendedor(new Vendedor(id, nome, perc)))
                            Console.WriteLine("Vendedor cadastrado!");
                        else
                            Console.WriteLine("Limite atingido.");
                        break;

                    case 2:
                        Console.Write("Informe o ID: ");
                        id = int.Parse(Console.ReadLine());
                        Vendedor v = equipe.SearchVendedor(id);
                        if (v == null)
                            Console.WriteLine("Não encontrado.");
                        else
                            Console.WriteLine($"ID: {v.Id}, Nome: {v.Nome}, Total Vendas: {v.ValorVendas():F2}, Comissão: {v.ValorComissao():F2}, Média Diária: {v.ValorMedioDiario():F2}");
                        break;

                    case 3:
                        Console.Write("Informe o ID: ");
                        id = int.Parse(Console.ReadLine());
                        v = equipe.SearchVendedor(id);
                        if (v == null)
                            Console.WriteLine("Não encontrado.");
                        else if (equipe.DelVendedor(v))
                            Console.WriteLine("Excluído com sucesso.");
                        else
                            Console.WriteLine("Não pode excluir, há vendas registradas.");
                        break;

                    case 4:
                        Console.Write("Informe o ID do vendedor: ");
                        id = int.Parse(Console.ReadLine());
                        v = equipe.SearchVendedor(id);
                        if (v == null)
                        {
                            Console.WriteLine("Vendedor não encontrado.");
                            break;
                        }
                        Console.Write("Dia (1-31): ");
                        int dia = int.Parse(Console.ReadLine());
                        Console.Write("Quantidade: ");
                        int qtd = int.Parse(Console.ReadLine());
                        Console.Write("Valor total: ");
                        double valor = double.Parse(Console.ReadLine());
                        v.RegistrarVenda(dia, new Venda(qtd, valor));
                        Console.WriteLine("Venda registrada.");
                        break;

                    case 5:
                        Console.WriteLine(equipe.Listar());
                        break;
                }

            } while (opcao != 0);
        }
    }

}
