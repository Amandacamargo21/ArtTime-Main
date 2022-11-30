using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtTime.Models
{

    public class Agendamento
    {
        public int Id { get; set; }
        public string localDaTattoo { get; set; }
        public string dataAgendamento { get; set; }
        public int? artistaId { get; set; }
        public int? clienteId { get; set; }
        public Artista Artista { get; set; }
        public int? clienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime CriadoEm { get; set; }
        public Agendamento() => CriadoEm = DateTime.Now;

        public Agendamento(DateTime CriadoEm, int clienteId, int artistaId, string localDaTattoo, string dataAgendamento)
        {
            this.CriadoEm = CriadoEm;
            this.clienteId = clienteId;
            this.artistaId = artistaId;
            this.localDaTattoo = localDaTattoo;
            this.dataAgendamento = dataAgendamento;
        }
    }
}