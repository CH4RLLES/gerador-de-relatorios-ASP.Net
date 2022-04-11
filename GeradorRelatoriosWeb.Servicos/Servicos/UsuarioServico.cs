using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using GeradorRelatoriosWeb.Dominio.Enums;
using GeradorRelatoriosWeb.Dominio.Utils;
using GeradorRelatoriosWeb.Infra.Dados.Contexto;
using GeradorRelatoriosWeb.Servicos.Validacoes;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeradorRelatoriosWeb.Servicos.Servicos
{
    public class UsuarioServico : ServicoBase<Usuario>
    {
        public Usuario EfetuarLogin(Usuario login)
        {
            try
            {
                var usuario = Listar(a => a.CPF.Replace(".", "").Replace("-", "") == login.CPF.Replace(".", "").Replace("-", "")).FirstOrDefault();

                if (usuario == null)
                {
                    login.Status = EnumStatusAcesso.NaoCadastrado;
                    return login;
                }

                if (usuario.Senha != Util.GerarHash(login.Senha))
                {
                    usuario.Status = EnumStatusAcesso.SenhaIncorreta;
                    return usuario;
                }

                return usuario;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool VeirifcaSenha(Guid idUsuario, string senha)
        {
            try
            {
                var usuario = Obter(idUsuario);

                if (usuario.Senha != Util.GerarHash(senha))
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AlterarSenha(Usuario usuario, string novaSenha)
        {
            try
            {
                usuario.Senha = Util.GerarHash(novaSenha);
                Editar<UsuarioValidation>(usuario);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Cadastrar(Usuario usuario)
        {
            try
            {
                usuario.Id = Guid.NewGuid();
                usuario.Token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJNYXJpbyBSb3NzaSIsImVtYWlsIjoibWFyaW8ucm9zc2lAZG9tYWluLmNvbSIsImJpcnRoZGF0ZSI6IjE5" +
                                "ODMtMDktMjMiLCJqdGkiOiJmZjQ0YmVjOC03ZDBkLTQ3ZTEtOWJjZC03MTY4NmQ5Nzk3NzkiLCJleHAiOjE1MTIzMjIxNjgsImlzcyI6Imh0dHA6Ly9sb2NhbGhvc3Q6N" +
                                "jM5MzkvIiwiYXVkIjoiaHR0cDovL2xvY2FsaG9zdDo2MzkzOS8ifQ.9qyvnhDna3gEiGcd_ngsXZisciNOy55RjBP4ENSGfYI";
                usuario.Senha = Util.GerarHash(usuario.Senha);
                Inserir<UsuarioValidation>(usuario);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Alterar(Usuario usuario)
        {
            try
            {
                usuario.Token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJNYXJpbyBSb3NzaSIsImVtYWlsIjoibWFyaW8ucm9zc2lAZG9tYWluLmNvbSIsImJpcnRoZGF0ZSI6IjE5" +
                                "ODMtMDktMjMiLCJqdGkiOiJmZjQ0YmVjOC03ZDBkLTQ3ZTEtOWJjZC03MTY4NmQ5Nzk3NzkiLCJleHAiOjE1MTIzMjIxNjgsImlzcyI6Imh0dHA6Ly9sb2NhbGhvc3Q6N" +
                                "jM5MzkvIiwiYXVkIjoiaHR0cDovL2xvY2FsaG9zdDo2MzkzOS8ifQ.9qyvnhDna3gEiGcd_ngsXZisciNOy55RjBP4ENSGfYI";
                usuario.Senha = usuario.Senha;
                Editar<UsuarioValidation>(usuario);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool VerAcesso(string controller, string view, Guid idUsuario)
        {
            try
            {
                var idPagina = new PaginasServico().Listar(a => a.View == view && a.Controller == controller).FirstOrDefault().Id;
                return VerExiste(a => a.Id == idUsuario && a.Perfil.Paginas.Count(b => b.IdPagina == idPagina) > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Usuario> ListarUsuario()
        {
            try
            {
                return ListarTodosInclude("Perfil").ToList();
            }
            catch (Exception Ex)
            {
                return null;
            }
        }
    }
}
