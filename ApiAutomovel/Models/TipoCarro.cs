using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAutomovel.Models
{
    public class TipoCarro
    {
        [Key]
        public int Id { get; set; }
        public string TipoVeiculo { get; set; }
    }
}
