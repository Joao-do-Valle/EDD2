using System.Collections.Generic;

namespace AgendaApp
{
    public class Contatos
    {
        private List<Contato> agenda = new List<Contato>();

        public IReadOnlyList<Contato> Agenda => agenda.AsReadOnly();

        public bool adicionar(Contato c)
        {
            if (!agenda.Contains(c))
            {
                agenda.Add(c);
                return true;
            }
            return false;
        }

        public Contato pesquisar(Contato c)
        {
            return agenda.Find(x => x.Equals(c));
        }

        public bool alterar(Contato c)
        {
            int idx = agenda.FindIndex(x => x.Equals(c));
            if (idx >= 0)
            {
                agenda[idx] = c;
                return true;
            }
            return false;
        }

        public bool remover(Contato c)
        {
            return agenda.Remove(c);
        }
    }
}
