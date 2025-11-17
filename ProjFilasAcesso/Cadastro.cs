
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Cadastro
{
    public List<Usuario> Usuarios { get; set; } = new List<Usuario>();
    public List<Ambiente> Ambientes { get; set; } = new List<Ambiente>();

   
    public void Upload()
    {
        File.WriteAllText("data.json", JsonSerializer.Serialize(this));
    }

    public static Cadastro Download()
    {
        if (!File.Exists("data.json"))
        {
            return new Cadastro();
        }
        return JsonSerializer.Deserialize<Cadastro>(File.ReadAllText("data.json"));
    }

   
    public void AdicionarUsuario(Usuario usuario)
    {
        Usuarios.Add(usuario);
    }

    public bool RemoverUsuario(Usuario usuario)
    {
        if (usuario.Ambientes.Count == 0)
        {
            return Usuarios.RemoveAll(u => u.Id == usuario.Id) > 0;
        }
        return false;
    }

    public Usuario PesquisarUsuario(int id)
    {
        return Usuarios.Find(u => u.Id == id);
    }

    public void AdicionarAmbiente(Ambiente ambiente)
    {
        Ambientes.Add(ambiente);
    }

    public bool RemoverAmbiente(Ambiente ambiente)
    {
        return Ambientes.RemoveAll(a => a.Id == ambiente.Id) > 0;
    }

    public Ambiente PesquisarAmbiente(int id)
    {
        return Ambientes.Find(a => a.Id == id);
    }
}