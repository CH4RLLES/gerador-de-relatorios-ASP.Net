using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using GeradorRelatoriosWeb.Dominio.Enums;
using GeradorRelatoriosWeb.Dominio.Utils;
using GeradorRelatoriosWeb.Models;
using GeradorRelatoriosWeb.Models.Cadastros;
using GeradorRelatoriosWeb.Models.Cadastros.Filtros;
using GeradorRelatoriosWeb.Servicos.Servicos;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeradorRelatoriosWeb.Controllers
{
    [Authorize(AuthenticationSchemes = AuthSchemes)]
    public class AdminController : Controller
    {
        private readonly UsuarioLogado _usuario;
        private const string AuthSchemes = CookieAuthenticationDefaults.AuthenticationScheme;

        public AdminController(UsuarioLogado usuario)
        {
            _usuario = usuario;
        }

        [BindProperty]
        public List<string> Selecionados { get; set; }

        [HttpGet]
        public IActionResult CadUsuario()
        {
            if (AcessoNegado("CadUsuario"))
                return View("AcessoNegado");

            ViewBag.Perfis = new PerfilServico().MontaCombo();
            ViewBag.Status = Util.GetEnumToSelectList<EnumStatusAcesso>();

            var usuario = new FiltroUsuario();
            usuario.UsuarioLista = new UsuarioServico().ListarUsuario().OrderBy(a => a.Nome).ToList();
            
            return View(usuario);
        }

        [HttpPost]
        public IActionResult CadUsuario([FromForm] Usuario usuario)
        {
            var ret = false;
            if (usuario.Id.ToString() == "00000000-0000-0000-0000-000000000000")
                ret = new UsuarioServico().Cadastrar(usuario);
            else
                ret = new UsuarioServico().Alterar(usuario);

            ViewBag.Perfis = new PerfilServico().MontaCombo();
            ViewBag.Status = Util.GetEnumToSelectList<EnumStatusAcesso>();

            var filtroUsuario = new FiltroUsuario();
            filtroUsuario.UsuarioLista = new UsuarioServico().ListarUsuario().OrderBy(a => a.Nome).ToList();

            TempData["Messagem"] = ret ? "Usuário salvo com sucesso!" : "Erro ao salvar o usuário!";

            return View(filtroUsuario);
        }

        [HttpGet]
        public IActionResult BuscarCadUsuario(Guid id)
        {
            var ret = new UsuarioServico().Obter(id);

            ViewBag.Perfis = new PerfilServico().MontaCombo();
            ViewBag.Status = Util.GetEnumToSelectList<EnumStatusAcesso>();

            var filtroUsuario = new FiltroUsuario
            {
                Id = id,
                CPF = ret.CPF,
                Email = ret.Email,
                Nome = ret.Nome,
                Senha = ret.Senha,
                IdPerfil = ret.IdPerfil,
                Status = ret.Status,
                UsuarioLista = new UsuarioServico().ListarUsuario().OrderBy(a => a.Nome).ToList()
            };

            return View("CadUsuario", filtroUsuario);
        }

        public IActionResult PaginasPerfil()
        {
            if (AcessoNegado("CadUsuario"))
                return View("AcessoNegado");

            var dados = new PaginasPerfil
            {
                IdsPaginas = new PaginasServico().ListaPaginas().ToArray()
            };
            ViewBag.Perfis = new PerfilServico().MontaCombo();
            return View(dados);
        }

        [HttpPost]
        public IActionResult PaginasPerfil([FromForm] PaginasPerfil paginas)
        {
            var ret = new PerfilPaginasServicos().InserirAtualizar(paginas.IdPerfil, Selecionados);

            var dados = new PaginasPerfil
            {
                IdsPaginas = new PaginasServico().ListaPaginas().ToArray()
            };

            ViewBag.Perfis = new PerfilServico().MontaCombo();
            TempData["Messagem"] = ret ? "Usuário salvo com sucesso!" : "Erro ao salvar o usuário!";
            return View(dados);
        }

        [HttpGet]
        public IActionResult CadPaginas()
        {
            if (AcessoNegado("CadUsuario"))
                return View("AcessoNegado");

            var pagina = new FiltroPaginasAcesso();
            pagina.PaginasAcessoLista = new PaginasServico().ListaPaginas().OrderBy(a => a.NomeMenu).ToList();
            return View(pagina);
        }

        [HttpPost]
        public IActionResult CadPaginas([FromForm] PaginasAcesso pagina)
        {
            var ret = false;
            if (pagina.Id.ToString() == "00000000-0000-0000-0000-000000000000")
                ret = new PaginasServico().Cadastrar(pagina);
            else
                ret = new PaginasServico().Alterar(pagina);

            var filtroPagina = new FiltroPaginasAcesso();
            filtroPagina.PaginasAcessoLista = new PaginasServico().ListaPaginas().OrderBy(a => a.NomeMenu).ToList();
            TempData["Messagem"] = ret ? "Página salva com sucesso!" : "Erro ao salvar a Página!";
            return View(filtroPagina);
        }

        [HttpGet]
        public IActionResult BuscarCadPaginas(Guid id)
        {
            var ret = new PaginasServico().Obter(id);
            var filtroPaginasAcesso = new FiltroPaginasAcesso
            {
                Id = id,
                NomeMenu = ret.NomeMenu,
                View = ret.View,
                Controller = ret.Controller,
                Desativado = ret.Desativado,
                PaginasAcessoLista = new PaginasServico().ListaPaginas().OrderBy(a => a.NomeMenu).ToList()
            };
            return View("CadPaginas", filtroPaginasAcesso);
        }

        [HttpGet]
        public IActionResult CadPerfil()
        {
            if (AcessoNegado("CadUsuario"))
                return View("AcessoNegado");

            var perfil = new FiltroPerfilAcesso();
            perfil.PerfilAcessoLista = new PerfilServico().ListarPerfil().OrderBy(a => a.Nome).ToList();
            return View(perfil);
        }

        [HttpPost]
        public IActionResult CadPerfil([FromForm] PerfilAcesso perfil)
        {
            var ret = false;
            if (perfil.Id.ToString() == "00000000-0000-0000-0000-000000000000")
                ret = new PerfilServico().Cadastrar(perfil);
            else
                ret = new PerfilServico().Alterar(perfil);

            var filtroPerfil = new FiltroPerfilAcesso();
            filtroPerfil.PerfilAcessoLista = new PerfilServico().ListarPerfil().OrderBy(a => a.Nome).ToList();
            TempData["Messagem"] = ret ? "Perfil salvo com sucesso!" : "Erro ao salvar o Perfil!";
            return View(filtroPerfil);
        }

        [HttpGet]
        public IActionResult BuscarCadPerfil(Guid id)
        {
            var ret = new PerfilServico().Obter(id);
            var FiltroPerfilAcesso = new FiltroPerfilAcesso
            {
                Id = id,
                Nome = ret.Nome,
                PerfilAcessoLista = new PerfilServico().ListarPerfil().OrderBy(a => a.Nome).ToList()
            };
            return View("CadPerfil", FiltroPerfilAcesso);
        }
        private bool AcessoNegado(string view)
        {
            return !new UsuarioServico().VerAcesso("Admin", view, _usuario.Id);
        }
    }
}