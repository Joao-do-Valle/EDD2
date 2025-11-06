using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Filas_Atendimento
{
    internal class Guiche
    {
        private int id;
        private Queue<Senha> atendimento;
        public int Id { get => id; set => id = value; }
        internal Queue<Senha> Atendimento { get => atendimento; set => atendimento = value; }

        public Guiche()
        {
            Atendimento = new Queue<Senha>();
            id = 0;
        }
        public Guiche(int id)
        {
            Atendimento = new Queue<Senha>();
            this.id = id;
        }
        public bool chamar(Queue<Senha> filasSenhas)
        {
            if (filasSenhas.Count > 0)
            {
                Senha senhaAtendida = filasSenhas.Dequeue();
                senhaAtendida.DataAtend = DateTime.Now;
                senhaAtendida.HoraAtend = DateTime.Now;
                Atendimento.Enqueue(senhaAtendida);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
