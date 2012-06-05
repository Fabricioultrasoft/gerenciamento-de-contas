namespace Gerenciamento_de_Contas
{
    partial class frm_cadastrarDebito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label credorLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label data_emissaoLabel;
            System.Windows.Forms.Label data_vencimentoLabel;
            System.Windows.Forms.Label forma_pagamentoLabel;
            System.Windows.Forms.Label multaLabel;
            System.Windows.Forms.Label jurosLabel;
            System.Windows.Forms.Label total_parcelasLabel;
            System.Windows.Forms.Label valor_parcelaLabel;
            System.Windows.Forms.Label situacaoLabel;
            System.Windows.Forms.Label idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastrarDebito));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_datapag = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.contas_PagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contas_DBDataSet = new Gerenciamento_de_Contas.Contas_DBDataSet();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.credorTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.data_emissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_vencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_pagamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.forma_pagamentoComboBox = new System.Windows.Forms.ComboBox();
            this.multaTextBox = new System.Windows.Forms.TextBox();
            this.jurosTextBox = new System.Windows.Forms.TextBox();
            this.total_parcelasTextBox = new System.Windows.Forms.TextBox();
            this.valor_parcelaTextBox = new System.Windows.Forms.TextBox();
            this.situacaoComboBox = new System.Windows.Forms.ComboBox();
            this.contas_PagarTableAdapter = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.Contas_PagarTableAdapter();
            this.tableAdapterManager = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.TableAdapterManager();
            credorLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            data_emissaoLabel = new System.Windows.Forms.Label();
            data_vencimentoLabel = new System.Windows.Forms.Label();
            forma_pagamentoLabel = new System.Windows.Forms.Label();
            multaLabel = new System.Windows.Forms.Label();
            jurosLabel = new System.Windows.Forms.Label();
            total_parcelasLabel = new System.Windows.Forms.Label();
            valor_parcelaLabel = new System.Windows.Forms.Label();
            situacaoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contas_PagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // credorLabel
            // 
            credorLabel.AutoSize = true;
            credorLabel.BackColor = System.Drawing.Color.Transparent;
            credorLabel.Location = new System.Drawing.Point(127, 129);
            credorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            credorLabel.Name = "credorLabel";
            credorLabel.Size = new System.Drawing.Size(64, 17);
            credorLabel.TabIndex = 2;
            credorLabel.Text = "Credor  *";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.BackColor = System.Drawing.Color.Transparent;
            descricaoLabel.Location = new System.Drawing.Point(127, 358);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(71, 17);
            descricaoLabel.TabIndex = 4;
            descricaoLabel.Text = "Descrição";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.BackColor = System.Drawing.Color.Transparent;
            valorLabel.Location = new System.Drawing.Point(137, 160);
            valorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(54, 17);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "Valor  *";
            // 
            // data_emissaoLabel
            // 
            data_emissaoLabel.AutoSize = true;
            data_emissaoLabel.BackColor = System.Drawing.Color.Transparent;
            data_emissaoLabel.Location = new System.Drawing.Point(83, 233);
            data_emissaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_emissaoLabel.Name = "data_emissaoLabel";
            data_emissaoLabel.Size = new System.Drawing.Size(115, 17);
            data_emissaoLabel.TabIndex = 8;
            data_emissaoLabel.Text = "Data de Emissão";
            // 
            // data_vencimentoLabel
            // 
            data_vencimentoLabel.AutoSize = true;
            data_vencimentoLabel.BackColor = System.Drawing.Color.Transparent;
            data_vencimentoLabel.Location = new System.Drawing.Point(62, 267);
            data_vencimentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_vencimentoLabel.Name = "data_vencimentoLabel";
            data_vencimentoLabel.Size = new System.Drawing.Size(136, 17);
            data_vencimentoLabel.TabIndex = 10;
            data_vencimentoLabel.Text = "Data de Vencimento";
            // 
            // forma_pagamentoLabel
            // 
            forma_pagamentoLabel.AutoSize = true;
            forma_pagamentoLabel.BackColor = System.Drawing.Color.Transparent;
            forma_pagamentoLabel.Location = new System.Drawing.Point(41, 191);
            forma_pagamentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            forma_pagamentoLabel.Name = "forma_pagamentoLabel";
            forma_pagamentoLabel.Size = new System.Drawing.Size(157, 17);
            forma_pagamentoLabel.TabIndex = 14;
            forma_pagamentoLabel.Text = "Forma de Pagamento  *";
            // 
            // multaLabel
            // 
            multaLabel.AutoSize = true;
            multaLabel.BackColor = System.Drawing.Color.Transparent;
            multaLabel.Location = new System.Drawing.Point(143, 296);
            multaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            multaLabel.Name = "multaLabel";
            multaLabel.Size = new System.Drawing.Size(55, 17);
            multaLabel.TabIndex = 16;
            multaLabel.Text = "Multa  *";
            // 
            // jurosLabel
            // 
            jurosLabel.AutoSize = true;
            jurosLabel.BackColor = System.Drawing.Color.Transparent;
            jurosLabel.Location = new System.Drawing.Point(465, 296);
            jurosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            jurosLabel.Name = "jurosLabel";
            jurosLabel.Size = new System.Drawing.Size(56, 17);
            jurosLabel.TabIndex = 18;
            jurosLabel.Text = "Juros  *";
            // 
            // total_parcelasLabel
            // 
            total_parcelasLabel.AutoSize = true;
            total_parcelasLabel.BackColor = System.Drawing.Color.Transparent;
            total_parcelasLabel.Location = new System.Drawing.Point(66, 327);
            total_parcelasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            total_parcelasLabel.Name = "total_parcelasLabel";
            total_parcelasLabel.Size = new System.Drawing.Size(132, 17);
            total_parcelasLabel.TabIndex = 20;
            total_parcelasLabel.Text = "Total de Parcelas  *";
            // 
            // valor_parcelaLabel
            // 
            valor_parcelaLabel.AutoSize = true;
            valor_parcelaLabel.BackColor = System.Drawing.Color.Transparent;
            valor_parcelaLabel.Location = new System.Drawing.Point(362, 327);
            valor_parcelaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valor_parcelaLabel.Name = "valor_parcelaLabel";
            valor_parcelaLabel.Size = new System.Drawing.Size(126, 17);
            valor_parcelaLabel.TabIndex = 22;
            valor_parcelaLabel.Text = "Valor da Parcela  *";
            // 
            // situacaoLabel
            // 
            situacaoLabel.AutoSize = true;
            situacaoLabel.BackColor = System.Drawing.Color.Transparent;
            situacaoLabel.Location = new System.Drawing.Point(137, 434);
            situacaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            situacaoLabel.Name = "situacaoLabel";
            situacaoLabel.Size = new System.Drawing.Size(61, 17);
            situacaoLabel.TabIndex = 24;
            situacaoLabel.Text = "Status  *";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.Color.Transparent;
            idLabel.Location = new System.Drawing.Point(168, 96);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 17);
            idLabel.TabIndex = 31;
            idLabel.Text = "ID";
            idLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lb_datapag);
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.bt_novo);
            this.panel1.Controls.Add(this.bt_salvar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(credorLabel);
            this.panel1.Controls.Add(this.credorTextBox);
            this.panel1.Controls.Add(descricaoLabel);
            this.panel1.Controls.Add(this.descricaoTextBox);
            this.panel1.Controls.Add(valorLabel);
            this.panel1.Controls.Add(this.valorTextBox);
            this.panel1.Controls.Add(data_emissaoLabel);
            this.panel1.Controls.Add(this.data_emissaoDateTimePicker);
            this.panel1.Controls.Add(data_vencimentoLabel);
            this.panel1.Controls.Add(this.data_vencimentoDateTimePicker);
            this.panel1.Controls.Add(this.data_pagamentoDateTimePicker);
            this.panel1.Controls.Add(forma_pagamentoLabel);
            this.panel1.Controls.Add(this.forma_pagamentoComboBox);
            this.panel1.Controls.Add(multaLabel);
            this.panel1.Controls.Add(this.multaTextBox);
            this.panel1.Controls.Add(jurosLabel);
            this.panel1.Controls.Add(this.jurosTextBox);
            this.panel1.Controls.Add(total_parcelasLabel);
            this.panel1.Controls.Add(this.total_parcelasTextBox);
            this.panel1.Controls.Add(valor_parcelaLabel);
            this.panel1.Controls.Add(this.valor_parcelaTextBox);
            this.panel1.Controls.Add(situacaoLabel);
            this.panel1.Controls.Add(this.situacaoComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 593);
            this.panel1.TabIndex = 0;
            // 
            // lb_datapag
            // 
            this.lb_datapag.AutoSize = true;
            this.lb_datapag.BackColor = System.Drawing.Color.Transparent;
            this.lb_datapag.Location = new System.Drawing.Point(64, 469);
            this.lb_datapag.Name = "lb_datapag";
            this.lb_datapag.Size = new System.Drawing.Size(134, 17);
            this.lb_datapag.TabIndex = 33;
            this.lb_datapag.Text = "Data de Pagamento";
            this.lb_datapag.Visible = false;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_PagarBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(206, 96);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(69, 23);
            this.idTextBox.TabIndex = 32;
            this.idTextBox.Visible = false;
            // 
            // contas_PagarBindingSource
            // 
            this.contas_PagarBindingSource.DataMember = "Contas_Pagar";
            this.contas_PagarBindingSource.DataSource = this.contas_DBDataSet;
            // 
            // contas_DBDataSet
            // 
            this.contas_DBDataSet.DataSetName = "Contas_DBDataSet";
            this.contas_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bt_novo
            // 
            this.bt_novo.Location = new System.Drawing.Point(441, 527);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(80, 30);
            this.bt_novo.TabIndex = 31;
            this.bt_novo.Text = "Novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(576, 527);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(80, 30);
            this.bt_salvar.TabIndex = 30;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(495, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(636, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(205, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(205, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "R$";
            // 
            // credorTextBox
            // 
            this.credorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_PagarBindingSource, "credor", true));
            this.credorTextBox.Location = new System.Drawing.Point(206, 126);
            this.credorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.credorTextBox.Name = "credorTextBox";
            this.credorTextBox.Size = new System.Drawing.Size(450, 23);
            this.credorTextBox.TabIndex = 3;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_PagarBindingSource, "descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(206, 355);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(450, 68);
            this.descricaoTextBox.TabIndex = 5;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_PagarBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(236, 157);
            this.valorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 23);
            this.valorTextBox.TabIndex = 7;
            // 
            // data_emissaoDateTimePicker
            // 
            this.data_emissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contas_PagarBindingSource, "data_emissao", true));
            this.data_emissaoDateTimePicker.Location = new System.Drawing.Point(206, 228);
            this.data_emissaoDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.data_emissaoDateTimePicker.Name = "data_emissaoDateTimePicker";
            this.data_emissaoDateTimePicker.Size = new System.Drawing.Size(282, 23);
            this.data_emissaoDateTimePicker.TabIndex = 9;
            // 
            // data_vencimentoDateTimePicker
            // 
            this.data_vencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contas_PagarBindingSource, "data_vencimento", true));
            this.data_vencimentoDateTimePicker.Location = new System.Drawing.Point(206, 262);
            this.data_vencimentoDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.data_vencimentoDateTimePicker.Name = "data_vencimentoDateTimePicker";
            this.data_vencimentoDateTimePicker.Size = new System.Drawing.Size(282, 23);
            this.data_vencimentoDateTimePicker.TabIndex = 11;
            // 
            // data_pagamentoDateTimePicker
            // 
            this.data_pagamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contas_PagarBindingSource, "data_pagamento", true));
            this.data_pagamentoDateTimePicker.Location = new System.Drawing.Point(206, 464);
            this.data_pagamentoDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.data_pagamentoDateTimePicker.Name = "data_pagamentoDateTimePicker";
            this.data_pagamentoDateTimePicker.Size = new System.Drawing.Size(282, 23);
            this.data_pagamentoDateTimePicker.TabIndex = 13;
            this.data_pagamentoDateTimePicker.Visible = false;
            // 
            // forma_pagamentoComboBox
            // 
            this.forma_pagamentoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.forma_pagamentoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.forma_pagamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_PagarBindingSource, "forma_pagamento", true));
            this.forma_pagamentoComboBox.FormattingEnabled = true;
            this.forma_pagamentoComboBox.Items.AddRange(new object[] {
            "CARTAO DE CREDITO",
            "CARTAO DE DEBITO",
            "CHEQUE",
            "DEPOSITO EM CONTA ",
            "DINHEIRO",
            "DUPLICATA",
            "TRANSFERENCIA"});
            this.forma_pagamentoComboBox.Location = new System.Drawing.Point(206, 188);
            this.forma_pagamentoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.forma_pagamentoComboBox.Name = "forma_pagamentoComboBox";
            this.forma_pagamentoComboBox.Size = new System.Drawing.Size(265, 25);
            this.forma_pagamentoComboBox.TabIndex = 15;
            // 
            // multaTextBox
            // 
            this.multaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_PagarBindingSource, "multa", true));
            this.multaTextBox.Location = new System.Drawing.Point(236, 293);
            this.multaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.multaTextBox.Name = "multaTextBox";
            this.multaTextBox.Size = new System.Drawing.Size(100, 23);
            this.multaTextBox.TabIndex = 17;
            // 
            // jurosTextBox
            // 
            this.jurosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_PagarBindingSource, "juros", true));
            this.jurosTextBox.Location = new System.Drawing.Point(529, 293);
            this.jurosTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.jurosTextBox.Name = "jurosTextBox";
            this.jurosTextBox.Size = new System.Drawing.Size(100, 23);
            this.jurosTextBox.TabIndex = 19;
            // 
            // total_parcelasTextBox
            // 
            this.total_parcelasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_PagarBindingSource, "total_parcelas", true));
            this.total_parcelasTextBox.Location = new System.Drawing.Point(208, 324);
            this.total_parcelasTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.total_parcelasTextBox.Name = "total_parcelasTextBox";
            this.total_parcelasTextBox.Size = new System.Drawing.Size(80, 23);
            this.total_parcelasTextBox.TabIndex = 21;
            // 
            // valor_parcelaTextBox
            // 
            this.valor_parcelaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_PagarBindingSource, "valor_parcela", true));
            this.valor_parcelaTextBox.Location = new System.Drawing.Point(528, 324);
            this.valor_parcelaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.valor_parcelaTextBox.Name = "valor_parcelaTextBox";
            this.valor_parcelaTextBox.Size = new System.Drawing.Size(100, 23);
            this.valor_parcelaTextBox.TabIndex = 23;
            // 
            // situacaoComboBox
            // 
            this.situacaoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.situacaoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.situacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_PagarBindingSource, "situacao", true));
            this.situacaoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.situacaoComboBox.FormattingEnabled = true;
            this.situacaoComboBox.Items.AddRange(new object[] {
            "PAGO",
            "PENDENTE",
            "VENCIDO"});
            this.situacaoComboBox.Location = new System.Drawing.Point(206, 431);
            this.situacaoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.situacaoComboBox.Name = "situacaoComboBox";
            this.situacaoComboBox.Size = new System.Drawing.Size(160, 25);
            this.situacaoComboBox.TabIndex = 25;
            this.situacaoComboBox.SelectedValueChanged += new System.EventHandler(this.situacaoComboBox_SelectedValueChanged);
            // 
            // contas_PagarTableAdapter
            // 
            this.contas_PagarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Contas_PagarTableAdapter = this.contas_PagarTableAdapter;
            this.tableAdapterManager.Contas_ReceberTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.Projecoes_PagarTableAdapter = null;
            this.tableAdapterManager.Projecoes_ReceberTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // frm_cadastrarDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 593);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_cadastrarDebito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_cadastrarDebito_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contas_PagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Contas_DBDataSet contas_DBDataSet;
        private System.Windows.Forms.BindingSource contas_PagarBindingSource;
        private Contas_DBDataSetTableAdapters.Contas_PagarTableAdapter contas_PagarTableAdapter;
        private Contas_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox credorTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.DateTimePicker data_emissaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_vencimentoDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_pagamentoDateTimePicker;
        private System.Windows.Forms.ComboBox forma_pagamentoComboBox;
        private System.Windows.Forms.TextBox multaTextBox;
        private System.Windows.Forms.TextBox jurosTextBox;
        private System.Windows.Forms.TextBox total_parcelasTextBox;
        private System.Windows.Forms.TextBox valor_parcelaTextBox;
        private System.Windows.Forms.ComboBox situacaoComboBox;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label lb_datapag;
    }
}