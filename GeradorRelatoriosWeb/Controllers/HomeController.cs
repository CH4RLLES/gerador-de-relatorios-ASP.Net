using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GeradorRelatoriosWeb.Models;
using Microsoft.AspNetCore.Http;

namespace GeradorRelatoriosWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly UsuarioLogado _usuario;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeController(IHttpContextAccessor httpContextAccessor, UsuarioLogado usuario)
        {
            _usuario = usuario;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            var context = _httpContextAccessor.HttpContext.Request.Host.ToString();

            if (context.Contains("dftype00101m"))
                return RedirectPermanent("http://dfcpt000407d.intra.dnit/GeradorRelsWeb/");

            return View();
        }

        public IActionResult Login()
        {
            var context = _httpContextAccessor.HttpContext.Request.Host.ToString();

            if (context.Contains("dftype00101m"))
                return RedirectPermanent("http://dfcpt000407d.intra.dnit/GeradorRelsWeb/");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
