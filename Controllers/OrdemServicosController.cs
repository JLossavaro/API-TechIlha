using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiTechIlha.Context;
using ApiTechIlha.Models;
using Microsoft.AspNetCore.Authorization;

namespace ApiTechIlha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrdemServicosController : ControllerBase
    {
        private readonly DataContext _context;

        public OrdemServicosController(DataContext context)
        {
            _context = context;
        }

        // GET: api/OrdemServicos
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrdemServico>>> GetOS()
        {
            if (_context.OS == null)
            {
                return NotFound();
            }
            return await _context.OS.ToListAsync();
        }

        // GET: api/OrdemServicos/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<OrdemServico>> GetOrdemServico(int id)
        {
            if (_context.OS == null)
            {
                return NotFound();
            }
            var ordemServico = await _context.OS.FindAsync(id);

            if (ordemServico == null)
            {
                return NotFound();
            }

            return ordemServico;
        }

        // PUT: api/OrdemServicos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutOrdemServico(int id, bool bol)
        {
            var OS = _context.OrdemServico.Find(id);
            if (OS == null)
            {
                return Problem("Os nao existente");
            }
            if (bol == false)
            {
                OS.isAuthorized = true;
            }
            else
            {
                OS.isPayed = true;
                OS.DataFinal = DateTime.Now.ToString("d/MM/yyyy");
                _context.movimentacoes.Add(new Movimentacoes("Servico", OS.Preco));
                await _context.SaveChangesAsync();
            }

            _context.Entry(OS).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrdemServicoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/OrdemServicos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<OrdemServico>> PostOrdemServico(OrdemServico ordemServico)
        {
            var tipoServicoOS = _context.TipoServico.Find(ordemServico.TipoServicoId);
            var clienteOS = _context.clientes.Find(ordemServico.ClienteId);
            var funcionarioOS = _context.funcionarios.Find(ordemServico.FuncionarioId);

            if (_context.OS == null || tipoServicoOS == null || clienteOS == null || funcionarioOS == null)
            {
                return Problem("id de CLiente, tipoServico ou funcionario nao existe");
            }
            ordemServico.Data = DateTime.Now.ToString("d/MM/yyyy");
            ordemServico.DataFinal = null;
            _context.OS.Add(ordemServico);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrdemServico", new { id = ordemServico.Id }, ordemServico);
        }

        // DELETE: api/OrdemServicos/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteOrdemServico(int id)
        {
            if (_context.OS == null)
            {
                return NotFound();
            }
            var ordemServico = await _context.OS.FindAsync(id);
            if (ordemServico == null)
            {
                return NotFound();
            }

            _context.OS.Remove(ordemServico);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrdemServicoExists(int id)
        {
            return (_context.OS?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
