using Desafio.Data;
using Desafio.Services;
using Microsoft.AspNetCore.Mvc;
using Desafio.ViewModels;
using DesafioApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace Desafio.Controllers
{
    [ApiController]
    public class AccountControllers : ControllerBase
    {

        [HttpPost("login")]
        public IActionResult Login(
            [FromServices] AppDbContext context,
            [FromBody] AccountLoginViewModel model,
            [FromServices] TokenService tokenService)
        {
            try
            {
                var user = context.Usuario
                    .FirstOrDefault(x => x.Email == model.Email);

                if (user == null)
                    return StatusCode(401, new { message = "usuario ou senha invalido" });

                if (user.Password != Settings.GenerateHash(model.Password))
                    return StatusCode(401, new { message = "usuario ou senha invalido" });

                var token = tokenService.CreateToken(user);

                return Ok(new { token,user.Role,user.Name });
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }

        [HttpPost("cadastro")]
        public IActionResult Signup(
            [FromBody] AccountSignupViewModel model,
            [FromServices] AppDbContext context)
        {
            try
            {
                var user = context.Usuario
                    .FirstOrDefault(x => x.Email == model.Email);

                if (user != null)
                    return StatusCode(401, new { message = "Email já cadastrado!" });

                var newUser = new Usuario
                {
                    Email = model.Email,
                    Password = Settings.GenerateHash(model.Password),
                    Name = model.Name,
                    Role = "Cliente"
                };

                context.Usuario.Add(newUser);
                context.SaveChanges();

                return Ok();
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }
        [Authorize(Roles = "adm")]
        [HttpGet("Contas")]
        public async Task<IActionResult> GetContasAsync(
            [FromServices] AppDbContext context)
        {
            try
            {
                var Usuario = await context.Usuario.ToListAsync();

                return Ok(Usuario);
            }
            catch
            {   
                return StatusCode(500, new { message = "Erro interno" });
            }
        }
        [Authorize(Roles = "adm")]
        [HttpPut("AtualizarConta/{id:int}")]
        public async Task<IActionResult> PutAsync(
            [FromServices] AppDbContext context,
            [FromBody] AccountAtualizarViewModel viewModel,
            [FromRoute] int id)
        {
            try
            {
                var Usuario = await context.Usuario.FindAsync(id);
                if (Usuario == null)
                    return NotFound();


                Usuario.Name = viewModel.Name;
                Usuario.Email = viewModel.Email;
                Usuario.Password = Settings.GenerateHash(viewModel.Password);
                Usuario.Role = viewModel.Role;
                await context.SaveChangesAsync();

                return Ok();
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }
        [Authorize(Roles = "adm")]
        [HttpDelete("DeletarConta/{id:int}")]
        public async Task<IActionResult> DeleteAsync(
            [FromServices] AppDbContext context,
            [FromRoute] int id)
        {
            try
            {
                var Conta = await context.Usuario.FindAsync(id);

                if (Conta == null)
                    return NotFound();

                context.Usuario.Remove(Conta);
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
