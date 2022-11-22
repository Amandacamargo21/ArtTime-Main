using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtTime.Models
{
    public class Artista
    {
        public Artista() => CriadoEm = DateTime.Now;
        public int ArtistaId { get; set; }
        public string Nome { get; set; }
        public string cpf { get; set; }
        public string dataNascimento { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}