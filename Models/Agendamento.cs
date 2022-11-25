using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtTime.Models
{

    public class Agendamento
    {
        public Agendamento()
        {
            Artista = new Artista();
            Cliente = new Cliente();
            CriadoEm = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }
        public string localDaTattoo { get; set; }
        public string dataAgendamento { get; set; }
        public Artista Artista { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}