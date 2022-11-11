using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtTime.Models
{
    public class Artista
    {
        public Artista() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public string Nome { get; set; }
        // [Required(ErrorMessage = "O campo cpf é obrigatório!")]
        // [StringLength(
        //     11, //Máximo de caracteres
        //     MinimumLength = 11,
        //     ErrorMessage = "cpf Invalido!"
        // )]
        public string cpf { get; set; }

        public string dataNascimento { get; set; }
        public DateTime CriadoEm { get; set; }

    }
}