using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiTechIlha.Context;
using ApiTechIlha.Models;

namespace ApiTechIlha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdensServicoController : ControllerBase
    {
        private readonly DataContext _context;

        public OrdensServicoController(DataContext context)
        {
            _context = context;
        }

        // GET: api/OrdensServico
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrdemServico>>> GetOrdemServico()
        {
          if (_context.OrdemServico == null)
          {
              return NotFound();
          }

            return await _context.OrdemServico.ToListAsync();
        }

        // GET: api/OrdensServico/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrdemServico>> GetOrdemServico(int id)
        {
          if (_context.OrdemServico == null)
          {
              return NotFound();
          }
            var ordemServico = await _context.OrdemServico.FindAsync(id);

            if (ordemServico == null)
            {
                return NotFound();
            }

            return ordemServico;
        }

        // PUT: api/OrdensServico/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrdemServico(int id, OrdemServico ordemServico)
        {
            if (id != ordemServico.id)
            {
                return BadRequest();
            }

            _context.Entry(ordemServico).State = EntityState.Modified;

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

        // POST: api/OrdensServico
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrdemServico>> PostOrdemServico(OrdemServico ordemServico)
        {
          if (_context.OrdemServico == null)
          {
              return Problem("Entity set 'DataContext.OrdemServico'  is null.");
          }
        //  if(_context.modelos.FirstAsync(ordemServico.id))

            _context.OrdemServico.Add(ordemServico);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrdemServico", new { id = ordemServico.id }, ordemServico);
        }

        // DELETE: api/OrdensServico/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrdemServico(int id)
        {
            if (_context.OrdemServico == null)
            {
                return NotFound();
            }
            var ordemServico = await _context.OrdemServico.FindAsync(id);
            if (ordemServico == null)
            {
                return NotFound();
            }

            _context.OrdemServico.Remove(ordemServico);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrdemServicoExists(int id)
        {
            return (_context.OrdemServico?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
