using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArtTime.Models
{
    public class Artista
    {
        public Artista() => CriadoEm = DateTime.Now;
        public int artistaId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string dataNascimento { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}