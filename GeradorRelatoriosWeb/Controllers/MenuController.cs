using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using GeradorRelatoriosWeb.Models;
using GeradorRelatoriosWeb.Servicos.Servicos;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeradorRelatoriosWeb.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = AuthSchemes)]
    public class MenuController : Controller
    {
        private readonly UsuarioLogado _usuario;
        private const string AuthSchemes = CookieAuthenticationDefaults.AuthenticationScheme;

        public MenuController(UsuarioLogado usuario)
        {
            _usuario = usuario;
        }

        [Route("MontaMenu")]
        [HttpGet]
        public IActionResult MontaMenu()
        {
            var paginas = new UsuarioServico().ObterIncludes(a => a.Id == _usuario.Id, "Perfil.Paginas.Pagina");

            if (paginas.Perfil.Paginas == null)
                paginas.Perfil.Paginas = new List<PerfilPaginas>();

            foreach (var item in paginas.Perfil.Paginas)
            {
                if (item.Pagina.Desativado)
                    paginas.Perfil.Paginas.Remove(item);
            }

            return PartialView("../Gerador/Partials/_Menu", paginas);
        }
    }
}