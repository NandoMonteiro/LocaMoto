using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMoto.Models.DTOs
{
    internal class Cliente
    {
        public int Id { get; set; }

        public int CPF { get; set; }

        public string Email { get; set; } = string.Empty;

        public string Nome { get; set; } = string.Empty;

        public string Endereco { get; set; } = string.Empty;
        public int Celular { get; set; }
        public int Habilitacao { get; set; }

        public string Profissao { get; set; } = string.Empty;
    }
}
