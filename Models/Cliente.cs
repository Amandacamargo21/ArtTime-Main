using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ArtTime.Models
{
    public class Cliente
    {
        public Cliente() => CriadoEm = DateTime.Now;
        public int? clienteId { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string dataNascimento { get; set; }
        public DateTime CriadoEm { get; set; }

    }
}