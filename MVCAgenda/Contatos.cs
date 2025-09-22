using System.Collections.Generic;

namespace ContatosApp
{
    public class Contatos
    {
        private readonly List<Contato> agenda = new List<Contato>();
        public List<Contato> Agenda { get { return agenda; } }

        public bool Adicionar(Contato c)
        {
            if (c == null) return false;
            if (agenda.Contains(c)) return false;
            agenda.Add(c);
            return true;
        }

        public Contato Pesquisar(Contato c)
        {
            if (c == null) return null;
            return agenda.Find(x => x.Equals(c));
        }

        public bool Alterar(Contato c)
        {
            if (c == null) return false;
            int idx = agenda.FindIndex(x => x.Equals(c));
            if (idx < 0) return false;
            agenda[idx] = c;
            return true;
        }

        public bool Remover(Contato c)
        {
            if (c == null) return false;
            return agenda.RemoveAll(x => x.Equals(c)) > 0;
        }
    }
}
