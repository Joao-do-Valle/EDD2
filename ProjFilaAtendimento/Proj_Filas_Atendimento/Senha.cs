using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Filas_Atendimento
{
    internal class Senha
    {
        private int id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;
        public int Id { get => id; set => id = value; }
        public DateTime DataGerac { get => dataGerac; set => dataGerac = value; }
        public DateTime HoraGerac { get => horaGerac; set => horaGerac = value; }
        public DateTime DataAtend { get => dataAtend; set => dataAtend = value; }
        public DateTime HoraAtend { get => horaAtend; set => horaAtend = value; }

        public Senha(int id)
        {
            this.Id = id;
            this.DataGerac = DateTime.Now;
            this.HoraGerac = DateTime.Now;
        }
        public string dadosParciais()
        {
            return $"{this.Id} - {this.DataGerac.ToShortDateString()} - {this.HoraGerac.ToLongTimeString()}\n";
        }
        public string dadosCompletos()
        {
            return $"{this.Id} - {this.DataGerac.ToShortDateString()} - {this.HoraGerac.ToLongTimeString()} - {this.DataAtend.ToShortDateString()} - {this.HoraAtend.ToLongTimeString()}\n";
        }
    }
}
