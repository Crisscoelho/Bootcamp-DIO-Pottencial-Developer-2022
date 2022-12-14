using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio_Tech_Pottencial.Models
{
    public class Venda
    {
        [Key]
        public int Id {get; set;}
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public string Status { get; set; }
        [ForeignKey("FK_Vendedor")]
        public int VendedorID {get; set;}

        public List<Item> Itens {get; set;}
        public Vendedor Vendedor {get;set;}
    }
}