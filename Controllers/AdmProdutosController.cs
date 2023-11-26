using Desafio.Data;
using Microsoft.AspNetCore.Mvc;
using DesafioApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Desafio.ViewModels;

namespace Desafio.Controllers
{
    [ApiController]
    public class AdmProdutosController : ControllerBase
    {
        [HttpGet("Produto")]
        public async Task<IActionResult> GetAsync(
            [FromServices] AppDbContext context)
        {
            try
            {
                var Produtos = await context.Products.ToListAsync();

                return Ok(Produtos);
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }


        [Authorize(Roles = "adm")]
        [HttpPost("Produto")]
        public async Task<IActionResult> PostAsync(
            [FromServices] AppDbContext context,
            [FromBody] ProdutoPostViewModel viewModel)
        {
            try
            {
                var newproduct = new Produto
                {
                    Name = viewModel.Nome,
                    Descricao = viewModel.Descricao,
                    Valor = viewModel.Valor,
                    Category = viewModel.Categoria,
                    Quantidade = viewModel.Quantidade
                };

                await context.Products.AddAsync(newproduct);
                await context.SaveChangesAsync();

                return Ok();
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }

        [Authorize(Roles = "adm")]
        [HttpPut("Produto/{id:int}/{addoutirar}/{qtd:int}")]
        public async Task<IActionResult> PutAsync(
           [FromServices] AppDbContext context,
           [FromRoute] int id,string addoutirar, int qtd)
        {
            try
            {
                var product = await context.Products.FindAsync(id);
                if (product == null)
                    return NotFound();
                switch (addoutirar)
                {
                    case "add":                     
                        product.Quantidade += qtd;
                    break;
                    case "tirar":
                        if(product.Quantidade <= qtd)
                            return BadRequest();
                        else 
                            product.Quantidade -= qtd;
                        break;
                }
                await context.SaveChangesAsync();

                return Ok(product);
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }

        [Authorize(Roles = "adm")]
        [HttpPut("Produto/{id:int}")]
        public async Task<IActionResult> PutAsync(
            [FromServices] AppDbContext context,
            [FromBody] ProdutoPostViewModel viewModel,
            [FromRoute] int id)
        {
            try
            {
                var product = await context.Products.FindAsync(id);
                if (product == null)
                    return NotFound();


                product.Name = viewModel.Nome;
                product.Descricao = viewModel.Descricao;
                product.Valor = viewModel.Valor;
                product.Category = viewModel.Categoria;
                product.Quantidade = viewModel.Quantidade;
                await context.SaveChangesAsync();

                return Ok();
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }
        [Authorize(Roles = "adm")]
        [HttpDelete("Produto/{id:int}")]
        public async Task<IActionResult> DeleteAsync(
            [FromServices] AppDbContext context,
            [FromRoute] int id)
        {
            try
            {
                var Products = await context.Products.FindAsync(id);

                if (Products == null)
                    return NotFound();

                context.Products.Remove(Products);
                await context.SaveChangesAsync();

                return Ok();
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }
    }
}
