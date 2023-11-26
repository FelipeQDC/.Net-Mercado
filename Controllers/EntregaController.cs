using Desafio.Data;
using Desafio.Services;
using Microsoft.AspNetCore.Mvc;
using Desafio.ViewModels;
using DesafioApi.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Controllers
{
    
    [ApiController]
    public class EntregaController : ControllerBase
    {
        [Authorize(Roles = "adm")]
        [HttpGet("transacoes")]
        public async Task<IActionResult> GetTransacoes(
             [FromServices] AppDbContext context)
        {
            try
            {
                var transacoes = await context.Transacao.ToListAsync();

                return Ok(transacoes);
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }

        [Authorize(Roles = "adm")]
        [HttpGet("Pedidos")]
        public async Task<IActionResult> GetPedidos(
             [FromServices] AppDbContext context)
        {
            try
            {
                var Pedidos = await context.ProdutoLista.ToListAsync();

                return Ok(Pedidos);
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }

        [Authorize(Roles = "adm")]
        [HttpPut("StatusAtualizar/{id:int}")]
        public async Task<IActionResult> AtualizarStatusPedido(
             [FromServices] AppDbContext context,
             [FromRoute] int id)
        {
            try
            {
                var Statustransação = await context.Transacao.FirstOrDefaultAsync
                    (x => x.Id == id);

                if (Statustransação == null)
                    return NotFound();
                switch(Statustransação.status)
                {
                    case "Em Separacao":
                        Statustransação.status = "A caminho do destino";
                    break;
                    case "A caminho do destino":
                        Statustransação.status = "Entregado ao destino";
                    break;
                }

                await context.SaveChangesAsync();

                return Ok(Statustransação);
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }

        [Authorize(Roles = "adm")]
        [HttpDelete("DeleteTransacao/{id:int}")]
        public async Task<IActionResult> DeletarTransação(
             [FromServices] AppDbContext context,
             [FromRoute] int id)
        {
            try
            {
                var transacao = await context.Transacao.FindAsync(id);

                if (transacao == null)
                    return NotFound();

                context.Transacao.Remove(transacao);
                await context.SaveChangesAsync();

                return Ok();
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }

        [Authorize(Roles = "adm,Cliente")]
        [HttpPut("Pedir")]
        public async Task<IActionResult> PutAsyncPedido(
            [FromServices] AppDbContext context,
            [FromBody] PedidoViewModel viewModel)
            {
            try
            {
                var handler = new JwtSecurityTokenHandler();
                string authHeader = Request.Headers["Authorization"];
                authHeader = authHeader.Replace("Bearer ", "");
                var jsonToken = handler.ReadToken(authHeader);
                var tokenS = handler.ReadToken(authHeader) as JwtSecurityToken;
                var Name = tokenS.Claims.First(claim => claim.Type == "given_name").Value;
                
                int quantidadeTotal = 0;
                decimal ValorTotal = 0;
                foreach(var items in viewModel.produtos)
                {
                    decimal valortemp;
                  
                    var productDB = context.Products
                    .FirstOrDefault(x => x.Name == items.Nome);

                    if (productDB == null)
                        return StatusCode(400, new { message = "Não temos este pedido" });

                    if (productDB.Quantidade < items.Quantidade)
                        return StatusCode(400, new { message = "Não temos esta quantidade no Estoque" });

                    valortemp = items.Quantidade * productDB.Valor;
                    var produto = new ProdutoLista
                    {
                        Comprador = Name,
                        Produto = items.Nome,
                        Quantidade = items.Quantidade,
                        Valor = valortemp
                    };


                    quantidadeTotal += items.Quantidade;
                    ValorTotal += valortemp;
                    productDB.Quantidade -= items.Quantidade;

                    await context.ProdutoLista.AddAsync(produto);
                }
                var transacaoNova = new Transacões
                {
                    Name = Name,
                    Quantidades = quantidadeTotal,
                    DateTime = DateTime.Now,
                    Valor = ValorTotal,
                    status = "Em Separacao"
                };

                await context.Transacao.AddAsync(transacaoNova);

                await context.SaveChangesAsync();
                return Ok(transacaoNova);
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }



    }
}
