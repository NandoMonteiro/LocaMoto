using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMoto.Models.DTOs
{
    internal class Moto
    {
        public int Id { get; set; }
               
        public string Placa { get; set; }
                
        public string Modelo { get; set; }
                
        public string Marca { get; set; } 

        public int Cilindrada { get; set; }
              
        public string Cor { get; set; } 
        public int Ano { get; set; }
               
        public string Renavam { get; set; } 
               
        public decimal ValorDiaria { get; set; }

        public int Quilometragem { get; set; }

        public string ImagemUrl { get; set; } 

        public int CategoriaId { get; set; }
       
    }
}
