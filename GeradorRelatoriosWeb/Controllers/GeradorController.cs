using GeradorRelatoriosWeb.Dominio.Models;
using GeradorRelatoriosWeb.Models;
using GeradorRelatoriosWeb.Models.Filtros;
using GeradorRelatoriosWeb.Servicos.Servicos;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Controllers
{
    [Authorize(AuthenticationSchemes = AuthSchemes)]
    public class GeradorController : Controller
    {
        private readonly UsuarioLogado _usuario;
        private const string AuthSchemes = CookieAuthenticationDefaults.AuthenticationScheme; // + "," + JwtBearerDefaults.AuthenticationScheme;

        public GeradorController(UsuarioLogado usuario)
        {
            _usuario = usuario;
        }

        public IActionResult Index()
        {
            return View(_usuario);
        }

        public IActionResult PNCV()
        {
            if (AcessoNegado("PNCV"))
                return View("AcessoNegado");

            return View(new FiltroPNCV());
        }

        [HttpPost]
        public IActionResult ListarPNCV([FromForm] FiltroPNCV filtro)
        {
            filtro.RetornoPNCVs = new PNCV168Servico().ListarPNVC(filtro.DataInicio, filtro.DataFim, filtro.TipoVeiculo, filtro.Equipamento, filtro.Lote);
            return View("PNCV", filtro);
        }

        [HttpPost]
        public FileResult ExportarPNCV([FromForm] FiltroPNCV filtro)
        {
            string nomeArquivo = $"PNCV-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new PNCV168Servico().ExportarPNVC(filtro.DataInicio, filtro.DataFim, filtro.TipoVeiculo, filtro.Equipamento, filtro.Lote);
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }

        public IActionResult EntradaProcessos()
        {
            if (AcessoNegado("EntradaProcessos"))
                return View("AcessoNegado");

            return View(new FiltroProcessosSIOR());
        }

        [HttpPost]
        public IActionResult ListarEntradaProcessos([FromForm] FiltroProcessosSIOR filtro)
        {
            if (filtro.ComArquivo)
                filtro.ProcessosSIOR = new ProcessosServicos().BuscaRegistrosProcessosSIORComArquivo(filtro.DataInicio, filtro.DataFim);
            else
                filtro.ProcessosSIOR = new ProcessosServicos().BuscaRegistrosProcessosSIOR(filtro.DataInicio, filtro.DataFim);

            return View("EntradaProcessos", filtro);
        }

        [HttpPost]
        public FileResult ExportarEntradaProcessos([FromForm] FiltroProcessosSIOR filtro)
        {
            string nomeArquivo = $"EntradaProcessos-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            if (filtro.ComArquivo)
            {
                var ret = new ProcessosServicos().ExportarRegistrosProcessosSIORComArquivo(filtro.DataInicio, filtro.DataFim);
                return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
            }
            else
            {
                var ret = new ProcessosServicos().ExportarRegistrosProcessosSIOR(filtro.DataInicio, filtro.DataFim);
                return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
            }
        }

        public IActionResult ExcessoPeso()
        {
            if (AcessoNegado("ExcessoPeso"))
                return View("AcessoNegado");

            return View(new FiltroExcessoPeso());
        }

        [HttpPost]
        public IActionResult ListarExcessoPeso([FromForm] FiltroExcessoPeso filtro)
        {
            filtro.ExcessoPesoLista = new InfracoesServicos().BuscaExcessoPesoLista(filtro.DataInicio, filtro.DataFim, filtro.CNPJ);
            return View("ExcessoPeso", filtro);
        }

        [HttpPost]
        public FileResult ExportarExcessoPeso([FromForm] FiltroExcessoPeso filtro)
        {
            string nomeArquivo = $"ExcessoPeso-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new InfracoesServicos().ExportaExcessoPeso(filtro.DataInicio, filtro.DataFim, filtro.CNPJ);
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }

        public IActionResult ValidasInvalidas()
        {
            if (AcessoNegado("ValidasInvalidas"))
                return View("AcessoNegado");

            return View(new FiltroValidasInvalidas());
        }

        [HttpPost]
        public IActionResult ListarValidasInvalidas([FromForm] FiltroValidasInvalidas filtro)
        {
            filtro.ValidasInvalidas = new ValidasInvalidasServicos().BuscaRegistrosImngsValidasInvalidas(filtro.DataInicio, filtro.DataFim);
            return View("ValidasInvalidas", filtro);
        }

        public IActionResult ImagensEngenharia()
        {
            if (AcessoNegado("ImagensEngenharia"))
                return View("AcessoNegado");

            return View(new FiltroCompletoEngenharia());
        }

        [HttpPost]
        public IActionResult ListarImagensEngenharia([FromForm] FiltroCompletoEngenharia filtro)
        {
            filtro.ComplementoEngenhariaLista = new CompletoEngenhariaServicos().BuscaRegistrosCompletoEngenharia(filtro.DataInicio, filtro.DataFim);
            return View("ImagensEngenharia", filtro);
        }

        [HttpPost]
        public FileResult ExportarImagensEngenharia([FromForm] FiltroCompletoEngenharia filtro)
        {
            string nomeArquivo = $"ImagensEngenharia-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new CompletoEngenhariaServicos().ExportarRegistrosCompletoEngenharia(filtro.DataInicio, filtro.DataFim);
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }

        public IActionResult SituacaoRecursos()
        {
            if (AcessoNegado("SituacaoRecursos"))
                return View("AcessoNegado");

            return View(new FiltroSituacaoRecursos());
        }

        [HttpPost]
        public IActionResult ListarSituacaoRecursos([FromForm] FiltroSituacaoRecursos filtro)
        {
            filtro.RecursosJariLista = new RecursosServicos().BuscaRecursosJari(filtro.DataInicio, filtro.DataFim, filtro.DataReferencia);
            return View("SituacaoRecursos", filtro);
        }

        [HttpPost]
        public FileResult ExportarSituacaoRecursos([FromForm] FiltroSituacaoRecursos filtro)
        {
            string nomeArquivo = $"SituacaoRecursos-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new RecursosServicos().ExportarRecursosJari(filtro.DataInicio, filtro.DataFim, filtro.DataReferencia);
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }

        public IActionResult ProcessosRealizados()
        {
            if (AcessoNegado("ProcessosRealizados"))
                return View("AcessoNegado");

            return View(new FiltroProcessosSIOR());
        }

        [HttpPost]
        public IActionResult ListarProcessosRealizados([FromForm] FiltroProcessosSIOR filtro)
        {
            filtro.ProcessosSIOR = new ProcessosServicos().BuscaProcessosRealizadosSIOR(filtro.DataInicio, filtro.DataFim);
            return View("ProcessosRealizados", filtro);
        }

        [HttpPost]
        public FileResult ExportarProcessosRealizados([FromForm] FiltroProcessosSIOR filtro)
        {
            string nomeArquivo = $"ProcessosRealizados-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new ProcessosServicos().ExportarProcessosRealizadosSIOR(filtro.DataInicio, filtro.DataFim);
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }

        public IActionResult ResumoEquipamentos()
        {
            if (AcessoNegado("ResumoEquipamentos"))
                return View("AcessoNegado");

            var combos = new ResumoEquipamentosServicos().GerarCombos();
            ViewBag.Editais = combos[0];
            ViewBag.Situacoes = combos[1];
            return View(new FiltroResumoEquipamentos());
        }

        [HttpPost]
        public IActionResult ListarResumoEquipamentos([FromForm] FiltroResumoEquipamentos filtro)
        {
            var combos = new ResumoEquipamentosServicos().GerarCombos();
            ViewBag.Editais = combos[0];
            ViewBag.Situacoes = combos[1];
            filtro.ResumoEquipamentosLista = new ResumoEquipamentosServicos().ResumoEquipamentos(filtro.Edital, filtro.Situacao);
            return View("ResumoEquipamentos", filtro);  
        }

        [HttpPost]
        public FileResult ExportarResumoEquipamentos([FromForm] FiltroResumoEquipamentos filtro)
        {
            string nomeArquivo = $"ResumoEquipamentos-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new ResumoEquipamentosServicos().ExportarResumoEquipamentos(filtro.Edital, filtro.Situacao);
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }

        public IActionResult Lic4()
        {
            if (AcessoNegado("Lic4"))
                return View("AcessoNegado");

            return View(new FiltroPNCV());
        }

        [HttpPost]
        public IActionResult ListarLic4([FromForm] FiltroPNCV filtro)
        {
            filtro.RetornoPNCVs = new Lic4Servicos().BuscaRegistrosPNVCLIC4(filtro.DataInicio, filtro.DataFim, filtro.TipoVeiculo, filtro.Equipamento);
            return View("Lic4", filtro);
        }

        [HttpPost]
        public FileResult ExportarLic4([FromForm] FiltroPNCV filtro)
        {
            string nomeArquivo = $"Lic4-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new Lic4Servicos().ExportarPNVCLIC4(filtro.DataInicio, filtro.DataFim, filtro.TipoVeiculo, filtro.Equipamento);
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }

        public IActionResult JulgamentosJari()
        {
            if (AcessoNegado("JulgamentosJari"))
                return View("AcessoNegado");

            return View(new FiltroJulgamentosJari());
        }

        [HttpPost]
        public IActionResult ListarJulgamentosJari([FromForm] FiltroJulgamentosJari filtro)
        {
            filtro.RetornoJulgamentosJari = new JulgamentosJariServicos().BuscaJulgamentosJari(filtro.DataInicio, filtro.DataFim);
            return View("JulgamentosJari", filtro);
        }

        [HttpPost]
        public FileResult ExportarJulgamentosJari([FromForm] FiltroJulgamentosJari filtro)
        {
            string nomeArquivo = $"JulgamentosJari-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new JulgamentosJariServicos().ExportarJulgamentosJari(filtro.DataInicio, filtro.DataFim);
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }

        public IActionResult AlterarSenha()
        {
            if (AcessoNegado("AlterarSenha"))
                return View("AcessoNegado");

            var filtro = new FiltroAlterarSenha();
            filtro.Id = _usuario.Id;
            return View(filtro);
        }

        [HttpPost]
        public IActionResult AlterarSenha([FromForm] FiltroAlterarSenha senha)
        {
            var usuario = new UsuarioServico().Obter(senha.Id);
            var ret = new UsuarioServico().AlterarSenha(usuario, senha.NovaSenha);         
            TempData["Messagem"] = ret ? "Senha salva com sucesso!" : "Erro ao salvar a Senha!";
            return View(new FiltroAlterarSenha());
        }

        public IActionResult MedicaoSR()
        {
            if (AcessoNegado("MedicaoSR"))
                return View("AcessoNegado");

            return View(new FiltroMedicaoSR());
        }

        [HttpPost]
        public IActionResult ListarMedicaoSR([FromForm] FiltroMedicaoSR filtro)
        {
            filtro.RetornoMedicaoSR = new InfracoesServicos().BuscarInfracoesSR(filtro.DataInicio,filtro.DataFim);
            return View("MedicaoSR", filtro);
        }

        [HttpPost]
        public FileResult ExportarMedicaoSR([FromForm] FiltroMedicaoSR filtro)
        {
            string nomeArquivo = $"MedicaoSR-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new InfracoesServicos().ExportarMedicaoSR(filtro.DataInicio, filtro.DataFim);
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }

        private bool AcessoNegado(string view)
        {
            return !new UsuarioServico().VerAcesso("Gerador", view, _usuario.Id);
        }

        public IActionResult CancelamentoAutoInfracao()
        {
            if (AcessoNegado("CancelamentoAutoInfracao"))
                return View("AcessoNegado");

            return View(new FiltroCancelamentoAutoInfracao());
        }

        [HttpPost]
        public IActionResult ListarCancelamentoAutoInfracao([FromForm] FiltroCancelamentoAutoInfracao filtro)
        {
            filtro.RetornoCancelamentoAutoInfracao = new CancelamentoAutoInfracaoServicos().BuscaCancelamentoAutoInfracao(filtro.DataInicio, filtro.DataFim);
            return View("CancelamentoAutoInfracao", filtro);
        }

        [HttpPost]
        public FileResult ExportarCancelamentoAutoInfracao([FromForm] FiltroCancelamentoAutoInfracao filtro)
        {
            string nomeArquivo = $"CancelamentoAutoInfracao-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new CancelamentoAutoInfracaoServicos().ExportarCancelamentoAutoInfracao(filtro.DataInicio, filtro.DataFim);
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }

        public IActionResult MedicaoImagens()
        {
            if (AcessoNegado("MedicaoImagens"))
                return View("AcessoNegado");

            return View(new FiltroValidasInvalidas());
        }

        [HttpPost]
        public IActionResult ListarMedicaoImagens([FromForm] FiltroValidasInvalidas filtro)
        {
            filtro.ValidasInvalidas = new ValidasInvalidasServicos().BuscaMedicaoImagens(filtro.DataInicio, filtro.DataFim);
            return View("MedicaoImagens", filtro);
        }

        public IActionResult ProcessosInstruir()
        {
            if (AcessoNegado("ProcessosInstruir"))
                return View("AcessoNegado");

            return View(new RetornoProcessosInstruir());
        }

        [HttpPost]
        public IActionResult ListarProcessosInstruir([FromForm] RetornoProcessosInstruir retorno)
        {
            retorno = new ProcessosServicos().BuscaProcessosInstruir();
            return View("ProcessosInstruir", retorno);
        }

        [HttpPost]
        public FileResult ExportarProcessosInstruir([FromForm] RetornoProcessosInstruir retorno)
        {
            string nomeArquivo = $"ProcessosInstruir-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new ProcessosServicos().ExportarProcessosInstruir();
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }

        public IActionResult RecursosJulgados()
        {
            if (AcessoNegado("RecursosJulgados"))
                return View("AcessoNegado");

            var anos = new List<int>();
            for (int i = 2010; i <= DateTime.Now.Year; i++)
            {
                anos.Add(i);
            }

            ViewBag.ComboAno = new SelectList(anos);

            return View(new FiltroRecursosJulgados());
        }

        [HttpPost]
        public IActionResult ListarRecursosJulgados([FromForm] FiltroRecursosJulgados filtro)
        {
            var anos = new List<int>();
            for (int i = 2010; i <= DateTime.Now.Year; i++)
            {
                anos.Add(i);
            }

            ViewBag.ComboAno = new SelectList(anos);

            filtro.RetornoRecursosJulgados = new RecursosServicos().BuscaRecursosJulgados(filtro.Ano);
            return View("RecursosJulgados", filtro);
        }

        [HttpPost]
        public FileResult ExportarRecursosJulgados([FromForm] FiltroRecursosJulgados filtro)
        {
            string nomeArquivo = $"RecursosJulgados-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new RecursosServicos().ExportarRecursosJulgados(filtro.Ano);
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }

        public IActionResult Tempestividade()
        {
            if (AcessoNegado("Tempestividade"))
                return View("AcessoNegado");

            return View(new FiltroTempestividade());
        }

        [HttpPost]
        public IActionResult ListarTempestividade([FromForm] FiltroTempestividade filtro)
        {
            filtro.TempestividadeLista = new RecursosServicos().BuscaTempestividade(filtro.DataInicio, filtro.DataFim, filtro.DataReferencia);
            return View("Tempestividade", filtro);
        }

        [HttpPost]
        public FileResult ExportarTempestividade([FromForm] FiltroTempestividade filtro)
        {
            string nomeArquivo = $"Tempestividade-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new RecursosServicos().ExportarTempestividade(filtro.DataInicio, filtro.DataFim, filtro.DataReferencia);
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }

        public IActionResult PendentesPreparacao()
        {
            if (AcessoNegado("PendentesPreparacao"))
                return View("AcessoNegado");

            return View(new FiltroPendentesPreparacao());
        }

        [HttpPost]
        public IActionResult ListarPendentesPreparacao([FromForm] FiltroPendentesPreparacao filtro)
        {
            filtro.PendentesPreparacao = new PreAutuacaoServicos().BuscaPendentesPreparacao(filtro.DiasPendentes);
            return View("PendentesPreparacao", filtro);
        }

        [HttpPost]
        public FileResult ExportarPendentesPreparacao([FromForm] FiltroPendentesPreparacao filtro)
        {
            string nomeArquivo = $"PendentesPreparacao-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new PreAutuacaoServicos().ExportarPendentesPreparacao(filtro.DiasPendentes);
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }

        public IActionResult ValoresRecolhidos()
        {
            if (AcessoNegado("ValoresRecolhidos"))
                return View("AcessoNegado");

            return View(new FiltroValoresRecolhidos());
        }

        [HttpPost]
        public IActionResult ListarValoresRecolhidos([FromForm] FiltroValoresRecolhidos filtro)
        {
            filtro.RetornoValoresRecolhidos = new ValoresRecolhidosServicos().BuscaValoresRecolhidos(filtro.DataInicio, filtro.DataFim);
            return View("ValoresRecolhidos", filtro);
        }

        [HttpPost]
        public FileResult ExportarValoresRecolhidos([FromForm] FiltroValoresRecolhidos filtro)
        {
            string nomeArquivo = $"ValoresRecolhidos-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new ValoresRecolhidosServicos().ExportarValoresRecolhidos(filtro.DataInicio, filtro.DataFim);
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }

        public IActionResult ValoresRecolhidosDnit()
        {
            if (AcessoNegado("ValoresRecolhidosDnit"))
                return View("AcessoNegado");

            return View(new FiltroValoresRecolhidosDnit());
        }

        [HttpPost]
        public IActionResult ListarValoresRecolhidosDnit([FromForm] FiltroValoresRecolhidosDnit filtro)
        {
            filtro.RetornoValoresRecolhidosDnit = new ValoresRecolhidosServicos().BuscaValoresRecolhidosDnit(filtro.DataInicio, filtro.DataFim);
            return View("ValoresRecolhidosDnit", filtro);
        }

        [HttpPost]
        public FileResult ExportarValoresRecolhidosDnit([FromForm] FiltroValoresRecolhidosDnit filtro)
        {
            string nomeArquivo = $"ValoresRecolhidosDnit-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new ValoresRecolhidosServicos().ExportarValoresRecolhidosDnit(filtro.DataInicio, filtro.DataFim);
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }

        public IActionResult ValoresNAsNPs()
        {
            if (AcessoNegado("ValoresNAsNPs"))
                return View("AcessoNegado");

            return View(new FiltroNAsNPs());
        }

        [HttpPost]
        public IActionResult ListarValoresNAsNPs([FromForm] FiltroNAsNPs filtro)
        {
            filtro.ListaNAsNPs = new ValoresNAsNPsServicos().BuscaValoresNAsNPs(filtro.DataInicio, filtro.DataFim);
            return View("ValoresNAsNPs", filtro);
        }

        [HttpPost]
        public FileResult ExportarValoresNAsNPs([FromForm] FiltroNAsNPs filtro)
        {
            string nomeArquivo = $"ValoresNAsNPs-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new ValoresNAsNPsServicos().ExportarValoresNAsNPs(filtro.DataInicio, filtro.DataFim);
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }

        public IActionResult EstudosTecnicos()
        {
            if (AcessoNegado("EstudosTecnicos"))
                return View("AcessoNegado");

            return View(new RetornoEstudosTecnicos());
        }

        [HttpPost]
        public IActionResult ListarEstudosTecnicos([FromForm] RetornoEstudosTecnicos retorno)
        {
            retorno.ListaEstudosTecnicos = new EstudosTecnicosServicos().BuscaEstudosTecnicos();
            return View("EstudosTecnicos", retorno);
        }

        [HttpPost]
        public FileResult ExportarEstudosTecnicos([FromForm] RetornoEstudosTecnicos retorno)
        {
            string nomeArquivo = $"EstudosTecnicos-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new EstudosTecnicosServicos().ExportarEstudosTecnicos();
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }

        public IActionResult LevantamentoDeConferencia()
        {
            if (AcessoNegado("LevantamentoDeConferencia"))
                return View("AcessoNegado");

            return View(new FiltroLevantamentoDeConferencia());
        }

        [HttpPost]
        public IActionResult ListarLevantamentoDeConferencia([FromForm] FiltroLevantamentoDeConferencia filtro)
        {
            filtro.RetornoLevantamentoDeConferencia = new LevantamentoDeConferenciaServicos().BuscaLevantamentoDeConferencia(filtro.DataInicio, filtro.DataFim);
            return View("LevantamentoDeConferencia", filtro);
        }

        [HttpPost]
        public FileResult ExportarLevantamentoDeConferencia([FromForm] FiltroLevantamentoDeConferencia filtro)
        {
            string nomeArquivo = $"LevantamentoDeConferencia-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new LevantamentoDeConferenciaServicos().ExportarLevantamentoDeConferencia(filtro.DataInicio, filtro.DataFim);
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }

        public IActionResult MediaDiasParaInstrucao()
        {
            if (AcessoNegado("MediaDiasParaInstrucao"))
                return View("AcessoNegado");

            return View(new FiltroMediaDiasParaInstrucao());
        }

        [HttpPost]
        public IActionResult ListarMediaDiasParaInstrucao([FromForm] FiltroMediaDiasParaInstrucao filtro)
        {
            filtro.RetornoMediaDiasParaInstrucao = new MediaDiasParaInstrucaoServicos().BuscaMediaDiasParaInstrucao(filtro.DataInicio, filtro.DataFim);
            return View("MediaDiasParaInstrucao", filtro);
        }

        [HttpPost]
        public FileResult ExportarMediaDiasParaInstrucao([FromForm] FiltroMediaDiasParaInstrucao filtro)
        {
            string nomeArquivo = $"MediaDiasParaInstrucao-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var ret = new MediaDiasParaInstrucaoServicos().ExportarMediaDiasParaInstrucao(filtro.DataInicio, filtro.DataFim);
            return File(ret, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nomeArquivo);
        }
    }
}