using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAutomovel.Models
{
    public class Automovel
    {
        [Key]
        public int Id { get; set; }
        public string Modelo { get; set; }
        public int NumRodas { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public int NumPortas { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }       
        public int tipoCarro { get; set; }
    }
}
