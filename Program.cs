
using System;
using System.Collections.Generic;

namespace ProjTransporte {
    class Veiculo {
        public int Id { get; set; }
        public int Lotacao { get; set; }
        public int Transportados { get; set; }
    }
    class Garagem {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Stack<Veiculo> Veiculos = new Stack<Veiculo>();
        public int Viagens = 0;
        public int Passageiros = 0;
    }
    class Viagem {
        public string Origem;
        public String Destino;
        public int Passageiros;
    }

    class Sistema {
        public List<Veiculo> veiculos = new();
        public List<Garagem> garagens = new();
        public List<Viagem> viagens = new();
        public bool jornada = false;

        public Garagem GetG(int id)=>garagens.Find(g=>g.Id==id);
        public Veiculo GetV(int id)=>veiculos.Find(v=>v.Id==id);
    }

    class Program {
        static Sistema s = new();

        static void Main(){
            while(true){
                Console.WriteLine("0 Finalizar
1 Cad Veiculo
2 Cad Garagem
3 Iniciar jornada
4 Encerrar jornada
5 Liberar viagem
6 Listar veiculos
7 Qtde viagens
8 Listar viagens
9 Passageiros transportados");
                int op=int.Parse(Console.ReadLine());
                if(op==0)break;
                switch(op){
                    case 1:CadV();break;
                    case 2:CadG();break;
                    case 3:s.jornada=true;Console.WriteLine("Jornada iniciada");break;
                    case 4:s.jornada=false;foreach(var v in s.veiculos)v.Transportados=0;Console.WriteLine("Encerrada");break;
                    case 5:Lib();break;
                    case 6:Listar();break;
                    case 7:Qtde();break;
                    case 8:ListarV();break;
                    case 9:Pass();break;
                }
            }
        }

        static void CadV(){
            if(s.jornada){Console.WriteLine("Encerrar jornada antes");return;}
            Console.Write("Id: ");int id=int.Parse(Console.ReadLine());
            Console.Write("Lotacao: ");int l=int.Parse(Console.ReadLine());
            s.veiculos.Add(new Veiculo{Id=id,Lotacao=l});
        }
        static void CadG(){
            if(s.jornada){Console.WriteLine("Encerrar jornada antes");return;}
            Console.Write("Id G: ");int id=int.Parse(Console.ReadLine());
            Console.Write("Nome: ");string n=Console.ReadLine();
            s.garagens.Add(new Garagem{Id=id,Nome=n});
        }
        static void Lib(){
            if(!s.jornada){Console.WriteLine("Jornada não iniciada");return;}
            Console.Write("Origem id: ");int o=int.Parse(Console.ReadLine());
            Console.Write("Destino id: ");int d=int.Parse(Console.ReadLine());
            var go=s.GetG(o);var gd=s.GetG(d);
            if(go.Veiculos.Count==0){Console.WriteLine("Sem veículos");return;}
            var v=go.Veiculos.Pop();
            go.Viagens++;
            go.Passageiros+=v.Lotacao;
            v.Transportados+=v.Lotacao;
            s.viagens.Add(new Viagem{Origem=go.Nome,Destino=gd.Nome,Passageiros=v.Lotacao});
            gd.Veiculos.Push(v);
            Console.WriteLine("Liberado");
        }
        static void Listar(){
            Console.Write("Garagem: ");int id=int.Parse(Console.ReadLine());
            var g=s.GetG(id);
            Console.WriteLine($"Veiculos: {g.Veiculos.Count}");
            foreach(var v in g.Veiculos)Console.WriteLine($"V {v.Id} lot {v.Lotacao}");
        }
        static void Qtde(){
            Console.Write("Origem nome: ");string o=Console.ReadLine();
            Console.Write("Destino nome: ");string d=Console.ReadLine();
            int c=0;
            foreach(var v in s.viagens)if(v.Origem==o && v.Destino==d)c++;
            Console.WriteLine(c);
        }
        static void ListarV(){
            Console.Write("Origem nome: ");string o=Console.ReadLine();
            Console.Write("Destino nome: ");string d=Console.ReadLine();
            foreach(var v in s.viagens)if(v.Origem==o && v.Destino==d)Console.WriteLine($"{v.Origem}->{v.Destino} {v.Passageiros}");
        }
        static void Pass(){
            Console.Write("Origem nome: ");string o=Console.ReadLine();
            Console.Write("Destino nome: ");string d=Console.ReadLine();
            int p=0;
            foreach(var v in s.viagens)if(v.Origem==o && v.Destino==d)p+=v.Passageiros;
            Console.WriteLine(p);
        }
    }
}
