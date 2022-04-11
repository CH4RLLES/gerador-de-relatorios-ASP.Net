using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using GeradorRelatoriosWeb.Servicos.Validacoes;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeradorRelatoriosWeb.Servicos.Servicos
{
    public class PerfilServico : ServicoBase<PerfilAcesso>
    {
        public bool Cadastrar(PerfilAcesso perfil)
        {
            try
            {
                perfil.Id = Guid.NewGuid();
                Inserir<PerfilValidation>(perfil);
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        public List<PerfilAcesso> ListarPerfil()
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

        public bool Alterar(PerfilAcesso perfil)
        {
            try
            {
                Editar<PerfilValidation>(perfil);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public SelectList MontaCombo()
        {
            return new SelectList(ListarTodos(), "Id", "Nome");
        }
    }
}
