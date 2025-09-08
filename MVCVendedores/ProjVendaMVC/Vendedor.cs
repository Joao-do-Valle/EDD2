using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjVendaMVC
{
    internal class Vendedor
    {
        private int id;
        private string nome;
        private double percComissao;
        private Venda[] asVendas;

        public int Id { get => id; }
        public string Nome { get => nome; }
        public double PercComissao { get => percComissao; }

        public Vendedor(int id, string nome, double percComissao)
        {
            this.id = id;
            this.nome = nome;
            this.percComissao = percComissao;
            this.asVendas = new Venda[31];
            for (int i = 0; i < 31; i++)
                this.asVendas[i] = new Venda();
        }

        public void RegistrarVenda(int dia, Venda venda)
        {
            if (dia >= 1 && dia <= 31)
                this.asVendas[dia - 1] = venda;
        }

        public double ValorVendas()
        {
            return asVendas.Sum(v => v.Valor);
        }

        public double ValorComissao()
        {
            return ValorVendas() * percComissao / 100.0;
        }

        public double ValorMedioDiario()
        {
            var vendasValidas = asVendas.Where(v => v.Qtde > 0);
            if (!vendasValidas.Any()) return 0;
            return vendasValidas.Average(v => v.ValorMedio());
        }

        public bool TemVendas()
        {
            return asVendas.Any(v => v.Qtde > 0);
        }

        public override string ToString()
        {
            return $"{id} - {nome} | Total Vendas: {ValorVendas():F2} | Comissão: {ValorComissao():F2}";
        }
    }

}
