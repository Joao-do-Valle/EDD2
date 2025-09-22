using System;
using System.Collections.Generic;
using System.Linq;

namespace ContatosApp
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Data DtNasc { get; set; }
        public List<Telefone> Telefones { get; private set; }

        public Contato(string nome, string email, Data dtNasc)
        {
            Nome = nome;
            Email = email;
            DtNasc = dtNasc;
            Telefones = new List<Telefone>();
        }

        public int GetIdade()
        {
            if (DtNasc == null) return 0;
            DateTime hoje = DateTime.Now;
            int idade = hoje.Year - DtNasc.Ano;
            if (hoje.Month < DtNasc.Mes || (hoje.Month == DtNasc.Mes && hoje.Day < DtNasc.Dia))
                idade--;
            return idade;
        }

        public void AdicionarTelefone(Telefone t)
        {
            Telefones.Add(t);
        }

        public string GetTelefonePrincipal()
        {
            Telefone tel = Telefones.FirstOrDefault(t => t.Principal) ?? Telefones.FirstOrDefault();
            return tel != null ? tel.Numero : "Nenhum telefone";
        }

        public override string ToString()
        {
            string telPrincipal = GetTelefonePrincipal();
            string telefones = string.Join("; ", Telefones.Select(t => t.ToString()));
            return $"Nome: {Nome}\nEmail: {Email}\nNascimento: {DtNasc} (Idade: {GetIdade()})\nTelefones: {telefones}\nTelefone principal: {telPrincipal}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Contato)) return false;
            Contato outro = (Contato)obj;
            return string.Equals(Email ?? "", outro.Email ?? "", StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return (Email ?? "").ToLowerInvariant().GetHashCode();
        }
    }
}
