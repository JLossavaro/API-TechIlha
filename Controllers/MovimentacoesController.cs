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
    public class MovimentacoesController : ControllerBase
    {
        private readonly DataContext _context;

        public MovimentacoesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Movimentacoes
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Movimentacoes>>> Getmovimentacoes()
        {
          if (_context.movimentacoes == null)
          {
              return NotFound();
          }
            return await _context.movimentacoes.ToListAsync();
        }

        // GET: api/Movimentacoes/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Movimentacoes>> GetMovimentacoes(int id)
        {
          if (_context.movimentacoes == null)
          {
              return NotFound();
          }
            var movimentacoes = await _context.movimentacoes.FindAsync(id);

            if (movimentacoes == null)
            {
                return NotFound();
            }

            return movimentacoes;
        }

        // PUT: api/Movimentacoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutMovimentacoes(int id, Movimentacoes movimentacoes)
        {
            if (id != movimentacoes.id)
            {
                return BadRequest();
            }

            _context.Entry(movimentacoes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovimentacoesExists(id))
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

        // POST: api/Movimentacoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Movimentacoes>> PostMovimentacoes(Movimentacoes movimentacoes)
        {
          if (_context.movimentacoes == null)
          {
              return Problem("Entity set 'DataContext.movimentacoes'  is null.");
          }
            _context.movimentacoes.Add(movimentacoes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovimentacoes", new { id = movimentacoes.id }, movimentacoes);
        }

        // DELETE: api/Movimentacoes/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteMovimentacoes(int id)
        {
            if (_context.movimentacoes == null)
            {
                return NotFound();
            }
            var movimentacoes = await _context.movimentacoes.FindAsync(id);
            if (movimentacoes == null)
            {
                return NotFound();
            }

            _context.movimentacoes.Remove(movimentacoes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovimentacoesExists(int id)
        {
            return (_context.movimentacoes?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
