using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using GeradorRelatoriosWeb.Infra.Dados.Contexto;
using GeradorRelatoriosWeb.Servicos.Validacoes;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeradorRelatoriosWeb.Servicos.Servicos
{
    public class PaginasServico : ServicoBase<PaginasAcesso>
    {
        public bool Cadastrar(PaginasAcesso pagina)
        {
            try
            {
                pagina.Id = Guid.NewGuid();
                Inserir<PaginasValidation>(pagina);
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        public List<PaginasAcesso> ListaPaginas()
        {
            try
            {
                return ListarTodos().ToList();
            }
            catch (Exception Ex)
            {
                return null;
            }
        }

        public bool Alterar(PaginasAcesso pagina)
        {
            try
            {
                Editar<PaginasValidation>(pagina);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
