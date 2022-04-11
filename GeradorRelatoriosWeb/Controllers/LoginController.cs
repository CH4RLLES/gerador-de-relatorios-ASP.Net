using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using GeradorRelatoriosWeb.Dominio.Enums;
using GeradorRelatoriosWeb.Models;
using GeradorRelatoriosWeb.Servicos.Servicos;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace GeradorRelatoriosWeb.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Login([Bind] Usuario usuario, [FromServices]TokenConfigurations config, [FromServices]SigningConfigurations signing)
        {
            var appValido = true; // new AplicacaoServico().VerExiste(a => a.Ativo && a.Nome == config.NomeApp && a.Token == config.TokenApp);
            if (!appValido)
            {
                TempData["LoginUsuarioFalhou"] = "O login Falhou. Esta aplicação não está autorizada a acessar o sistema.";
                return RedirectToAction("Login", "Home");
            }

            var usu = new UsuarioServico().EfetuarLogin(usuario);
            if (usu.Status == EnumStatusAcesso.Ativo)
            {
                ClaimsIdentity identity = new ClaimsIdentity(
                    new GenericIdentity(config.TokenApp, "App"),
                    new[] {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                        new Claim(JwtRegisteredClaimNames.Sub, config.TokenApp),
                        new Claim(JwtRegisteredClaimNames.Typ, config.NomeApp)
                    }
                );

                DateTime dataCriacao = DateTime.Now;
                DateTime dataExpiracao = dataCriacao +
                    TimeSpan.FromSeconds(config.Seconds);

                var handler = new JwtSecurityTokenHandler();
                var securityToken = handler.CreateToken(new SecurityTokenDescriptor
                {
                    Issuer = config.Issuer,
                    Audience = config.Audience,
                    SigningCredentials = signing.SigningCredentials,
                    Subject = identity,
                    NotBefore = dataCriacao,
                    Expires = dataExpiracao
                });
                var token = handler.WriteToken(securityToken);

                usu.Token = token;

                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, usu.Id.ToString()),
                        new Claim(ClaimTypes.Name, usu.Nome),
                        new Claim(ClaimTypes.AuthorizationDecision, usu.IdPerfil.ToString()),
                        new Claim(ClaimTypes.Sid, config.NomeApp),
                        new Claim(ClaimTypes.Actor, usu.Token),
                    };

                ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(principal, new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(20)
                });

                return RedirectToAction("Index", "Gerador");
            }
            else
            {
                TempData["LoginUsuarioFalhou"] = "O login Falhou. " + usu.Status.GetEnumDescription();
                return RedirectToAction("Login", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}