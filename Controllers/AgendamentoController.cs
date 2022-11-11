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
        public IActionResult Listar()
        {
            List<Agendamento> agendamentos =
                _context.Agendamentos.Include(a => a.Artista).ToList();

            if (agendamentos.Count == 0) return NotFound();

            return Ok(agendamentos);
            // return folhas.Count != 0 ? Ok(folhas) : NotFound();
        }

        // GET: /api/artista/buscar/{cpf}/{mes}/{ano}
        [HttpGet]
        [Route("buscar/{cpf}/{mes}/{ano}")]
        public IActionResult Buscar(
            [FromRoute] string cpf, int mes, int ano
        ) =>
            Ok(_context.Agendamentos
                .Include(a => a.Artista)
                .FirstOrDefault(
                    a =>
                    a.Artista.cpf.Equals(cpf) &&
                    a.Mes == mes &&
                    a.Ano == ano
                ));

        // GET: /api/artista/filtrar/{mes}/{ano}
        [HttpGet]
        [Route("filtrar/{mes}/{ano}")]
        public IActionResult Filtrar(
            [FromRoute] int mes, int ano
        ) =>
            Ok(_context.Agendamentos
                .Include(f => f.Artista)
                .Where(
                    a =>
                    a.CriadoEm.Month == mes &&
                    a.CriadoEm.Year == ano
                ));

    }
}