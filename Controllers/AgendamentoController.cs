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


        // POST: /api/folha/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Agendamento agendamento)
        {
            {
                _context.Agendamentos.Add(agendamento);
                _context.SaveChanges();
                return Created("", agendamento);
            }
        }
        // GET: /api/agendamento/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() =>
            Ok(_context.Agendamentos.ToList());

        [Route("buscar/{id}")]
        [HttpGet]
        public IActionResult Buscar([FromRoute] int id)
        {
            Agendamento agendamento =
                _context.Agendamentos.Find(id);
            //IF ternário
            return agendamento != null ? Ok(agendamento) : NotFound();
        }

        // GET: /api/artista/filtrar/{mes}/{ano}
        [HttpGet]
        [Route("filtrar/{mes}/{ano}")]
        public IActionResult Filtrar(
            [FromRoute] int mes, int ano
        ) =>
            Ok(_context.Agendamentos
                .Include(a => a.Artista)
                .Where(
                    a =>
                    a.CriadoEm.Month == mes &&
                    a.CriadoEm.Year == ano
                ));

    }
}