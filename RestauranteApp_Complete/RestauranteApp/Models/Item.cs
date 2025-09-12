using System;

namespace RestauranteApp.Models
{
    [Serializable]
    public class Item
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Descricao} (R$ {Preco:F2})";
        }
    }
}
