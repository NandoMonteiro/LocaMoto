using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMoto.Models.DTOs
{
    internal class Pagamento
    {
        public int Id { get; set; }

        public int LocacaoId { get; set; }

       
        public string NumeroCartao { get; set; } 

        
        public string NomeTitular { get; set; }
        public DateTime DataValidade { get; set; }
               
        public string CVV { get; set; }
                
        public string BandeiraCartao { get; set; }
                
        public decimal ValorPagamento { get; set; }
        public DateTime DadaHoraPagamento { get; set; }

      
    }
}
