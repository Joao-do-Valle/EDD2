using System;
using System.Collections.Generic;

namespace AgendaApp
{
    public class Contato
    {
        public string Email { get; set; }
        public string Nome { get; set; }
        public Data DtNasc { get; set; }
        public List<Telefone> Telefones { get; private set; }

        public Contato(string nome, string email, Data dtNasc)
        {
            Nome = nome;
            Email = email;
            DtNasc = dtNasc;
            Telefones = new List<Telefone>();
        }

        public void adicionarTelefone(Telefone t)
        {
            Telefones.Add(t);
        }

        public string getTelefonePrincipal()
        {
            var tel = Telefones.Find(t => t.Principal);
            return tel != null ? tel.Numero : "Nenhum principal";
        }

        public int getIdade()
        {
            if (DtNasc == null) return 0;
            var hoje = DateTime.Today;
            int idade = hoje.Year - DtNasc.Ano;
            if (hoje.Month < DtNasc.Mes || (hoje.Month == DtNasc.Mes && hoje.Day < DtNasc.Dia))
                idade--;
            return idade;
        }

        public override string ToString()
        {
            return $"{Nome} - {Email} - {DtNasc} - Tel: {getTelefonePrincipal()}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Contato c)
                return Email.Equals(c.Email);
            return false;
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
