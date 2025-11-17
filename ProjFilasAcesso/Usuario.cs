
using System;
using System.Collections.Generic;

public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public List<Ambiente> Ambientes { get; set; } = new List<Ambiente>();

    public Usuario(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }


    public bool ConcederPermissao(Ambiente ambiente)
    {
        if (Ambientes.Find(a => a.Id == ambiente.Id) == null)
        {
            Ambientes.Add(ambiente);
            return true;
        }
        return false;
    }

   
    public bool RevogarPermissao(Ambiente ambiente)
    {
        
        int count = Ambientes.RemoveAll(a => a.Id == ambiente.Id);
        return count > 0;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Nome: {Nome}, Permissões: {Ambientes.Count} ambiente(s).";
    }
}