using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Filas_Atendimento
{
    internal class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;
        public int ProximoAtendimento { get => proximoAtendimento; set => proximoAtendimento = value; }
        internal Queue<Senha> FilaSenhas { get => filaSenhas; set => filaSenhas = value; }
        public Senhas()
        {
            ProximoAtendimento = 1;
            FilaSenhas = new Queue<Senha>();
        }
        public void gerar()
        {
            Senha novaSenha = new Senha(ProximoAtendimento);
            FilaSenhas.Enqueue(novaSenha);
            ProximoAtendimento++;
        }
    }
}
