using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtTime.Models
{
    public class Agendamento
    {
        //Data Annotations

        public Agendamento() => CriadoEm = DateTime.Now;

        [Key]
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string cpf { get; set; }
        public string LocalDaTattoo { get; set; }

        public int ArtistaId { get; set; }
        public Artista Artista { get; set; }
        public string DataAgendamento { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}