using JRShop.Dominio.Entidades;
using JRShop.Dominio.Interfaces;
using JRShop.Dominio.Modelos;
using JRShop.Dominio.Validacoes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace JRShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        //Método que cadastra um usuário
        [HttpPost]
        [Route("cadastrarUsuario")]
        public IActionResult CadastrarUsuario([FromServices] IUsuario repositorio,
            [FromBody] UsuarioModelo adicionarUsuario)
        {
            //Verificação se senhas são iguais
            if (adicionarUsuario.Senha != adicionarUsuario.ConfirmaSenha)
            {
                return NotFound("Senhas não conferem");
            }

            //Criação de um usuário
            var usuario = new Usuario(adicionarUsuario.Nome,
                adicionarUsuario.Email,
                adicionarUsuario.Senha);

            //Verificação se usuário está tudo ok
            var validacao = new ValidacaoUsuario().Validate(usuario);
            
            //Encriptação da senha
            usuario.Encriptar();

            //Salvar no banco
            if (validacao.IsValid)
            {
                repositorio.Add(usuario);
                repositorio.SaveChanges();
                return Ok(usuario);
            }

            return Ok(validacao.Errors);

        }


        [HttpPost]
        [Route("loginUsuario")]
        public async Task<IActionResult> LoginUsuario(
            [FromServices] IUsuario repositorio, 
            [FromBody] LoginModelo loginModelo)
        {
            var result = repositorio.ObterUsuarioPeloNome(loginModelo.Email, loginModelo.Senha);

            if (result == true)
            {
                return Ok("Usuario Logado com Sucesso");
            }

            return NotFound("Senha ou Login Incorreto");
        }
        
        [HttpDelete]
        [Route("removeUsuario")]
        public async Task<IActionResult> RemoveUsuario(
            [FromServices] IUsuario repositorio,
            [FromBody] Guid id)
        {
            if (id != null)
            {
                repositorio.Remove(id);
                repositorio.SaveChanges();
                return Ok();
            }
            return NotFound();
            
        }


    }
}
