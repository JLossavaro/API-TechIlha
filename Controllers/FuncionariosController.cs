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
    public class FuncionariosController : ControllerBase
    {
        private readonly DataContext _context;

        public FuncionariosController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Funcionarios
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Funcionario>>> Getfuncionarios()
        {
          if (_context.funcionarios == null)
          {
              return NotFound();
          }

            return await _context.funcionarios.ToListAsync();
        }

        // GET: api/Funcionarios/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Funcionario>> GetFuncionario(int id)
        {
          if (_context.funcionarios == null)
          {
              return NotFound();
          }
            var funcionario = await _context.funcionarios.FindAsync(id);

            if (funcionario == null)
            {
                return NotFound();
            }

            return funcionario;
        }

        // PUT: api/Funcionarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutFuncionario(int id, Funcionario funcionario)
        {
            if (id != funcionario.id)
            {
                return BadRequest();
            }

            _context.Entry(funcionario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FuncionarioExists(id))
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

        // POST: api/Funcionarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Funcionario>> PostFuncionario(Funcionario funcionario)
        {
          if (_context.funcionarios == null)
          {
              return Problem("Entity set 'DataContext.funcionarios'  is null.");
          }
            _context.funcionarios.Add(funcionario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFuncionario", new { id = funcionario.id }, funcionario);
        }

        // DELETE: api/Funcionarios/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteFuncionario(int id)
        {
            if (_context.funcionarios == null)
            {
                return NotFound();
            }
            var funcionario = await _context.funcionarios.FindAsync(id);
            if (funcionario == null)
            {
                return NotFound();
            }

            _context.funcionarios.Remove(funcionario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FuncionarioExists(int id)
        {
            return (_context.funcionarios?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
