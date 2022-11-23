using Microsoft.AspNetCore.Mvc;
using ArtTime.Models;
using System.Collections.Generic;
using System.Linq;


namespace ArtTime.CLienteController
{
    [Route("api/cliente")]
    [ApiController]
    public class CLienteController : ControllerBase
    {
        private readonly DataContext _context;

        public CLienteController(DataContext context) =>
            _context = context;
        private static List<Cliente> clientes = new List<Cliente>();

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() =>
            Ok(_context.Clientes.ToList());


        //POST:  /api/cliente/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return Created("", clientes);
        }


        // DELETE: /api/cliente/deletar/1
        [Route("deletar/{id}")]
        [HttpDelete]

        public IActionResult Deletar([FromRoute] int id)
        {
            Cliente cliente = _context.Clientes.Find(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
                return Ok(cliente);
            }
            return NotFound();
        }
        // PATCH: /api/cliente/alterar
        [Route("alterar")]
        [HttpPatch]
        public IActionResult Alterar([FromBody] Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
            return Ok(cliente);
        }

        // GET: /api/cliente/buscar/1
        [Route("buscar/{id}")]
        [HttpGet]
        public IActionResult Buscar([FromRoute] int id)
        {
            Cliente cliente =
                _context.Clientes.Find(id);
            return cliente != null ? Ok(cliente) : NotFound();
        }
    }
}