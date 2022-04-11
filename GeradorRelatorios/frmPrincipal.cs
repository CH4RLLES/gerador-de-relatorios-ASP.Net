using GeradorRelatorios.BD_PNCV_LIC_4;
using GeradorRelatorios.BD_RENAVAM;
using GeradorRelatorios.DB_SINPEV;
using GeradorRelatorios.DTO;
using GeradorRelatorios.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GeradorRelatorios
{
    public partial class frmPrincipal : Form
    {
        public List<Paralisacoes> _paralisacoes = new List<Paralisacoes>();

        public frmPrincipal()
        {
            InitializeComponent();

            cbTipoVeiculo.Items.Add("Não especificado");
            cbTipoVeiculo.Items.Add("Motos");
            cbTipoVeiculo.Items.Add("Carros e Veículos Pequenos");
            cbTipoVeiculo.Items.Add("Caminhões Leves e Ônibus");
            cbTipoVeiculo.Items.Add("Caminhões Pesados e Especiais");
            cbTipoVeiculo.Items.Add("Todos");

            cbRelatorio.Items.Add("Relatório PNCV");
            cbRelatorio.Items.Add("Entrada de Processos no SIOR");
            cbRelatorio.Items.Add("Relatório Completo Imagens Engenharia");
            cbRelatorio.Items.Add("Relatório Imagens Válidas e Inválidas");
            cbRelatorio.Items.Add("Quantidade de Processos realizados no SIOR");
            cbRelatorio.Items.Add("Buscar nome por CNPJ");
            cbRelatorio.Items.Add("Situação de Recursos nas JARIs");
            cbRelatorio.Items.Add("Excesso de Peso - Jurídico");
            cbRelatorio.Items.Add("Relação Julgamentos nas JARIs por mês");
            cbRelatorio.Items.Add("Buscar dados pela Infração");
            cbRelatorio.Items.Add("Relatório PNCV - LIC 4 - Por Equipamento");
            cbRelatorio.Items.Add("Resumo de Equipamentos");

            cbEdital.DataSource = ListaEditais();

            cbSituacao.DataSource = ListaSituacaoEquipamento();

            cbTipoVeiculo.SelectedIndex = 0;
            cbRelatorio.SelectedIndex = 0;

            dtInicio.MaxDate = DateTime.Now.AddDays(6);
            dtFim.MaxDate = DateTime.Now.AddDays(6);
            dtInicio.Value = DateTime.Now.AddDays(-6);
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            BloqueiaDesbloqueia(false);

            if (cbRelatorio.SelectedIndex == 0)
            {
                var lote = string.IsNullOrEmpty(txtLote.Text) ? 0 : int.Parse(txtLote.Text);
                var dados = BuscaRegistrosPNVC(dtInicio.Value.Date, dtFim.Value.AddDays(1).AddTicks(-1).Date, cbTipoVeiculo.SelectedIndex, txtCodEquipamento.Text, lote);
                if (dados != null)
                {
                    dgDados.DataSource = dados;
                    slQuantidade.Text = "Registros: " + dados.Count();
                }
            }
            else if (cbRelatorio.SelectedIndex == 1)
            {
                var dados = BuscaRegistrosProcessosSIOR(dtInicio.Value.Date, dtFim.Value.Date);
                if (dados != null)
                {
                    dgDados.DataSource = dados;
                    slQuantidade.Text = "Registros: " + dados.Count();
                }
            }
            else if (cbRelatorio.SelectedIndex == 2)
            {
                var dados = BuscaRegistrosCompletoEngenharia(dtInicio.Value.Date, dtFim.Value.Date);
                if (dados != null)
                {
                    dgDados.DataSource = dados;
                    slQuantidade.Text = "Registros: " + dados.Count();
                }
            }
            else if (cbRelatorio.SelectedIndex == 3)
            {
                var dados = BuscaRegistrosImngsValidasInvalidas(dtInicio.Value.Date, dtFim.Value.Date);
                if (dados != null)
                {
                    dgDados.DataSource = dados;
                    slQuantidade.Text = "Registros: " + dados.Count();
                }
            }
            else if (cbRelatorio.SelectedIndex == 4)
            {
                var dados = BuscaProcessosRealizadosSIOR(dtInicio.Value.Date, dtFim.Value.Date);
                if (dados != null)
                {
                    dgDados.DataSource = dados;
                    slQuantidade.Text = "Registros: " + dados.Count();
                    dgDados.Columns[5].Visible = false;
                }
            }
            else if (cbRelatorio.SelectedIndex == 5)
            {
                var dados = BuscaNomeCNPJ();
                if (dados != null)
                {
                    dgDados.DataSource = dados;
                    slQuantidade.Text = "Registros: " + dados.Count();
                }
            }
            else if (cbRelatorio.SelectedIndex == 6)
            {
                var dados = BuscaRecursosJari(dtInicio.Value.Date, dtFim.Value.Date);
                if (dados != null)
                {
                    dgDados.DataSource = dados;
                    slQuantidade.Text = "Registros: " + dados.Count();
                }
            }
            else if (cbRelatorio.SelectedIndex == 7)
            {
                var dados = BuscaExcessoPeso(dtInicio.Value.Date, dtFim.Value.Date);
                if (dados != null)
                {
                    dgDados.DataSource = dados;
                    slQuantidade.Text = "Registros: " + dados.Count();
                }
            }
            else if (cbRelatorio.SelectedIndex == 8)
            {
                var dados = BuscaJulgamentosJari(dtInicio.Value.Date, dtFim.Value.Date);
                if (dados != null)
                {
                    dgDados.DataSource = dados;
                    slQuantidade.Text = "Registros: " + dados.Count();
                }
            }
            else if (cbRelatorio.SelectedIndex == 9)
            {
                var dados = BuscaDadosInfracao();
                if (dados != null)
                {
                    dgDados.DataSource = dados;
                    slQuantidade.Text = "Registros: " + dados.Count();
                }
            }
            else if (cbRelatorio.SelectedIndex == 10)
            {
                var dados = BuscaRegistrosPNVCLIC4(dtInicio.Value.Date, dtFim.Value.AddDays(1).AddTicks(-1).Date, cbTipoVeiculo.SelectedIndex, txtCodEquipamento.Text);
                if (dados != null)
                {
                    dgDados.DataSource = dados;
                    slQuantidade.Text = "Registros: " + dados.Count();
                }
            }
            else if (cbRelatorio.SelectedIndex == 11)
            {
                var dados = ResumoEquipamentos(CodigoEdital(cbEdital.SelectedValue.ToString()), CodigoSituacaoEquipamento(cbSituacao.SelectedValue.ToString()));
                if (dados != null)
                {
                    dgDados.DataSource = dados;
                    slQuantidade.Text = "Registros: " + dados.Count();
                }
            }

            BloqueiaDesbloqueia(true);
        }

        private List<string> ListaEditais()
        {
            using (var db = new BD_SIORContext())
            {
                return db.TblPncvedital.Select(a => a.Numero).ToList();
            }
        }

        private List<string> ListaSituacaoEquipamento()
        {
            List<string> ret = new List<string>();
            ret.Add("Todos");

            using (var db = new BD_SIORContext())
            {
                ret.AddRange(db.TblPncvequipamentoFaixaSituacao.Select(a => a.Nome).ToList());
            }

            return ret;
        }

        private int CodigoEdital(string numero)
        {
            using (var db = new BD_SIORContext())
            {
                return db.TblPncvedital.Where(a => a.Numero == numero).FirstOrDefault().CodigoPncvedital;
            }
        }

        private int CodigoSituacaoEquipamento(string nome)
        {
            if (nome == "Todos")
                return 0;

            using (var db = new BD_SIORContext())
            {
                return db.TblPncvequipamentoFaixaSituacao.Where(a => a.Nome == nome).FirstOrDefault().CodigoPncvequipamentoFaixaSituacao;
            }
        }

        private List<RetornoDadosInfracao> BuscaDadosInfracao()
        {
            try
            {
                var retorno = new List<RetornoDadosInfracao>();
                string path = string.Empty;
                var dialog = new OpenFileDialog
                {
                    Title = "Importar arquivo",
                    Filter = "Arquivo de Lote(*.csv)|*.csv"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                    path = dialog.FileName;

                if (string.IsNullOrEmpty(path))
                    return null;

                string[] Linhas = File.ReadAllLines(path);

                spbProgresso.Value = 0;
                spbProgresso.Maximum = Linhas.Count();

                foreach (var item in Linhas)
                {
                    spbProgresso.Value++;

                    using (var db = new BD_SIORContext())
                    {
                        string cpfcnpj = "";
                        var infracao = db.TblInfracao.Where(a => a.NumeroAit == item).FirstOrDefault();
                        var equadramento = db.TblInfracaoEnquadramento.Where(a => a.CodigoInfracaoEnquadramento == infracao.CodigoInfracaoEnquadramento).FirstOrDefault().DescricaoInfracao;

                        if (infracao == null)
                            continue;

                        if (infracao.CodigoInfracaoInfrator != null)
                            cpfcnpj = db.TblInfracaoInfrator.Where(a => a.CodigoInfracaoInfrator == infracao.CodigoInfracaoInfrator).FirstOrDefault().NumeroCpfcnpjformatado;
                        else if (infracao.CodigoInfracaoCondutor != null)
                            cpfcnpj = db.TblInfracaoCondutor.Where(a => a.CodigoInfracaoCondutor == infracao.CodigoInfracaoCondutor).FirstOrDefault().NumeroCpfformatado;
                        else if (infracao.CodigoInfracaoProprietario != null)
                            cpfcnpj = db.TblInfracaoProprietario.Where(a => a.CodigoInfracaoProprietario == infracao.CodigoInfracaoProprietario).FirstOrDefault().NumeroCpfcnpjformatado;

                        var nome = new RetornoDadosInfracao
                        {
                            Auto = item,
                            CpfCnpj = cpfcnpj,
                            Enquadramento = equadramento
                        };

                        retorno.Add(nome);

                        db.Dispose();
                    }
                }

                return retorno;
            }
            catch (Exception ex)
            {
                slProcessando.Text = "Erro ao executar: " + ex.Message;
                return null;
            }
            
        }

        private List<RetornoJulgamentosJari> BuscaJulgamentosJari(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = new List<RetornoJulgamentosJari>();
                List<TblInfracaoRecurso> recursos;
                List<TblInfracaoRecursoFase> fase;
                List<TblJari> jari;

                using (var db = new BD_SIORContext())
                {
                    recursos = db.TblInfracaoRecurso.Where(a => a.DataJulgamento >= dataInicio && a.DataJulgamento <= dataFim && (a.CodigoInfracaoRecursoFase == 21 || a.CodigoInfracaoRecursoFase == 22)).ToList();
                    fase = db.TblInfracaoRecursoFase.ToList();
                    jari = db.TblJari.ToList();

                    db.Dispose();
                }

                spbProgresso.Value = 0;
                spbProgresso.Maximum = recursos.Count();
                var lista = new List<RetornoJulgamentosJari>();

                foreach (var item in recursos)
                {
                    var itemFase = fase.Where(a => a.CodigoInfracaoRecursoFase == item.CodigoInfracaoRecursoFase).FirstOrDefault().Nome;
                    var itemJari = jari.Where(a => a.CodigoJari == item.CodigoJari).FirstOrDefault();
                    spbProgresso.Value++;

                    var dados = new RetornoJulgamentosJari
                    {
                        Ano = item.DataJulgamento.Value.Year.ToString(),
                        Mes = item.DataJulgamento.Value.Month.ToString(),
                        Fase = itemFase,
                        JARI = itemJari == null ? "Não Informada" : itemJari.Nome
                    };

                    lista.Add(dados);
                }

                var grupo = lista.GroupBy(a => new { a.Ano, a.Mes, a.JARI, a.Fase }).Select(g => new 
                {
                    Ano = g.Select(v => v.Ano),
                    Mes = g.Select(v => v.Mes),
                    Fase = g.Select(v => v.Fase),
                    JARI = g.Select(v => v.JARI),
                    Qtd = g.Count()
                });

                spbProgresso.Value = 0;
                spbProgresso.Maximum = grupo.Count();

                foreach (var item in grupo)
                {
                    spbProgresso.Value++;
                    var dados = new RetornoJulgamentosJari
                    {
                        Ano = item.Ano.FirstOrDefault(),
                        Mes = item.Mes.FirstOrDefault(),
                        Fase = item.Fase.FirstOrDefault(),
                        JARI = item.JARI.FirstOrDefault(),
                        QuantidadeJulgados = item.Qtd.ToString()
                    };

                    retorno.Add(dados);
                }

                return retorno.OrderBy(a => a.Ano).ThenBy(a => a.Mes).ThenBy(a => a.JARI).ToList();
            }
            catch (Exception ex)
            {
                slProcessando.Text = "Erro ao executar: " + ex.Message;
                return null;
            }
        }

        private List<RetornoExcessoPeso> BuscaExcessoPeso(DateTime dataInicio, DateTime dataFim)
        {
            var cnpj = txtCNPJ.Text.Replace(".", "").Replace("-", "").Replace("/", "");

            if (string.IsNullOrEmpty(cnpj))
            {
                MessageBox.Show("O CPF/CNPJ não pode ser vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            if (rbCnpjCpf.Checked)
            {
                if (cnpj.Length == 11)
                {
                    if (!Metodos.ValidarCpf(cnpj))
                    {
                        MessageBox.Show("CPF inválido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return null;
                    }
                }
                else if (cnpj.Length == 14)
                {
                    if (!Metodos.ValidarCNPJ(cnpj))
                    {
                        MessageBox.Show("CNPJ inválido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return null;
                    }
                }
                else
                {
                    MessageBox.Show("CPF/CNPJ inválido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }
            }
            else if (cnpj.Length != 8)
            {
                MessageBox.Show("Raíz do CNPJ incorreto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            var retorno = new List<RetornoExcessoPeso>();

            try
            {
                using (var db = new BD_SIORContext())
                {
                    var peso = db.TblInfracao.Join(db.TblInfracaoInfrator, infracao => infracao.CodigoInfracaoInfrator, infrator => infrator.CodigoInfracaoInfrator, (infracao, infrator) => new { infracao, infrator })
                        .Where(a => a.infracao.CodigoInfracaoInfrator == a.infrator.CodigoInfracaoInfrator && a.infrator.NumeroCpfcnpj.StartsWith(cnpj) && a.infracao.DataInfracao >= dataInicio && a.infracao.DataInfracao <= dataFim
                        && (a.infracao.CodigoInfracaoOrigem == 3 || a.infracao.CodigoInfracaoOrigem == 4 || a.infracao.CodigoInfracaoOrigem == 5));
                    
                    spbProgresso.Value = 0;
                    spbProgresso.Maximum = peso.Count();

                    foreach (var item in peso)
                    {
                        spbProgresso.Value++;
                        var embarcador = db.TblInfracaoEmbarcador.Where(a => a.CodigoInfracaoEmbarcador == item.infracao.CodigoInfracaoEmbarcador).FirstOrDefault();
                        var proprietario = db.TblInfracaoProprietario.Where(a => a.CodigoInfracaoProprietario == item.infracao.CodigoInfracaoProprietario).FirstOrDefault();
                        var transportador = db.TblInfracaoTransportador.Where(a => a.CodigoInfracaoTransportador == item.infracao.CodigoInfracaoTransportador).FirstOrDefault();
                        var pesagem = db.TblInfracaoPesagem.Where(a => a.CodigoInfracaoPesagem == item.infracao.CodigoInfracaoPesagem).FirstOrDefault();
                        var veiculo = db.TblInfracaoVeiculo.Where(a => a.CodigoInfracaoVeiculo == item.infracao.CodigoInfracaoVeiculo).FirstOrDefault();
                        var financeiro = db.TblInfracaoFinanceiroDebito.Join(db.TblInfracaoFinanceiroDebitoSituacao, debito => debito.CodigoInfracaoFinanceiroDebitoSituacao,
                                                                                                                      situacao => situacao.CodigoInfracaoFinanceiroDebitoSituacao, (debito, situacao) => new { debito, situacao })
                            .Where(a => a.debito.CodigoInfracaoFinanceiroDebitoSituacao == a.situacao.CodigoInfracaoFinanceiroDebitoSituacao && a.debito.CodigoInfracaoFinanceiroDebito == item.infracao.CodigoInfracao).FirstOrDefault();
                        var enquadramento = db.TblInfracaoEnquadramento.Where(a => a.CodigoInfracaoEnquadramento == item.infracao.CodigoInfracaoEnquadramento).FirstOrDefault();

                        var dados = new RetornoExcessoPeso
                        {
                            DataInfracao = item.infracao.DataHoraInfracao.ToString(),
                            Embarcador = embarcador != null ? embarcador.NumeroCpfcnpjformatado + "-->" + embarcador.Nome : " - ",
                            Enquadramento = enquadramento.CodigoEnquadramentoTexto + ": " + enquadramento.DescricaoInfracao,
                            ExcessoAferidoCMT = pesagem != null ? pesagem.ExcessoAferidoCmt.ToString() : "",
                            ExcessoAferidoEixo1 = pesagem != null ? pesagem.ExcessoAferidoEixo1.ToString() : "",
                            ExcessoAferidoEixo2 = pesagem != null ? pesagem.ExcessoAferidoEixo2.ToString() : "",
                            ExcessoAferidoEixo3 = pesagem != null ? pesagem.ExcessoAferidoEixo3.ToString() : "",
                            ExcessoAferidoEixo4 = pesagem != null ? pesagem.ExcessoAferidoEixo4.ToString() : "",
                            ExcessoAferidoEixo5 = pesagem != null ? pesagem.ExcessoAferidoEixo5.ToString() : "",
                            ExcessoAferidoEixo6 = pesagem != null ? pesagem.ExcessoAferidoEixo6.ToString() : "",
                            ExcessoAferidoEixo7 = pesagem != null ? pesagem.ExcessoAferidoEixo7.ToString() : "",
                            ExcessoAferidoPBT = pesagem != null ? pesagem.ExcessoAferidoPbt.ToString() : "",
                            Infrator = item.infrator.NumeroCpfcnpjformatado + "-->" + item.infrator.Nome,
                            LimiteRegulamentarCMT = pesagem != null ? pesagem.LimiteRegulamentarCmt.ToString() : "",
                            LimiteRegulamentarComToleranciaCMT = pesagem != null ? pesagem.LimiteRegulamentarComToleranciaCmt.ToString() : "",
                            LimiteRegulamentarComToleranciaEixo1 = pesagem != null ? pesagem.LimiteRegulamentarComToleranciaEixo1.ToString() : "",
                            LimiteRegulamentarComToleranciaEixo2 = pesagem != null ? pesagem.LimiteRegulamentarComToleranciaEixo2.ToString() : "",
                            LimiteRegulamentarComToleranciaEixo3 = pesagem != null ? pesagem.LimiteRegulamentarComToleranciaEixo3.ToString() : "",
                            LimiteRegulamentarComToleranciaEixo4 = pesagem != null ? pesagem.LimiteRegulamentarComToleranciaEixo4.ToString() : "",
                            LimiteRegulamentarComToleranciaEixo5 = pesagem != null ? pesagem.LimiteRegulamentarComToleranciaEixo5.ToString() : "",
                            LimiteRegulamentarComToleranciaEixo6 = pesagem != null ? pesagem.LimiteRegulamentarComToleranciaEixo6.ToString() : "",
                            LimiteRegulamentarComToleranciaEixo7 = pesagem != null ? pesagem.LimiteRegulamentarComToleranciaEixo7.ToString() : "",
                            LimiteRegulamentarComToleranciaPBT = pesagem != null ? pesagem.LimiteRegulamentarComToleranciaPbt.ToString() : "",
                            LimiteRegulamentarEixo1 = pesagem != null ? pesagem.LimiteRegulamentarEixo1.ToString() : "",
                            LimiteRegulamentarEixo2 = pesagem != null ? pesagem.LimiteRegulamentarEixo2.ToString() : "",
                            LimiteRegulamentarEixo3 = pesagem != null ? pesagem.LimiteRegulamentarEixo3.ToString() : "",
                            LimiteRegulamentarEixo4 = pesagem != null ? pesagem.LimiteRegulamentarEixo4.ToString() : "",
                            LimiteRegulamentarEixo5 = pesagem != null ? pesagem.LimiteRegulamentarEixo5.ToString() : "",
                            LimiteRegulamentarEixo6 = pesagem != null ? pesagem.LimiteRegulamentarEixo6.ToString() : "",
                            LimiteRegulamentarEixo7 = pesagem != null ? pesagem.LimiteRegulamentarEixo7.ToString() : "",
                            LimiteRegulamentarPBT = pesagem != null ? pesagem.LimiteRegulamentarPbt.ToString() : "",
                            MedicaoRealizadaCMT = pesagem != null ? pesagem.MedicaoRealizadaCmt.ToString() : "",
                            MedicaoRealizadaEixo1 = pesagem != null ? pesagem.MedicaoRealizadaEixo1.ToString() : "",
                            MedicaoRealizadaEixo2 = pesagem != null ? pesagem.MedicaoRealizadaEixo2.ToString() : "",
                            MedicaoRealizadaEixo3 = pesagem != null ? pesagem.MedicaoRealizadaEixo3.ToString() : "",
                            MedicaoRealizadaEixo4 = pesagem != null ? pesagem.MedicaoRealizadaEixo4.ToString() : "",
                            MedicaoRealizadaEixo5 = pesagem != null ? pesagem.MedicaoRealizadaEixo5.ToString() : "",
                            MedicaoRealizadaEixo6 = pesagem != null ? pesagem.MedicaoRealizadaEixo6.ToString() : "",
                            MedicaoRealizadaEixo7 = pesagem != null ? pesagem.MedicaoRealizadaEixo7.ToString() : "",
                            MedicaoRealizadaPBT = pesagem != null ? pesagem.MedicaoRealizadaPbt.ToString() : "",
                            NumeroAIT = item.infracao.NumeroAit,
                            PlacaVeiculo = veiculo.Placa,
                            Proprietario = proprietario != null ? proprietario.NumeroCpfcnpjformatado + "-->" + proprietario.Nome : " - ",
                            RENAVAM = veiculo.NumeroCodigoRenavam.ToString(),
                            RodoviaKmLocalInfracao = item.infracao.LocalInfracao,
                            SituacaoDebito = financeiro != null ? financeiro.situacao.Nome : "",
                            ToleranciaCMT = pesagem != null ? pesagem.ToleranciaCmt.ToString() : "",
                            ToleranciaEixo1 = pesagem != null ? pesagem.ToleranciaEixo1.ToString() : "",
                            ToleranciaEixo2 = pesagem != null ? pesagem.ToleranciaEixo2.ToString() : "",
                            ToleranciaEixo3 = pesagem != null ? pesagem.ToleranciaEixo3.ToString() : "",
                            ToleranciaEixo4 = pesagem != null ? pesagem.ToleranciaEixo4.ToString() : "",
                            ToleranciaEixo5 = pesagem != null ? pesagem.ToleranciaEixo5.ToString() : "",
                            ToleranciaEixo6 = pesagem != null ? pesagem.ToleranciaEixo6.ToString() : "",
                            ToleranciaEixo7 = pesagem != null ? pesagem.ToleranciaEixo7.ToString() : "",
                            ToleranciaPBT = pesagem != null ? pesagem.ToleranciaPbt.ToString() : "",
                            Transportador = transportador != null ? transportador.NumeroCpfcnpjformatado + "-->" + transportador.Nome : " - ",
                            ValorPago = financeiro != null ? financeiro.debito.ValorPago.ToString() : "0,00",
                            ValorPrincipal = item.infracao.ValorOriginal.ToString()
                        };

                        using (var sinpev = new BD_SINPEVContext())
                        {
                            var notas = sinpev.tblDadosSINPEV.Where(a => a.NumeroAIT == item.infracao.NumeroAit).FirstOrDefault();
                            dados.NotasFiscais = notas != null ? notas.NotasFiscais : "";

                            sinpev.Dispose();
                        }

                        using (var renavam = new RENAVAMContext())
                        {
                            var municipio = renavam.tblRENAVAMMunicipio.Where(a => a.CodigoRENAVAMMunicipio == item.infracao.CodigoRenavammunicipioLocalInfracao).FirstOrDefault();
                            dados.Municipio = municipio != null ? municipio.Nome : "";
                            var marca = renavam.tblRENAVAMMarcaModeloVeiculo.Where(a => a.CodigoRENAVAMMarcaModeloVeiculo == veiculo.CodigoRenavammarcaModeloVeiculo).FirstOrDefault();
                            dados.MarcaModelo = marca != null ? marca.Nome : "";

                            renavam.Dispose();
                        }

                        retorno.Add(dados);
                    }

                    db.Dispose();
                }

                return retorno;

            }
            catch (Exception ex)
            {
                slProcessando.Text = "Erro ao executar: " + ex.Message;
                return null;
            }
        }

        private List<RetornoRecursosJari> BuscaRecursosJari(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = new List<RetornoRecursosJari>();
                var dataReferenciaInicio = rdbProtocolo.Checked ? dataInicio : dataInicio.AddYears(-3);
                var dataReferenciaFim = rdbProtocolo.Checked ? dataFim : dataFim.AddYears(-3);

                using (var db = new BD_SIORContext())
                {
                    var dadosRecurso = db.TblInfracaoRecurso.FromSql("Select * from TblInfracaoRecurso WHERE DataProtocolo between '" + dataReferenciaInicio + "' and '" + dataReferenciaFim + "'").ToList();
                    
                    spbProgresso.Value = 0;
                    spbProgresso.Maximum = dadosRecurso.Count();

                    foreach (var item in dadosRecurso)
                    {
                        spbProgresso.Value++;
                        var nomeJari = db.TblJari.Where(a => a.CodigoJari == item.CodigoJari).FirstOrDefault();
                        var dados = new RetornoRecursosJari
                        {
                            CpfCnpjRecorrente = item.RecorrenteNumeroCpfcnpjformatado,
                            DataProtocolo = item.DataProtocolo.ToShortDateString(),
                            FaseRecurso = db.TblInfracaoRecursoFase.Where(a => a.CodigoInfracaoRecursoFase == item.CodigoInfracaoRecursoFase).FirstOrDefault().Nome,
                            Instancia = db.TblInfracaoRecursoTipo.Where(a => a.CodigoInfracaoRecursoTipo == item.CodigoInfracaoRecursoTipo).FirstOrDefault().Nome,
                            JARI = nomeJari == null ? "Não encaminhado" : nomeJari.Nome,
                            MesAnoProtocolo = item.DataProtocolo.Month + "/" + item.DataProtocolo.Year,
                            NumeroAIT = db.TblInfracao.Where(a => a.CodigoInfracao == item.CodigoInfracao).FirstOrDefault().NumeroAit,
                            NumeroProcesso = item.NumeroProcesso,
                            PrevisaoPrescricao = item.DataProtocolo.Month + "/" + item.DataProtocolo.AddYears(3).Year,
                            QuantidadedeArquivos = db.TblInfracaoRecursoArquivo.Where(a => a.CodigoInfracaoRecurso == item.CodigoInfracaoRecurso).Count().ToString(),
                            SituacaoRecurso = db.TblInfracaoRecursoSituacao.Where(a => a.CodigoInfracaoRecursoSituacao == item.CodigoInfracaoRecursoSituacao).FirstOrDefault().Nome,
                            UF = nomeJari == null ? "Não Identificado" : db.TblBaseUf.Where(a => a.CodigoBaseUf == nomeJari.CodigoBaseUf).FirstOrDefault().Sigla
                        };

                        retorno.Add(dados);
                    }

                    db.Dispose();
                }

                return retorno;

            }
            catch (Exception ex)
            {
                slProcessando.Text = "Erro ao executar: " + ex.Message;
                return null;
            }
        }

        private List<RetornoNomeCNPJ> BuscaNomeCNPJ()
        {
            var dados = new List<RetornoNomeCNPJ>();

            try
            {
                string path = string.Empty;
                var dialog = new OpenFileDialog
                {
                    Title = "Importar arquivo",
                    Filter = "Arquivo de Lote(*.csv)|*.csv"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                    path = dialog.FileName;

                if (string.IsNullOrEmpty(path))
                    return null;

                string[] Linhas = File.ReadAllLines(path);

                spbProgresso.Value = 0;
                spbProgresso.Maximum = Linhas.Count();

                foreach (var item in Linhas)
                {
                    spbProgresso.Value++;

                    if (item == "Não Identificado")
                        continue;

                    using (var db = new BD_SIORContext())
                    {
                        var infrator = db.TblInfracaoRecurso.Where(a => a.RecorrenteNumeroCpfcnpjformatado == item).FirstOrDefault();

                        if (infrator == null)
                        {
                            var naoEncontrado = new RetornoNomeCNPJ
                            {
                                CNPJ = item,
                                Nome = "Não encontrado"
                            };

                            dados.Add(naoEncontrado);
                            db.Dispose();
                            continue;
                        }

                        var nome = new RetornoNomeCNPJ
                        {
                            CNPJ = infrator.RecorrenteNumeroCpfcnpjformatado,
                            Nome = infrator.RecorrenteNome
                        };

                        dados.Add(nome);
                        db.Dispose();
                    }
                }

                return dados;
            }
            catch (Exception ex)
            {
                slProcessando.Text = "Erro ao executar: " + ex.Message;
                return null;
            }

        }

        private List<RetornoProcessosSIOR> BuscaProcessosRealizadosSIOR(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = new List<RetornoProcessosSIOR>();
                var data = dataInicio;

                using (var db = new BD_SIORContext())
                {
                    var dadosSA = db.TblInfracaoSolicitacaoAdvertenciaEvento.Where(a => a.Data >= dataInicio && a.Data <= dataFim.AddDays(1).AddTicks(-1) && a.CodigoInfracaoSolicitacaoAdvertenciaFase == 6
                                  && a.NomeSistemaUsuario != "SIOR" && a.CodigoInfracaoSolicitacaoAdvertenciaSituacao == 1).OrderBy(a => a.Data).ToList();
                    var dadosFICI = db.TblInfracaoIdentificacaoInfratorCondutor.Where(a => a.DataConferencia >= dataInicio && a.DataConferencia <= dataFim).OrderBy(a => a.DataConferencia).ToList();
                    var dadosDA = db.TblInfracaoDaevento.Where(a => a.Data >= dataInicio && a.Data <= dataFim.AddDays(1).AddTicks(-1) && a.CodigoInfracaoDafase == 6
                                  && a.NomeSistemaUsuario != "SIOR" && a.CodigoInfracaoDasituacao == 1).OrderBy(a => a.Data).ToList();
                    var dadosRec1 = db.TblInfracaoRecursoEvento.Where(a => a.Data >= dataInicio && a.Data <= dataFim.AddDays(1).AddTicks(-1) && a.CodigoInfracaoRecursoFase == 13 && a.Descricao == null).OrderBy(a => a.Data).ToList();

                    spbProgresso.Value = 0;
                    spbProgresso.Maximum = (dataFim - data).Days + 1;

                    while (data <= dataFim)
                    {
                        spbProgresso.Value++;
                        var dados = new RetornoProcessosSIOR
                        {
                            Data = data.ToShortDateString(),
                            DA = dadosDA.Where(a => a.Data >= data && a.Data <= data.AddDays(1).AddTicks(-1)).Count().ToString(),
                            FICI = dadosFICI.Where(a => a.DataConferencia == data).Count().ToString(),
                            SA = dadosSA.Where(a => a.Data >= data && a.Data <= data.AddDays(1).AddTicks(-1)).Count().ToString(),
                            Recurso1estancia = dadosRec1.Where(a => a.Data >= data && a.Data <= data.AddDays(1).AddTicks(-1)).Count().ToString(),
                            Recurso2estancia = "0"
                        };

                        retorno.Add(dados);
                        data = data.AddDays(1);
                    }

                    db.Dispose();
                }
                
                return retorno;
                
            }
            catch (Exception ex)
            {
                slProcessando.Text = "Erro ao executar: " + ex.Message;
                return null;
            }
        }

        private void BloqueiaDesbloqueia(bool ativo)
        {
            if (ativo)
            {
                if (slProcessando.Text == "Aguarde... Processando...")
                    slProcessando.Text = "";

                Cursor.Current = Cursors.Default;
            }
            else
            {
                slProcessando.Text = "Aguarde... Processando...";
                Cursor.Current = Cursors.WaitCursor;
            }

            nudInicio.Enabled = ativo;
            nudFim.Enabled = ativo;
            btnExecutar.Enabled = ativo;
            btnSalvar.Enabled = ativo;
            cbTipoVeiculo.Enabled = ativo;
            cbRelatorio.Enabled = ativo;
            dtFim.Enabled = ativo;
            dtInicio.Enabled = ativo;
            rdbPrescricao.Enabled = ativo;
            rdbProtocolo.Enabled = ativo;
            lblCNPJ.Enabled = ativo;
            txtCNPJ.Enabled = ativo;
            rbCnpjCpf.Enabled = ativo;
            rbRaiz.Enabled = ativo;
            txtCodEquipamento.Enabled = ativo;
            txtLote.Enabled = ativo;
            cbEdital.Enabled = ativo;
            cbSituacao.Enabled = ativo;
        }

        private void cbRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRelatorio.SelectedIndex == 0)
            {
                lblTipoVeiculo.Visible = true;
                cbTipoVeiculo.Visible = true;
                rdbPrescricao.Visible = false;
                rdbProtocolo.Visible = false;
                lblDe.Visible = true;
                lblAte.Visible = true;
                nudFim.Visible = true;
                nudInicio.Visible = true;
                lblCNPJ.Visible = false;
                txtCNPJ.Visible = false;
                rbCnpjCpf.Visible = false;
                rbRaiz.Visible = false;
                dtFim.Enabled = true;
                dtInicio.Enabled = true;
                dtFim.MaxDate = DateTime.Now.AddDays(6);
                BloqueiaDesbloqueia(true);
                txtCodEquipamento.Visible = true;
                lblCodEquipamento.Visible = true;
                lblLote.Visible = true;
                txtLote.Visible = true;
                lblEdital.Visible = false;
                cbEdital.Visible = false;
                dtFim.Visible = true;
                dtInicio.Visible = true;
                lblSituacao.Visible = false;
                cbSituacao.Visible = false;
            }
            else if(cbRelatorio.SelectedIndex == 5 || cbRelatorio.SelectedIndex == 9)
            {
                lblDe.Visible = true;
                lblAte.Visible = true;
                nudFim.Visible = true;
                nudInicio.Visible = true;
                nudInicio.Enabled = false;
                nudFim.Enabled = false;
                btnSalvar.Enabled = false;
                cbTipoVeiculo.Enabled = false;
                dtFim.Enabled = false;
                dtInicio.Enabled = false;
                lblTipoVeiculo.Visible = false;
                cbTipoVeiculo.Visible = false;
                rdbPrescricao.Visible = false;
                rdbProtocolo.Visible = false;
                lblCNPJ.Visible = false;
                txtCNPJ.Visible = false;
                rbCnpjCpf.Visible = false;
                rbRaiz.Visible = false;
                txtCodEquipamento.Visible = false;
                lblCodEquipamento.Visible = false;
                lblLote.Visible = false;
                txtLote.Visible = false;
                lblEdital.Visible = false;
                cbEdital.Visible = false;
                dtFim.Visible = true;
                dtInicio.Visible = true;
                lblSituacao.Visible = false;
                cbSituacao.Visible = false;
                dtFim.MaxDate = DateTime.Now.AddDays(6);
            }
            else if (cbRelatorio.SelectedIndex == 6)
            {
                lblTipoVeiculo.Visible = false;
                cbTipoVeiculo.Visible = false;
                rdbPrescricao.Visible = true;
                rdbProtocolo.Visible = true;
                lblDe.Visible = true;
                lblAte.Visible = true;
                nudFim.Visible = true;
                nudInicio.Visible = true;
                lblCNPJ.Visible = false;
                txtCNPJ.Visible = false;
                rbCnpjCpf.Visible = false;
                rbRaiz.Visible = false;
                dtFim.Enabled = true;
                dtInicio.Enabled = true;
                txtCodEquipamento.Visible = false;
                lblCodEquipamento.Visible = false;
                lblLote.Visible = false;
                txtLote.Visible = false;
                lblEdital.Visible = false;
                cbEdital.Visible = false;
                dtFim.Visible = true;
                dtInicio.Visible = true;
                lblSituacao.Visible = false;
                cbSituacao.Visible = false;
                dtFim.MaxDate = DateTime.Now.AddYears(1);
                BloqueiaDesbloqueia(true);
            }
            else if (cbRelatorio.SelectedIndex == 7)
            {
                lblTipoVeiculo.Visible = false;
                cbTipoVeiculo.Visible = false;
                rdbPrescricao.Visible = false;
                rdbProtocolo.Visible = false;
                lblDe.Visible = false;
                lblAte.Visible = false;
                nudFim.Visible = false;
                nudInicio.Visible = false;
                lblCNPJ.Visible = true;
                txtCNPJ.Visible = true;
                rbCnpjCpf.Visible = true;
                rbRaiz.Visible = true;
                dtFim.Enabled = true;
                dtInicio.Enabled = true;
                txtCodEquipamento.Visible = false;
                lblCodEquipamento.Visible = false;
                lblLote.Visible = false;
                txtLote.Visible = false;
                lblEdital.Visible = false;
                cbEdital.Visible = false;
                dtFim.Visible = true;
                dtInicio.Visible = true;
                lblSituacao.Visible = false;
                cbSituacao.Visible = false;
                dtFim.MaxDate = DateTime.Now.AddYears(6);
                dtInicio.MinDate = new DateTime(2005, 1, 1);
                dtInicio.Value = new DateTime(2014, 1, 1);
                dtFim.Value = DateTime.Now.Date;
            }
            else if (cbRelatorio.SelectedIndex == 8)
            {
                lblTipoVeiculo.Visible = false;
                cbTipoVeiculo.Visible = false;
                rdbPrescricao.Visible = false;
                rdbProtocolo.Visible = false;
                lblDe.Visible = false;
                lblAte.Visible = false;
                nudFim.Visible = false;
                nudInicio.Visible = false;
                lblCNPJ.Visible = false;
                txtCNPJ.Visible = false;
                rbCnpjCpf.Visible = false;
                rbRaiz.Visible = false;
                dtFim.Enabled = true;
                dtInicio.Enabled = true;
                txtCodEquipamento.Visible = false;
                lblCodEquipamento.Visible = false;
                lblLote.Visible = false;
                txtLote.Visible = false;
                lblEdital.Visible = false;
                cbEdital.Visible = false;
                dtFim.Visible = true;
                dtInicio.Visible = true;
                lblSituacao.Visible = false;
                cbSituacao.Visible = false;
                dtFim.MaxDate = DateTime.Now.AddYears(6);
                dtInicio.MinDate = new DateTime(2005, 1, 1);
                dtInicio.Value = new DateTime(2014, 1, 1);
                dtFim.Value = DateTime.Now.Date;
            }
            else if (cbRelatorio.SelectedIndex == 10)
            {
                lblTipoVeiculo.Visible = true;
                cbTipoVeiculo.Visible = true;
                rdbPrescricao.Visible = false;
                rdbProtocolo.Visible = false;
                lblDe.Visible = false;
                lblAte.Visible = false;
                nudFim.Visible = false;
                nudInicio.Visible = false;
                lblCNPJ.Visible = false;
                txtCNPJ.Visible = false;
                rbCnpjCpf.Visible = false;
                rbRaiz.Visible = false;
                dtFim.Enabled = true;
                dtInicio.Enabled = true;
                txtCodEquipamento.Visible = true;
                lblCodEquipamento.Visible = true;
                lblLote.Visible = false;
                txtLote.Visible = false;
                lblEdital.Visible = false;
                cbEdital.Visible = false;
                dtFim.Visible = true;
                dtInicio.Visible = true;
                lblSituacao.Visible = false;
                cbSituacao.Visible = false;
                dtInicio.MinDate = new DateTime(1999, 1, 1);
                dtFim.MinDate = new DateTime(1999, 1, 1);
                dtInicio.MaxDate = new DateTime(2030, 1, 31);
                dtFim.MaxDate = new DateTime(2030, 1, 31);
                dtInicio.Value = new DateTime(2019, 1, 31);
                dtFim.Value = new DateTime(2019, 1, 31);
            }
            else if (cbRelatorio.SelectedIndex == 11)
            {
                lblTipoVeiculo.Visible = false;
                cbTipoVeiculo.Visible = false;
                rdbPrescricao.Visible = false;
                rdbProtocolo.Visible = false;
                lblDe.Visible = false;
                lblAte.Visible = false;
                nudFim.Visible = false;
                nudInicio.Visible = false;
                lblCNPJ.Visible = false;
                txtCNPJ.Visible = false;
                rbCnpjCpf.Visible = false;
                rbRaiz.Visible = false;
                dtFim.Enabled = false;
                dtInicio.Enabled = false;
                txtCodEquipamento.Visible = false;
                lblCodEquipamento.Visible = false;
                lblLote.Visible = false;
                txtLote.Visible = false;
                lblEdital.Visible = true;
                cbEdital.Visible = true;
                dtFim.Visible = false;
                dtInicio.Visible = false;
                lblSituacao.Visible = true;
                cbSituacao.Visible = true;
            }
            else
            {
                lblTipoVeiculo.Visible = false;
                cbTipoVeiculo.Visible = false;
                rdbPrescricao.Visible = false;
                rdbProtocolo.Visible = false;
                lblDe.Visible = true;
                lblAte.Visible = true;
                nudFim.Visible = true;
                nudInicio.Visible = true;
                lblCNPJ.Visible = false;
                txtCNPJ.Visible = false;
                rbCnpjCpf.Visible = false;
                rbRaiz.Visible = false;
                dtFim.Enabled = true;
                dtInicio.Enabled = true;
                txtCodEquipamento.Visible = false;
                lblCodEquipamento.Visible = false;
                lblLote.Visible = false;
                txtLote.Visible = false;
                lblEdital.Visible = false;
                cbEdital.Visible = false;
                dtFim.Visible = true;
                dtInicio.Visible = true;
                lblSituacao.Visible = false;
                cbSituacao.Visible = false;
                dtFim.MaxDate = DateTime.Now.AddDays(6);
                BloqueiaDesbloqueia(true);
            }
        }

        private List<RetornoProcessosSIOR> BuscaRegistrosProcessosSIOR(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = new List<RetornoProcessosSIOR>();
                var data = dataInicio;

                using (var db = new BD_SIORContext())
                {
                    var dadosSA = db.TblInfracaoSolicitacaoAdvertencia.Where(a => a.DataCadastroDnit >= dataInicio && a.DataCadastroDnit <= dataFim).OrderBy(a => a.DataCadastroDnit).ToList();
                    var dadosFICI = db.TblInfracaoIdentificacaoInfratorCondutor.Where(a => a.DataCadastro >= dataInicio && a.DataCadastro <= dataFim).OrderBy(a => a.DataCadastro).ToList();
                    var dadosDA = db.TblInfracaoDa.Where(a => a.DataCadastroDnit >= dataInicio && a.DataCadastroDnit <= dataFim).OrderBy(a => a.DataCadastroDnit).ToList();
                    var dadosRec1 = db.TblInfracaoRecurso.Where(a => a.DataCadastro >= dataInicio && a.DataCadastro <= dataFim.AddDays(1).AddTicks(-1) && a.CodigoInfracaoRecursoTipo == 1).OrderBy(a => a.DataCadastro).ToList();
                    var dadosRec2 = db.TblInfracaoRecurso.Where(a => a.DataCadastro >= dataInicio && a.DataCadastro <= dataFim.AddDays(1).AddTicks(-1) && a.CodigoInfracaoRecursoTipo != 1).OrderBy(a => a.DataCadastro).ToList();

                    spbProgresso.Value = 0;
                    spbProgresso.Maximum = (dataFim - data).Days + 1;

                    while (data <= dataFim)
                    {
                        spbProgresso.Value++;
                        var dados = new RetornoProcessosSIOR
                        {
                            Data = data.ToShortDateString(),
                            DA = dadosDA.Where(a => a.DataCadastroDnit == data).Count().ToString(),
                            FICI = dadosFICI.Where(a => a.DataCadastro == data).Count().ToString(),
                            SA = dadosSA.Where(a => a.DataCadastroDnit == data).Count().ToString(),
                            Recurso1estancia = dadosRec1.Where(a => a.DataCadastro >= data && a.DataCadastro <= data.AddDays(1).AddTicks(-1)).Count().ToString(),
                            Recurso2estancia = dadosRec2.Where(a => a.DataCadastro >= data && a.DataCadastro <= data.AddDays(1).AddTicks(-1)).Count().ToString()
                        };

                        retorno.Add(dados);
                        data = data.AddDays(1);
                    }

                    db.Dispose();
                }

                return retorno;
            }
            catch (Exception ex)
            {
                slProcessando.Text = "Erro ao executar: " + ex.Message;
                return null;
            }
        }

        private List<RetornoPNVC> BuscaRegistrosPNVC(DateTime dataInicio, DateTime dataFim, int tipoVeiculo, string equipamento, int lote)
        {
            try
            {
                var retorno = new List<RetornoPNVC>();
                int loteRemessa = 0;
                if (lote > 0)
                {
                    using (var bd = new BD_SIORContext())
                    {
                        loteRemessa = bd.TblPncveditalLote.Where(a => a.NumeroLote == lote && a.CodigoPncvedital == 122).FirstOrDefault().CodigoPncveditalLote;
                    }
                }

                using (var db = new BD_SIOR_PNCV_168_2016Context())
                {
                    var join = db.TblRegistroContagem.Join(db.TblRemessaDados, registro => registro.CodigoRemessaDados, remessa => remessa.CodigoRemessaDados, (registro, remessa) => new { registro, remessa })
                        .Where(a => a.registro.CodigoRemessaDados == a.remessa.CodigoRemessaDados && a.registro.DataHora >= dataInicio && a.registro.DataHora < dataFim 
                        && (tipoVeiculo == 0 ? a.registro.CodigoRegistroClasseVeiculo == null : tipoVeiculo == 5 ? a.registro.CodigoRegistroContagem > 0 : a.registro.CodigoRegistroClasseVeiculo == tipoVeiculo) 
                        && (string.IsNullOrEmpty(equipamento) ? a.remessa.CodigoEquipamentoDnit != null : a.remessa.CodigoEquipamentoDnit == equipamento)
                        && (lote == 0 ? a.remessa.CodigoPncveditalLote > 0 : a.remessa.CodigoPncveditalLote == loteRemessa))
                        .Take(int.Parse(nudFim.Value.ToString())).Skip(int.Parse(nudInicio.Value.ToString()));

                    spbProgresso.Value = 0;
                    spbProgresso.Maximum = join.Count();

                    foreach (var item in join)
                    {
                        spbProgresso.Value++;
                        var registro = new RetornoPNVC
                        {
                            Id = item.registro.CodigoRegistroContagem,
                            Classe = item.registro.CodigoRegistroClasseVeiculo == 1 ? "Motos" : 
                                        item.registro.CodigoRegistroClasseVeiculo == 2 ? "Carros e Veículos Pequenos" : 
                                        item.registro.CodigoRegistroClasseVeiculo == 3 ? "Caminhões Leves e Ônibus" : 
                                        item.registro.CodigoRegistroClasseVeiculo == 4 ? "Caminhões Pesados e Especiais" : "Não Especificado",
                            CodigoEquipamentoDnit = item.remessa.CodigoEquipamentoDnit,
                            Data = item.registro.DataHora.ToShortDateString(),
                            Horario = item.registro.DataHora.ToShortTimeString(),
                            LocalSentidoRodovia = item.remessa.LocalSentidoRodovia,
                            Velocidade = item.registro.Velocidade.ToString()
                        };

                        retorno.Add(registro);
                    }

                    db.Dispose();
                }

                return retorno;
            }
            catch (Exception ex)
            {
                slProcessando.Text = "Erro ao executar: " + ex.Message;
                return null;
            }
        }

        private List<RetornoPNVC> BuscaRegistrosPNVCLIC4(DateTime dataInicio, DateTime dataFim, int tipoVeiculo, string codEquipamento)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCodEquipamento.Text))
                {
                    MessageBox.Show("O código do equipamento é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodEquipamento.Focus();
                    return null;
                }

                var retorno = new List<RetornoPNVC>();
                string veiculo = cbTipoVeiculo.SelectedItem.ToString();

                using (var db = new PNCV_LIC4())
                {
                    var join = db.tblRegistroContagem.Join(db.tblRemessaDados, registro => registro.CodigoRemessaDados, remessa => remessa.CodigoRemessaDados, (registro, remessa) => new { registro, remessa })
                        .Where(a => a.registro.CodigoRemessaDados == a.remessa.CodigoRemessaDados && a.registro.DataHora >= dataInicio && a.registro.DataHora < dataFim
                        && a.remessa.CodigoEquipamentoDNIT == codEquipamento && (tipoVeiculo == 0 ? a.registro.CodigoRegistroClasseVeiculo == null : a.registro.CodigoRegistroClasseVeiculo == tipoVeiculo));

                    spbProgresso.Value = 0;
                    spbProgresso.Maximum = join.Count();

                    foreach (var item in join)
                    {
                        spbProgresso.Value++;
                        var registro = new RetornoPNVC
                        {
                            Id = item.registro.CodigoRegistroContagem,
                            Classe = veiculo,
                            CodigoEquipamentoDnit = item.remessa.CodigoEquipamentoDNIT,
                            Data = item.registro.DataHora.ToShortDateString(),
                            Horario = item.registro.DataHora.ToShortTimeString(),
                            LocalSentidoRodovia = item.remessa.LocalSentidoRodovia,
                            Velocidade = item.registro.Velocidade.ToString()
                        };

                        retorno.Add(registro);
                    }

                    db.Dispose();
                }

                return retorno;
            }
            catch (Exception ex)
            {
                slProcessando.Text = "Erro ao executar: " + ex.Message;
                return null;
            }
        }

        private List<RetornoCompletoEngenharia> BuscaRegistrosCompletoEngenharia(DateTime dataInicio, DateTime dataFim)
        {
            var retorno = new List<RetornoCompletoEngenharia>();

            try
            {
                using (var db = new BD_SIORContext())
                {
                    var dadosInfracao = db.TblInfracaoPreAutuacao.Where(a => a.DataInfracao >= dataInicio && a.DataInfracao <= dataFim)
                        .Skip((int)nudInicio.Value).Take((int)nudFim.Value).OrderBy(a => a.DataHoraInfracao).ToList();
                    var equipamentos = dadosInfracao.Select(a => a.EquipamentoAfericaoCodigoDnit);
                    var dadosEquipamentos = db.TblPncvequipamento.Where(a => equipamentos.Contains(a.CodigoEquipamentoDnit)).ToList();
                    var dadosTipo = db.TblPncvequipamentoTipo;
                    var dadosModelo = db.TblPncvmodeloEquipamento;
                    var dadosEnquadramento = db.TblInfracaoEnquadramento;
                    var dadosUf = db.TblBaseUf;
                    var estudos = dadosEquipamentos.Select(a => a.CodigoPncvestudoTecnicoInstalacaoEquipamento);
                    var dadosEstudo = db.TblPncvestudoTecnicoInstalacaoEquipamento.Where(a => estudos.Contains(a.CodigoPncvestudoTecnicoInstalacaoEquipamento)).ToList();
                    var dadosComunicacao = db.TblPncvequipamentoIndicadorComunicacao;
                    var dadosMotivo = db.TblInfracaoPreAutuacaoMotivoInvalidacao;

                    spbProgresso.Value = 0;
                    spbProgresso.Maximum = dadosInfracao.Count();

                    foreach (var item in dadosInfracao)
                    {
                        spbProgresso.Value++;
                        var eqp = dadosEquipamentos.Where(a => a.CodigoEquipamentoDnit == item.EquipamentoAfericaoCodigoDnit).FirstOrDefault();
                        var estudo = dadosEstudo.Where(a => a.CodigoPncvestudoTecnicoInstalacaoEquipamento == eqp.CodigoPncvestudoTecnicoInstalacaoEquipamento).FirstOrDefault();
                        var dados = new RetornoCompletoEngenharia
                        {
                            ConferenciaDoisPlacaVeiculo = item.ConferenciaDoisPlacaVeiculo,
                            ConferenciaUmPlacaVeiculo = item.ConferenciaUmPlacaVeiculo,
                            ConferenciaRevisaoPlacaVeiculo = item.ConferenciaRevisaoPlacaVeiculo,
                            Contrato = item.CodigoInfracaoOrigemContratacao.ToString(),
                            DataCadastro = item.DataCadastro.ToString(),
                            DataConferencia2 = item.ConferenciaDoisData.ToString(),
                            DataHoraInfracao = item.DataHoraInfracao.ToString(),
                            DataPreparação = item.PreparacaoImagemData.ToString(),
                            DataRevisão = item.ConferenciaRevisaoData.ToString(),
                            DescricaoInfracaoResumo = dadosEnquadramento.Where(a => a.CodigoInfracaoEnquadramento == item.CodigoInfracaoEnquadramento) != null ?
                                                      dadosEnquadramento.Where(a => a.CodigoInfracaoEnquadramento == item.CodigoInfracaoEnquadramento).FirstOrDefault().DescricaoInfracaoResumo : "",
                            EquipamentoAfericaoCodigoDnit = item.EquipamentoAfericaoCodigoDnit,
                            FaixaSentidoVia = item.LocalInfracaoRodoviaFaixa,
                            LimiteRegulamentado = item.LimiteRegulamentado.ToString(),
                            LocalInfracaoKm = item.LocalInfracaoKm.ToString(),
                            LocalInfracaoRodovia = item.LocalInfracaoRodovia,
                            MarcaModeloEquipamento = dadosModelo.Where(a => a.CodigoPncvmodeloEquipamento == eqp.CodigoPncvmodeloEquipamento) != null ?
                                                     dadosModelo.Where(a => a.CodigoPncvmodeloEquipamento == eqp.CodigoPncvmodeloEquipamento).FirstOrDefault().Nome : "",
                            MedicaoRealizada = item.MedicaoRealizada.ToString(),
                            MotivoInvalidaçãoFinal = item.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferencia != null ? dadosMotivo.Where(a => a.CodigoInfracaoPreAutuacaoMotivoInvalidacao == item.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferencia) != null ?
                                                     dadosMotivo.Where(a => a.CodigoInfracaoPreAutuacaoMotivoInvalidacao == item.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferencia).FirstOrDefault().Descricao : "" : "",
                            Municipio = item.CodigoRenavammunicipioLocalInfracao.ToString(),
                            OnlineOffline = estudo != null ? dadosComunicacao.Where(a => a.CodigoPncvequipamentoIndicadorComunicacao == estudo.CodigoPncvequipamentoIndicadorComunicacao) != null ?
                                            dadosComunicacao.Where(a => a.CodigoPncvequipamentoIndicadorComunicacao == estudo.CodigoPncvequipamentoIndicadorComunicacao).FirstOrDefault().Nome : "" : "",
                            TipoEquipamento = dadosTipo.Where(a => a.CodigoPncvequipamentoTipo == eqp.CodigoPncvequipamentoTipo) != null ?
                                              dadosTipo.Where(a => a.CodigoPncvequipamentoTipo == eqp.CodigoPncvequipamentoTipo).FirstOrDefault().Sigla : "",
                            UF = dadosUf.Where(a => a.CodigoBaseUf == item.CodigoUflocalInfracao) != null ?
                                 dadosUf.Where(a => a.CodigoBaseUf == item.CodigoUflocalInfracao).FirstOrDefault().Sigla : "",
                            ValorConsiderado = item.ValorConsiderado.ToString(),
                            VeiculoPlacaFinal = item.VeiculoPlacaFinal
                        };

                        retorno.Add(dados);
                    }

                    db.Dispose();
                }

                return retorno;
            }
            catch (Exception ex)
            {
                slProcessando.Text = "Erro ao executar: " + ex.Message;
                return null;
            }
        }

        private List<RetornoResumoEquipamentos> ResumoEquipamentos(int edital, int situacao)
        {
            try
            {
                var retorno = new List<RetornoResumoEquipamentos>();
                using (var db = new BD_SIORContext())
                {
                    var equipamentos = db.TblPncvequipamentoFaixa.Include("CodigoPncvequipamentoNavigation")
                        .Include("CodigoPncvequipamentoNavigation.CodigoBaseRodoviaNavigation")
                        .Include("CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation")
                        .Include("CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.CodigoPncveditalNavigation")
                        .Include("CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.CodigoPncvoperadoraNavigation")
                        .Include("CodigoPncvequipamentoNavigation.CodigoPncvequipamentoTipoNavigation")
                        .Include("CodigoPncvequipamentoNavigation.CodigoBaseUfNavigation")
                        .Include("CodigoPncvtipoViaNavigation")
                        .Include("CodigoPncvsentidoRodoviaNavigation")
                        .Include("CodigoPncvequipamentoFaixaSituacaoNavigation")
                        .Where(a => a.CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.CodigoPncvedital == edital
                        && situacao > 0 ? a.CodigoPncvequipamentoFaixaSituacao == situacao : a.CodigoPncvequipamentoFaixaSituacao > 0).OrderBy(a => a.CodigoPncvequipamento);

                    spbProgresso.Value = 0;
                    spbProgresso.Maximum = equipamentos.Count();

                    foreach (var item in equipamentos)
                    {
                        spbProgresso.Value++;

                        if (item.CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.CodigoPncvedital != edital)
                            continue;

                        var estudo = db.TblPncvequipamentoEstudoTecnicoFaixa
                            .Include("CodigoPncvequipamentoEstudoTecnicoNavigation")
                            .Include("CodigoPncvequipamentoEstudoTecnicoNavigation.CodigoPncvestudoTecnicoInstalacaoNavigation")
                            .Include("CodigoPncvequipamentoEstudoTecnicoNavigation.CodigoPncvestudoTecnicoInstalacaoNavigation.CodigoPncvestudoViabilidadeNavigation")
                            .Where(a => a.CodigoPncvequipamentoEstudoTecnicoNavigation.CodigoPncvequipamento == item.CodigoPncvequipamento).FirstOrDefault();
                        
                        var dados = new RetornoResumoEquipamentos
                        {
                            BR = item.CodigoPncvequipamentoNavigation.CodigoBaseRodoviaNavigation.Numero,
                            CodigoEquipamentoDnit = item.CodigoPncvequipamentoNavigation.CodigoEquipamentoDnit,
                            EditalLoteOperadora = item.CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.CodigoPncveditalNavigation.Numero + " / " +
                                                  item.CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.NumeroLote + " (" +
                                                  item.CodigoPncvequipamentoNavigation.CodigoPncveditalLoteNavigation.CodigoPncvoperadoraNavigation.Nome + ")",
                            SNV = item.CodigoPncvequipamentoNavigation.CodigoSnv,
                            InicioOperacao = item.DataInicioOperacao == null ? "" : DateTime.Parse(item.DataInicioOperacao.ToString()).ToShortDateString(),
                            KM = item.CodigoPncvequipamentoNavigation.NumeroKm.ToString(),
                            NoFaixas = equipamentos.Where(a => a.CodigoPncvequipamento == item.CodigoPncvequipamento).Count().ToString(),
                            Faixas = item.CodigoPncvtipoViaNavigation.Sigla + "-" + item.CodigoPncvsentidoRodoviaNavigation.Sigla + "-" + item.Numero,
                            Situacao = item.CodigoPncvequipamentoFaixaSituacaoNavigation.Nome,
                            TipoEquipamento = item.CodigoPncvequipamentoNavigation.CodigoPncvequipamentoTipoNavigation.Sigla,
                            UF = item.CodigoPncvequipamentoNavigation.CodigoBaseUfNavigation.Sigla,
                            ValocidadeRegulamentada = estudo.VelocidadeVeiculoLeve.ToString() + "/" + estudo.VelocidadeVeiculoPesado.ToString(),
                            Latitude = item.CodigoPncvequipamentoNavigation.Coordenadas.Y.ToString(),
                            Longitude = item.CodigoPncvequipamentoNavigation.Coordenadas.X.ToString(),
                            CodigoEstudoTecnico = estudo.CodigoPncvequipamentoEstudoTecnicoNavigation != null ? 
                                                  estudo.CodigoPncvequipamentoEstudoTecnicoNavigation.CodigoPncvestudoTecnicoInstalacaoNavigation != null ? 
                                                  estudo.CodigoPncvequipamentoEstudoTecnicoNavigation.CodigoPncvestudoTecnicoInstalacaoNavigation.CodigoIdentificacaoDnit 
                                                  : "" : "",
                            CodigoEstudoViabilidade = estudo.CodigoPncvequipamentoEstudoTecnicoNavigation != null ?
                                                  estudo.CodigoPncvequipamentoEstudoTecnicoNavigation.CodigoPncvestudoTecnicoInstalacaoNavigation != null ?
                                                  estudo.CodigoPncvequipamentoEstudoTecnicoNavigation.CodigoPncvestudoTecnicoInstalacaoNavigation.CodigoPncvestudoViabilidadeNavigation != null ?
                                                  estudo.CodigoPncvequipamentoEstudoTecnicoNavigation.CodigoPncvestudoTecnicoInstalacaoNavigation.CodigoPncvestudoViabilidadeNavigation.CodigoIdentificacaoDnit
                                                  : "" : "" : ""
                        };

                        var paralisacao = db.TblPncvequipamentoFaixaParalisacao.Where(a => a.CodigoPncvequipamentoFaixa == item.CodigoPncvequipamentoFaixa).ToList();

                        foreach (var paradas in paralisacao)
                        {
                            var parada = new Paralisacoes
                            {
                                CodigoEquipamentoDnit = item.CodigoPncvequipamentoNavigation.CodigoEquipamentoDnit,
                                Faixa = dados.Faixas,
                                Inicio = paradas.DataInicio.ToShortDateString(),
                                Fim = paradas.DataEncerramento == null ? "" : DateTime.Parse(paradas.DataEncerramento.ToString()).ToShortDateString()
                            };

                            _paralisacoes.Add(parada);
                        }

                        using (var renavam = new RENAVAMContext())
                        {
                            var municipio = renavam.tblRENAVAMMunicipio.Where(a => a.CodigoRENAVAMMunicipio == item.CodigoPncvequipamentoNavigation.CodigoRenavammunicipio).FirstOrDefault();
                            dados.Municipio = municipio != null ? municipio.Nome : "";
                            
                            renavam.Dispose();
                        }

                        retorno.Add(dados);
                    }

                    db.Dispose();
                }

                return retorno;
            }
            catch (Exception ex)
            {
                slProcessando.Text = "Erro ao executar: " + ex.Message;
                return null;
            }
        }

        private List<RetornoImgsValidasInvalidas> BuscaRegistrosImngsValidasInvalidas(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var retorno = new List<RetornoImgsValidasInvalidas>();
                var data = dataInicio;

                using (var db = new BD_SIORContext())
                {
                    var dadosValidos = db.TblInfracaoPreAutuacao.Where(a => a.PreparacaoImagemData >= dataInicio && a.PreparacaoImagemData <= dataFim);
                    var dadosInvalidos = db.TblInfracaoPreAutuacao.Where(a => a.ConferenciaData >= dataInicio && a.ConferenciaData <= dataFim.AddDays(1).AddTicks(-1))
                                         .Where(a => (a.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUm == a.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaDois
                                         && a.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUm != null) || a.CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaRevisao != null);

                    spbProgresso.Value = 0;
                    spbProgresso.Maximum = (dataFim - data).Days + 1;

                    while (data <= dataFim)
                    {
                        spbProgresso.Value++;
                        var dataf = data.AddDays(1).AddTicks(-1);
                        var dados = new RetornoImgsValidasInvalidas
                        {
                            Data = data.ToShortDateString(),
                            Validos = dadosValidos.Where(a => a.PreparacaoImagemData >= data && a.PreparacaoImagemData <= dataf).Count().ToString(),
                            Invalidos = dadosInvalidos.Where(a => a.ConferenciaData >= data && a.ConferenciaData <= dataf).Count().ToString()
                        };

                        retorno.Add(dados);
                        data = data.AddDays(1);
                    }

                    db.Dispose();
                }

                return retorno;
            }
            catch (Exception ex)
            {
                slProcessando.Text = "Erro ao executar: " + ex.Message;
                return null;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgDados.Rows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente salvar?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                saveFileDialog1.Title = "Salvar arquivo";
                saveFileDialog1.FileName = cbRelatorio.SelectedItem.ToString();

                if (cbRelatorio.SelectedIndex == 0 || cbRelatorio.SelectedIndex == 10)
                {
                    saveFileDialog1.DefaultExt = ".xlsx";
                    saveFileDialog1.Filter = ".xlsx|*.xlsx";

                    DialogResult resultado = saveFileDialog1.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        BloqueiaDesbloqueia(false);

                        using (LocalReport report = new LocalReport())
                        {
                            ReportDataSource dataSource = new ReportDataSource("DataSet1", dgDados.DataSource);
                            report.ReportPath = @"Relatorios\PNCV.rdlc";
                            report.DataSources.Add(dataSource);
                            var xls = new SalvarXls();
                            xls.Export(report, saveFileDialog1.FileName);
                        }

                        BloqueiaDesbloqueia(true);
                        MessageBox.Show("O arquivo foi salvo com sucesso! Caminho: " + saveFileDialog1.FileName, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (cbRelatorio.SelectedIndex == 11)
                {
                    saveFileDialog1.DefaultExt = ".xlsx";
                    saveFileDialog1.Filter = ".xlsx|*.xlsx";

                    DialogResult resultado = saveFileDialog1.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        BloqueiaDesbloqueia(false);

                        using (LocalReport report = new LocalReport())
                        {
                            ReportDataSource dataSource = new ReportDataSource("DataSet1", dgDados.DataSource);
                            ReportDataSource dataSource2 = new ReportDataSource("DataSet2", _paralisacoes);
                            report.ReportPath = @"Relatorios\ResumoEquipamentos.rdlc";
                            report.DataSources.Add(dataSource);
                            report.DataSources.Add(dataSource2);
                            var xls = new SalvarXls();
                            xls.Export(report, saveFileDialog1.FileName);
                        }

                        BloqueiaDesbloqueia(true);
                        MessageBox.Show("O arquivo foi salvo com sucesso! Caminho: " + saveFileDialog1.FileName, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (cbRelatorio.SelectedIndex == 6)
                {
                    saveFileDialog1.DefaultExt = ".xlsx";
                    saveFileDialog1.Filter = ".xlsx|*.xlsx";

                    DialogResult resultado = saveFileDialog1.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        BloqueiaDesbloqueia(false);

                        using (LocalReport report = new LocalReport())
                        {
                            ReportDataSource dataSource = new ReportDataSource("DataSet1", dgDados.DataSource);
                            report.ReportPath = @"Relatorios\RecursosJari.rdlc";
                            report.DataSources.Add(dataSource);
                            var xls = new SalvarXls();
                            xls.Export(report, saveFileDialog1.FileName);
                        }

                        BloqueiaDesbloqueia(true);
                        MessageBox.Show("O arquivo foi salvo com sucesso! Caminho: " + saveFileDialog1.FileName, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (cbRelatorio.SelectedIndex == 7)
                {
                    saveFileDialog1.DefaultExt = ".xlsx";
                    saveFileDialog1.Filter = "*.xlsx|*.xlsx";

                    DialogResult resultado = saveFileDialog1.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        BloqueiaDesbloqueia(false);

                        using (LocalReport report = new LocalReport())
                        {
                            ReportDataSource dataSource = new ReportDataSource("DataSet1", dgDados.DataSource);
                            report.ReportPath = @"Relatorios\Juridico.rdlc";
                            report.DataSources.Add(dataSource);
                            var xls = new SalvarXls();
                            xls.Export(report, saveFileDialog1.FileName);
                        }

                        BloqueiaDesbloqueia(true);
                        MessageBox.Show("O arquivo foi salvo com sucesso! Caminho: " + saveFileDialog1.FileName, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    saveFileDialog1.DefaultExt = ".csv";
                    saveFileDialog1.Filter = ".csv|*.csv";

                    DialogResult resultado = saveFileDialog1.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        BloqueiaDesbloqueia(false);
                        dgDados.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                        dgDados.SelectAll();
                        DataObject dataObject = dgDados.GetClipboardContent();
                        File.WriteAllText(saveFileDialog1.FileName, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
                        BloqueiaDesbloqueia(true);
                        MessageBox.Show("O arquivo foi salvo com sucesso! Caminho: " + saveFileDialog1.FileName, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            { 
                MessageBox.Show("Não existem dados para serem salvos. Por favor, execute um relatório.", "Atenção!", MessageBoxButtons.OK);
                return;
            }

        }

        private void dtInicio_ValueChanged(object sender, EventArgs e)
        {
            dtFim.MinDate = dtInicio.Value;
            dtFim.Value = dtInicio.Value.AddDays(6);

            if (cbRelatorio.SelectedIndex == 6)
                dtFim.MaxDate = dtInicio.Value.AddYears(1);
            else if (cbRelatorio.SelectedIndex == 7 || cbRelatorio.SelectedIndex == 8)
                dtFim.Value = DateTime.Now.Date;
        }
    }
}
