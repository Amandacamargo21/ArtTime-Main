using Microsoft.AspNetCore.Mvc;
using ArtTime.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ArtTime.AgendamentoController
{
    [ApiController]
    [Route("api/agendamento")]
    public class AgendamentoController : ControllerBase
    {
        private readonly DataContext _context;
        public AgendamentoController(DataContext context) =>
            _context = context;


        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Agendamento agendamento)
        {
            {
                _context.Agendamento.Add(agendamento);
                _context.SaveChanges();
                return Created("", agendamento);
            }
        }
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            var agendamentos = _context.Agendamento
            .Include(agendamento => agendamento.Artista)
            .Include(agendamento => agendamento.Cliente)
            .ToList();

            return Ok(agendamentos);
        }

        [Route("buscar/{id}")]
        [HttpGet]
        public IActionResult Buscar([FromRoute] int id)
        {
            Agendamento agendamento =
                _context.Agendamento.Find(id);
            //IF ternário
            return agendamento != null ? Ok(agendamento) : NotFound();
        }

        [Route("remover/{id}")]
        [HttpDelete]
        public IActionResult Remover([FromRoute] int id)
        {
            Agendamento agendamento = _context.Agendamento.Find(id);

            if (agendamento != null)
            {
                _context.Agendamento.Remove(agendamento);
                _context.SaveChanges();
                return Ok(agendamento);
            }

            return NotFound("Nenhum agendamento foi encontrado com o id: " + id);
        }
    }
}