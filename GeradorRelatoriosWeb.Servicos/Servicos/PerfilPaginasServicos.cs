using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using GeradorRelatoriosWeb.Servicos.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeradorRelatoriosWeb.Servicos.Servicos
{
    public class PerfilPaginasServicos : ServicoBase<PerfilPaginas>
    {
        public List<Guid> ListaPaginasPorPerfil(Guid perfil)
        {
            try
            {
                return Listar(a => a.IdPerfil == perfil).Select(a => a.IdPagina).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool InserirAtualizar(Guid perfil, List<string> paginas)
        {
            try
            {
                var novos = new List<PerfilPaginas>();

                Delete(a => a.IdPerfil == perfil);

                foreach (var item in paginas)
                {
                    var pagina = new PerfilPaginas
                    {
                        IdPagina = Guid.Parse(item),
                        IdPerfil = perfil
                    };

                    novos.Add(pagina);
                }

                InserirLista(novos);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
