using GeradorRelatoriosWeb.Dominio.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GeradorRelatoriosWeb.Models
{
    public class UsuarioLogado
    {
        private readonly IHttpContextAccessor _usuario;
        public Guid Id => Guid.Parse(GetClaimsIdentity().FirstOrDefault(a => a.Type == ClaimTypes.NameIdentifier)?.Value);
        public string Nome => GetClaimsIdentity().FirstOrDefault(a => a.Type == ClaimTypes.Name)?.Value;
        public Guid Acesso => Guid.Parse(GetClaimsIdentity().FirstOrDefault(a => a.Type == ClaimTypes.AuthorizationDecision)?.Value);
        public string Aplicacao => GetClaimsIdentity().FirstOrDefault(a => a.Type == ClaimTypes.Sid)?.Value;

        public UsuarioLogado(IHttpContextAccessor usuario)
        {
            _usuario = usuario;
        }

        public IEnumerable<Claim> GetClaimsIdentity()
        {
            return _usuario.HttpContext.User.Claims;
        }
    }
}
