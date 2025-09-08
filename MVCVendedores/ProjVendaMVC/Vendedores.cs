using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjVendaMVC
{
    internal class Vendedores
    {
        private Vendedor[] osVendedores;
        private int max;
        private int qtde;

        public int Qtde { get => qtde; }

        public Vendedores(int max)
        {
            this.max = max;
            this.qtde = 0;
            this.osVendedores = new Vendedor[max];
        }

        public bool AddVendedor(Vendedor v)
        {
            if (qtde < max)
            {
                osVendedores[qtde++] = v;
                return true;
            }
            return false;
        }

        public bool DelVendedor(Vendedor v)
        {
            for (int i = 0; i < qtde; i++)
            {
                if (osVendedores[i].Id == v.Id)
                {
                    if (osVendedores[i].TemVendas()) return false;
                    for (int j = i; j < qtde - 1; j++)
                        osVendedores[j] = osVendedores[j + 1];
                    qtde--;
                    return true;
                }
            }
            return false;
        }

        public Vendedor SearchVendedor(int id)
        {
            for (int i = 0; i < qtde; i++)
            {
                if (osVendedores[i].Id == id)
                    return osVendedores[i];
            }
            return null;
        }

        public double ValorVendas()
        {
            double total = 0;
            for (int i = 0; i < qtde; i++)
                total += osVendedores[i].ValorVendas();
            return total;
        }

        public double ValorComissao()
        {
            double total = 0;
            for (int i = 0; i < qtde; i++)
                total += osVendedores[i].ValorComissao();
            return total;
        }

        public string Listar()
        {
            string ret = "";
            for (int i = 0; i < qtde; i++)
                ret += osVendedores[i].ToString() + "\n";
            ret += $"TOTAL Vendas: {ValorVendas():F2} | TOTAL Comissão: {ValorComissao():F2}";
            return ret;
        }
    }

}
