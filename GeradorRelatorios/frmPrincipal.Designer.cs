namespace GeradorRelatorios
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.lblEdital = new System.Windows.Forms.Label();
            this.cbEdital = new System.Windows.Forms.ComboBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.lblCodEquipamento = new System.Windows.Forms.Label();
            this.txtCodEquipamento = new System.Windows.Forms.TextBox();
            this.rbRaiz = new System.Windows.Forms.RadioButton();
            this.rbCnpjCpf = new System.Windows.Forms.RadioButton();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.rdbPrescricao = new System.Windows.Forms.RadioButton();
            this.rdbProtocolo = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.nudFim = new System.Windows.Forms.NumericUpDown();
            this.lblAte = new System.Windows.Forms.Label();
            this.nudInicio = new System.Windows.Forms.NumericUpDown();
            this.lblDe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoVeiculo = new System.Windows.Forms.ComboBox();
            this.lblTipoVeiculo = new System.Windows.Forms.Label();
            this.cbRelatorio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slQuantidade = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.spbProgresso = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slProcessando = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tblRegistroContagemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInicio)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistroContagemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSituacao);
            this.groupBox1.Controls.Add(this.cbSituacao);
            this.groupBox1.Controls.Add(this.lblEdital);
            this.groupBox1.Controls.Add(this.cbEdital);
            this.groupBox1.Controls.Add(this.lblLote);
            this.groupBox1.Controls.Add(this.txtLote);
            this.groupBox1.Controls.Add(this.lblCodEquipamento);
            this.groupBox1.Controls.Add(this.txtCodEquipamento);
            this.groupBox1.Controls.Add(this.rbRaiz);
            this.groupBox1.Controls.Add(this.rbCnpjCpf);
            this.groupBox1.Controls.Add(this.lblCNPJ);
            this.groupBox1.Controls.Add(this.txtCNPJ);
            this.groupBox1.Controls.Add(this.rdbPrescricao);
            this.groupBox1.Controls.Add(this.rdbProtocolo);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.nudFim);
            this.groupBox1.Controls.Add(this.lblAte);
            this.groupBox1.Controls.Add(this.nudInicio);
            this.groupBox1.Controls.Add(this.lblDe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbTipoVeiculo);
            this.groupBox1.Controls.Add(this.lblTipoVeiculo);
            this.groupBox1.Controls.Add(this.cbRelatorio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtFim);
            this.groupBox1.Controls.Add(this.dtInicio);
            this.groupBox1.Controls.Add(this.btnExecutar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Filtros ";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(11, 50);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 28;
            this.lblSituacao.Text = "Situação:";
            this.lblSituacao.Visible = false;
            // 
            // cbSituacao
            // 
            this.cbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Location = new System.Drawing.Point(69, 46);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(175, 21);
            this.cbSituacao.TabIndex = 27;
            this.cbSituacao.Visible = false;
            // 
            // lblEdital
            // 
            this.lblEdital.AutoSize = true;
            this.lblEdital.Location = new System.Drawing.Point(11, 22);
            this.lblEdital.Name = "lblEdital";
            this.lblEdital.Size = new System.Drawing.Size(36, 13);
            this.lblEdital.TabIndex = 26;
            this.lblEdital.Text = "Edital:";
            this.lblEdital.Visible = false;
            // 
            // cbEdital
            // 
            this.cbEdital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEdital.FormattingEnabled = true;
            this.cbEdital.Location = new System.Drawing.Point(53, 18);
            this.cbEdital.Name = "cbEdital";
            this.cbEdital.Size = new System.Drawing.Size(191, 21);
            this.cbEdital.TabIndex = 25;
            this.cbEdital.Visible = false;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(480, 49);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(31, 13);
            this.lblLote.TabIndex = 24;
            this.lblLote.Text = "Lote:";
            this.lblLote.Visible = false;
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(517, 44);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(100, 20);
            this.txtLote.TabIndex = 23;
            this.txtLote.Visible = false;
            // 
            // lblCodEquipamento
            // 
            this.lblCodEquipamento.AutoSize = true;
            this.lblCodEquipamento.Location = new System.Drawing.Point(244, 49);
            this.lblCodEquipamento.Name = "lblCodEquipamento";
            this.lblCodEquipamento.Size = new System.Drawing.Size(97, 13);
            this.lblCodEquipamento.TabIndex = 22;
            this.lblCodEquipamento.Text = "Cod. Equipamento:";
            this.lblCodEquipamento.Visible = false;
            // 
            // txtCodEquipamento
            // 
            this.txtCodEquipamento.Location = new System.Drawing.Point(347, 44);
            this.txtCodEquipamento.Name = "txtCodEquipamento";
            this.txtCodEquipamento.Size = new System.Drawing.Size(128, 20);
            this.txtCodEquipamento.TabIndex = 21;
            this.txtCodEquipamento.Visible = false;
            // 
            // rbRaiz
            // 
            this.rbRaiz.AutoSize = true;
            this.rbRaiz.Location = new System.Drawing.Point(97, 82);
            this.rbRaiz.Name = "rbRaiz";
            this.rbRaiz.Size = new System.Drawing.Size(78, 17);
            this.rbRaiz.TabIndex = 18;
            this.rbRaiz.Text = "Raíz CNPJ";
            this.rbRaiz.UseVisualStyleBackColor = true;
            // 
            // rbCnpjCpf
            // 
            this.rbCnpjCpf.AutoSize = true;
            this.rbCnpjCpf.Checked = true;
            this.rbCnpjCpf.Location = new System.Drawing.Point(13, 82);
            this.rbCnpjCpf.Name = "rbCnpjCpf";
            this.rbCnpjCpf.Size = new System.Drawing.Size(77, 17);
            this.rbCnpjCpf.TabIndex = 17;
            this.rbCnpjCpf.TabStop = true;
            this.rbCnpjCpf.Text = "CNPJ/CPF";
            this.rbCnpjCpf.UseVisualStyleBackColor = true;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(13, 54);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(62, 13);
            this.lblCNPJ.TabIndex = 16;
            this.lblCNPJ.Text = "CPF/CNPJ:";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(83, 49);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(161, 20);
            this.txtCNPJ.TabIndex = 15;
            // 
            // rdbPrescricao
            // 
            this.rdbPrescricao.AutoSize = true;
            this.rdbPrescricao.Location = new System.Drawing.Point(120, 52);
            this.rdbPrescricao.Name = "rdbPrescricao";
            this.rdbPrescricao.Size = new System.Drawing.Size(101, 17);
            this.rdbPrescricao.TabIndex = 14;
            this.rdbPrescricao.Text = "Data Prescrição";
            this.rdbPrescricao.UseVisualStyleBackColor = true;
            this.rdbPrescricao.Visible = false;
            // 
            // rdbProtocolo
            // 
            this.rdbProtocolo.AutoSize = true;
            this.rdbProtocolo.Location = new System.Drawing.Point(12, 52);
            this.rdbProtocolo.Name = "rdbProtocolo";
            this.rdbProtocolo.Size = new System.Drawing.Size(96, 17);
            this.rdbProtocolo.TabIndex = 13;
            this.rdbProtocolo.Text = "Data Protocolo";
            this.rdbProtocolo.UseVisualStyleBackColor = true;
            this.rdbProtocolo.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(485, 70);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(132, 31);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // nudFim
            // 
            this.nudFim.Location = new System.Drawing.Point(145, 81);
            this.nudFim.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudFim.Name = "nudFim";
            this.nudFim.Size = new System.Drawing.Size(72, 20);
            this.nudFim.TabIndex = 11;
            this.nudFim.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Location = new System.Drawing.Point(117, 85);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(22, 13);
            this.lblAte.TabIndex = 10;
            this.lblAte.Text = "até";
            // 
            // nudInicio
            // 
            this.nudInicio.Location = new System.Drawing.Point(38, 81);
            this.nudInicio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudInicio.Name = "nudInicio";
            this.nudInicio.Size = new System.Drawing.Size(72, 20);
            this.nudInicio.TabIndex = 9;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(13, 85);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(27, 13);
            this.lblDe.TabIndex = 8;
            this.lblDe.Text = "De: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de Relatório:";
            // 
            // cbTipoVeiculo
            // 
            this.cbTipoVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoVeiculo.FormattingEnabled = true;
            this.cbTipoVeiculo.Location = new System.Drawing.Point(91, 48);
            this.cbTipoVeiculo.Name = "cbTipoVeiculo";
            this.cbTipoVeiculo.Size = new System.Drawing.Size(153, 21);
            this.cbTipoVeiculo.TabIndex = 6;
            // 
            // lblTipoVeiculo
            // 
            this.lblTipoVeiculo.AutoSize = true;
            this.lblTipoVeiculo.Location = new System.Drawing.Point(13, 52);
            this.lblTipoVeiculo.Name = "lblTipoVeiculo";
            this.lblTipoVeiculo.Size = new System.Drawing.Size(71, 13);
            this.lblTipoVeiculo.TabIndex = 5;
            this.lblTipoVeiculo.Text = "Tipo Veículo:";
            // 
            // cbRelatorio
            // 
            this.cbRelatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRelatorio.FormattingEnabled = true;
            this.cbRelatorio.Location = new System.Drawing.Point(347, 19);
            this.cbRelatorio.Name = "cbRelatorio";
            this.cbRelatorio.Size = new System.Drawing.Size(270, 21);
            this.cbRelatorio.TabIndex = 4;
            this.cbRelatorio.SelectedIndexChanged += new System.EventHandler(this.cbRelatorio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "até";
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(145, 19);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(99, 20);
            this.dtFim.TabIndex = 2;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(12, 19);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(99, 20);
            this.dtInicio.TabIndex = 1;
            this.dtInicio.ValueChanged += new System.EventHandler(this.dtInicio_ValueChanged);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(347, 70);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(132, 31);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.statusStrip1);
            this.groupBox2.Controls.Add(this.dgDados);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(917, 543);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slQuantidade,
            this.toolStripStatusLabel1,
            this.spbProgresso,
            this.toolStripStatusLabel2,
            this.slProcessando});
            this.statusStrip1.Location = new System.Drawing.Point(3, 518);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(911, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slQuantidade
            // 
            this.slQuantidade.Name = "slQuantidade";
            this.slQuantidade.Size = new System.Drawing.Size(67, 17);
            this.slQuantidade.Text = "Registros: 0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // spbProgresso
            // 
            this.spbProgresso.Name = "spbProgresso";
            this.spbProgresso.Size = new System.Drawing.Size(300, 16);
            this.spbProgresso.Step = 1;
            this.spbProgresso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // slProcessando
            // 
            this.slProcessando.Name = "slProcessando";
            this.slProcessando.Size = new System.Drawing.Size(0, 17);
            // 
            // dgDados
            // 
            this.dgDados.AllowUserToAddRows = false;
            this.dgDados.AllowUserToDeleteRows = false;
            this.dgDados.AllowUserToOrderColumns = true;
            this.dgDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Location = new System.Drawing.Point(3, 16);
            this.dgDados.Name = "dgDados";
            this.dgDados.ReadOnly = true;
            this.dgDados.Size = new System.Drawing.Size(911, 499);
            this.dgDados.TabIndex = 0;
            // 
            // tblRegistroContagemBindingSource
            // 
            this.tblRegistroContagemBindingSource.DataSource = typeof(GeradorRelatorios.TblRegistroContagem);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 656);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmPrincipal";
            this.Text = "Gerador de Relatórios - SIOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInicio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistroContagemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.BindingSource tblRegistroContagemBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.ComboBox cbRelatorio;
        private System.Windows.Forms.ComboBox cbTipoVeiculo;
        private System.Windows.Forms.Label lblTipoVeiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slQuantidade;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar spbProgresso;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel slProcessando;
        private System.Windows.Forms.NumericUpDown nudFim;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.NumericUpDown nudInicio;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton rdbPrescricao;
        private System.Windows.Forms.RadioButton rdbProtocolo;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.RadioButton rbRaiz;
        private System.Windows.Forms.RadioButton rbCnpjCpf;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label lblCodEquipamento;
        private System.Windows.Forms.TextBox txtCodEquipamento;
        private System.Windows.Forms.Label lblEdital;
        private System.Windows.Forms.ComboBox cbEdital;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.ComboBox cbSituacao;
    }
}

