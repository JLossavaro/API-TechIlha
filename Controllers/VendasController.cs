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
    public class VendasController : ControllerBase
    {
        private readonly DataContext _context;

        public VendasController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Vendas
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Venda>>> GetVenda()
        {
            if (_context.Venda == null)
            {
                return NotFound();
            }
            return await _context.Venda.ToListAsync();
        }

        // GET: api/Vendas/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Venda>> GetVenda(int id)
        {
            if (_context.Venda == null)
            {
                return NotFound();
            }
            var venda = await _context.Venda.FindAsync(id);

            if (venda == null)
            {
                return NotFound();
            }

            return venda;
        }

        // POST: api/Vendas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Venda>> PostVenda(Venda venda)
        {
            var itemProduto = _context.produtos.Find(venda.idProduto);

            if (_context.Venda == null || itemProduto == null)
            {
                return Problem("Este produto não existe");
            }
            _context.movimentacoes.Add(new Movimentacoes("Vendas", (itemProduto.price * venda.quantidade)));
            await _context.SaveChangesAsync();

            venda.valorTotal = (itemProduto.price * venda.quantidade);
            venda.valor = itemProduto.price;
            venda.nomeProduto = itemProduto.name;
            venda.data = DateTime.Now.ToString("d/MM/yyyy");


            _context.Venda.Add(venda);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVenda", new { id = venda.id }, venda);
        }

        // DELETE: api/Vendas/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteVenda(int id)
        {
            if (_context.Venda == null)
            {
                return NotFound();
            }
            var venda = await _context.Venda.FindAsync(id);
            if (venda == null)
            {
                return NotFound();
            }

            _context.Venda.Remove(venda);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VendaExists(int id)
        {
            return (_context.Venda?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
