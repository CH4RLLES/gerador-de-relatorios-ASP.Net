using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeradorRelatoriosWeb.Servicos.Servicos;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeradorRelatoriosWeb.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = AuthSchemes)]
    public class ApiGeradorController : Controller
    {
        private const string AuthSchemes = CookieAuthenticationDefaults.AuthenticationScheme; // + "," + JwtBearerDefaults.AuthenticationScheme;

        [Route("ValidasPorHora")]
        [HttpGet]
        public IActionResult ValidasPorHora(string dia)
        {
            var data = DateTime.Parse(dia);
            var ret = new ValidasInvalidasServicos().ImngsValidasInvalidasPorHora(data);
            return Json(ret);
        }

        [Route("ValidasPorOperadora")]
        [HttpGet]
        public IActionResult ValidasPorOperadora(string dia)
        {
            var data = DateTime.Parse(dia);
            var ret = new ValidasInvalidasServicos().ImngsValidasInvalidasPorOperadora(data);
            return Json(ret);
        }

        [Route("DetalheExcessoPeso")]
        [HttpGet]
        public IActionResult DetalheExcessoPeso(string numeroAit)
        {
            var dados = new InfracoesServicos().BuscaExcessoPesoDetalhado(numeroAit);
            return PartialView("../Gerador/Partials/_DetalheExcessoPeso", dados);
        }

        [Route("ListaPaginasPorPerfil")]
        [HttpGet]
        public IActionResult ListaPaginasPorPerfil(Guid perfil)
        {
            var ret = new PerfilPaginasServicos().ListaPaginasPorPerfil(perfil);
            return Json(ret);
        }

        [Route("VerificaSenhaAtual")]
        [HttpGet]
        public IActionResult VerificaSenhaAtual(Guid idUsuario, string senha)
        {
            var ret = new UsuarioServico().VeirifcaSenha(idUsuario, senha);
            return Json(ret);
        }
    }
}