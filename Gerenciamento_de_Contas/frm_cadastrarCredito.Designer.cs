namespace Gerenciamento_de_Contas
{
    partial class frm_cadastrarCredito
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label devedorLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label data_emissaoLabel;
            System.Windows.Forms.Label data_vencimentoLabel;
            System.Windows.Forms.Label data_pagamentoLabel;
            System.Windows.Forms.Label forma_pagamentoLabel;
            System.Windows.Forms.Label multaLabel;
            System.Windows.Forms.Label jurosLabel;
            System.Windows.Forms.Label total_parcelasLabel;
            System.Windows.Forms.Label valor_parcelaLabel;
            System.Windows.Forms.Label situacaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastrarCredito));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.contas_ReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contas_DBDataSet = new Gerenciamento_de_Contas.Contas_DBDataSet();
            this.devedorTextBox = new System.Windows.Forms.TextBox();
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
            this.contas_ReceberTableAdapter = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.Contas_ReceberTableAdapter();
            this.tableAdapterManager = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.TableAdapterManager();
            idLabel = new System.Windows.Forms.Label();
            devedorLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            data_emissaoLabel = new System.Windows.Forms.Label();
            data_vencimentoLabel = new System.Windows.Forms.Label();
            data_pagamentoLabel = new System.Windows.Forms.Label();
            forma_pagamentoLabel = new System.Windows.Forms.Label();
            multaLabel = new System.Windows.Forms.Label();
            jurosLabel = new System.Windows.Forms.Label();
            total_parcelasLabel = new System.Windows.Forms.Label();
            valor_parcelaLabel = new System.Windows.Forms.Label();
            situacaoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contas_ReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.Color.Transparent;
            idLabel.Location = new System.Drawing.Point(177, 103);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 17);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID";
            idLabel.Visible = false;
            // 
            // devedorLabel
            // 
            devedorLabel.AutoSize = true;
            devedorLabel.BackColor = System.Drawing.Color.Transparent;
            devedorLabel.Location = new System.Drawing.Point(123, 132);
            devedorLabel.Name = "devedorLabel";
            devedorLabel.Size = new System.Drawing.Size(75, 17);
            devedorLabel.TabIndex = 2;
            devedorLabel.Text = "Devedor  *";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.BackColor = System.Drawing.Color.Transparent;
            descricaoLabel.Location = new System.Drawing.Point(127, 366);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(71, 17);
            descricaoLabel.TabIndex = 4;
            descricaoLabel.Text = "Descrição";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.BackColor = System.Drawing.Color.Transparent;
            valorLabel.Location = new System.Drawing.Point(141, 161);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(54, 17);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "Valor  *";
            // 
            // data_emissaoLabel
            // 
            data_emissaoLabel.AutoSize = true;
            data_emissaoLabel.BackColor = System.Drawing.Color.Transparent;
            data_emissaoLabel.Location = new System.Drawing.Point(80, 223);
            data_emissaoLabel.Name = "data_emissaoLabel";
            data_emissaoLabel.Size = new System.Drawing.Size(115, 17);
            data_emissaoLabel.TabIndex = 8;
            data_emissaoLabel.Text = "Data de Emissão";
            // 
            // data_vencimentoLabel
            // 
            data_vencimentoLabel.AutoSize = true;
            data_vencimentoLabel.BackColor = System.Drawing.Color.Transparent;
            data_vencimentoLabel.Location = new System.Drawing.Point(59, 252);
            data_vencimentoLabel.Name = "data_vencimentoLabel";
            data_vencimentoLabel.Size = new System.Drawing.Size(136, 17);
            data_vencimentoLabel.TabIndex = 10;
            data_vencimentoLabel.Text = "Data de Vencimento";
            // 
            // data_pagamentoLabel
            // 
            data_pagamentoLabel.AutoSize = true;
            data_pagamentoLabel.BackColor = System.Drawing.Color.Transparent;
            data_pagamentoLabel.Location = new System.Drawing.Point(61, 281);
            data_pagamentoLabel.Name = "data_pagamentoLabel";
            data_pagamentoLabel.Size = new System.Drawing.Size(134, 17);
            data_pagamentoLabel.TabIndex = 12;
            data_pagamentoLabel.Text = "Data de Pagamento";
            // 
            // forma_pagamentoLabel
            // 
            forma_pagamentoLabel.AutoSize = true;
            forma_pagamentoLabel.BackColor = System.Drawing.Color.Transparent;
            forma_pagamentoLabel.Location = new System.Drawing.Point(38, 190);
            forma_pagamentoLabel.Name = "forma_pagamentoLabel";
            forma_pagamentoLabel.Size = new System.Drawing.Size(157, 17);
            forma_pagamentoLabel.TabIndex = 14;
            forma_pagamentoLabel.Text = "Forma de Pagamento  *";
            // 
            // multaLabel
            // 
            multaLabel.AutoSize = true;
            multaLabel.BackColor = System.Drawing.Color.Transparent;
            multaLabel.Location = new System.Drawing.Point(153, 308);
            multaLabel.Name = "multaLabel";
            multaLabel.Size = new System.Drawing.Size(42, 17);
            multaLabel.TabIndex = 16;
            multaLabel.Text = "Multa";
            // 
            // jurosLabel
            // 
            jurosLabel.AutoSize = true;
            jurosLabel.BackColor = System.Drawing.Color.Transparent;
            jurosLabel.Location = new System.Drawing.Point(476, 308);
            jurosLabel.Name = "jurosLabel";
            jurosLabel.Size = new System.Drawing.Size(43, 17);
            jurosLabel.TabIndex = 18;
            jurosLabel.Text = "Juros";
            // 
            // total_parcelasLabel
            // 
            total_parcelasLabel.AutoSize = true;
            total_parcelasLabel.BackColor = System.Drawing.Color.Transparent;
            total_parcelasLabel.Location = new System.Drawing.Point(79, 337);
            total_parcelasLabel.Name = "total_parcelasLabel";
            total_parcelasLabel.Size = new System.Drawing.Size(119, 17);
            total_parcelasLabel.TabIndex = 20;
            total_parcelasLabel.Text = "Total de Parcelas";
            // 
            // valor_parcelaLabel
            // 
            valor_parcelaLabel.AutoSize = true;
            valor_parcelaLabel.BackColor = System.Drawing.Color.Transparent;
            valor_parcelaLabel.Location = new System.Drawing.Point(377, 337);
            valor_parcelaLabel.Name = "valor_parcelaLabel";
            valor_parcelaLabel.Size = new System.Drawing.Size(113, 17);
            valor_parcelaLabel.TabIndex = 22;
            valor_parcelaLabel.Text = "Valor da Parcela";
            // 
            // situacaoLabel
            // 
            situacaoLabel.AutoSize = true;
            situacaoLabel.BackColor = System.Drawing.Color.Transparent;
            situacaoLabel.Location = new System.Drawing.Point(134, 440);
            situacaoLabel.Name = "situacaoLabel";
            situacaoLabel.Size = new System.Drawing.Size(61, 17);
            situacaoLabel.TabIndex = 24;
            situacaoLabel.Text = "Status  *";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bt_novo);
            this.panel1.Controls.Add(this.bt_salvar);
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(devedorLabel);
            this.panel1.Controls.Add(this.devedorTextBox);
            this.panel1.Controls.Add(descricaoLabel);
            this.panel1.Controls.Add(this.descricaoTextBox);
            this.panel1.Controls.Add(valorLabel);
            this.panel1.Controls.Add(this.valorTextBox);
            this.panel1.Controls.Add(data_emissaoLabel);
            this.panel1.Controls.Add(this.data_emissaoDateTimePicker);
            this.panel1.Controls.Add(data_vencimentoLabel);
            this.panel1.Controls.Add(this.data_vencimentoDateTimePicker);
            this.panel1.Controls.Add(data_pagamentoLabel);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 577);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(493, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(634, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(201, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(201, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "R$";
            // 
            // bt_novo
            // 
            this.bt_novo.Location = new System.Drawing.Point(447, 506);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(75, 30);
            this.bt_novo.TabIndex = 27;
            this.bt_novo.Text = "Novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(579, 506);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(75, 30);
            this.bt_salvar.TabIndex = 26;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(204, 100);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(69, 23);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.Visible = false;
            // 
            // contas_ReceberBindingSource
            // 
            this.contas_ReceberBindingSource.DataMember = "Contas_Receber";
            this.contas_ReceberBindingSource.DataSource = this.contas_DBDataSet;
            // 
            // contas_DBDataSet
            // 
            this.contas_DBDataSet.DataSetName = "Contas_DBDataSet";
            this.contas_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devedorTextBox
            // 
            this.devedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "devedor", true));
            this.devedorTextBox.Location = new System.Drawing.Point(204, 129);
            this.devedorTextBox.Name = "devedorTextBox";
            this.devedorTextBox.Size = new System.Drawing.Size(450, 23);
            this.devedorTextBox.TabIndex = 3;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(204, 363);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(450, 68);
            this.descricaoTextBox.TabIndex = 5;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(233, 158);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 23);
            this.valorTextBox.TabIndex = 7;
            // 
            // data_emissaoDateTimePicker
            // 
            this.data_emissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contas_ReceberBindingSource, "data_emissao", true));
            this.data_emissaoDateTimePicker.Location = new System.Drawing.Point(204, 218);
            this.data_emissaoDateTimePicker.Name = "data_emissaoDateTimePicker";
            this.data_emissaoDateTimePicker.Size = new System.Drawing.Size(282, 23);
            this.data_emissaoDateTimePicker.TabIndex = 9;
            // 
            // data_vencimentoDateTimePicker
            // 
            this.data_vencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contas_ReceberBindingSource, "data_vencimento", true));
            this.data_vencimentoDateTimePicker.Location = new System.Drawing.Point(204, 247);
            this.data_vencimentoDateTimePicker.Name = "data_vencimentoDateTimePicker";
            this.data_vencimentoDateTimePicker.Size = new System.Drawing.Size(282, 23);
            this.data_vencimentoDateTimePicker.TabIndex = 11;
            // 
            // data_pagamentoDateTimePicker
            // 
            this.data_pagamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contas_ReceberBindingSource, "data_pagamento", true));
            this.data_pagamentoDateTimePicker.Location = new System.Drawing.Point(204, 276);
            this.data_pagamentoDateTimePicker.Name = "data_pagamentoDateTimePicker";
            this.data_pagamentoDateTimePicker.Size = new System.Drawing.Size(282, 23);
            this.data_pagamentoDateTimePicker.TabIndex = 13;
            // 
            // forma_pagamentoComboBox
            // 
            this.forma_pagamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "forma_pagamento", true));
            this.forma_pagamentoComboBox.FormattingEnabled = true;
            this.forma_pagamentoComboBox.Items.AddRange(new object[] {
            "CARTAO DE CREDITO",
            "CARTAO DE DEBITO",
            "CHEQUE",
            "DEPOSITO EM CONTA ",
            "DINHEIRO",
            "DUPLICATA",
            "TRANSFERENCIA"});
            this.forma_pagamentoComboBox.Location = new System.Drawing.Point(204, 187);
            this.forma_pagamentoComboBox.Name = "forma_pagamentoComboBox";
            this.forma_pagamentoComboBox.Size = new System.Drawing.Size(265, 25);
            this.forma_pagamentoComboBox.TabIndex = 15;
            // 
            // multaTextBox
            // 
            this.multaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "multa", true));
            this.multaTextBox.Location = new System.Drawing.Point(233, 304);
            this.multaTextBox.Name = "multaTextBox";
            this.multaTextBox.Size = new System.Drawing.Size(100, 23);
            this.multaTextBox.TabIndex = 17;
            // 
            // jurosTextBox
            // 
            this.jurosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "juros", true));
            this.jurosTextBox.Location = new System.Drawing.Point(525, 305);
            this.jurosTextBox.Name = "jurosTextBox";
            this.jurosTextBox.Size = new System.Drawing.Size(100, 23);
            this.jurosTextBox.TabIndex = 19;
            // 
            // total_parcelasTextBox
            // 
            this.total_parcelasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "total_parcelas", true));
            this.total_parcelasTextBox.Location = new System.Drawing.Point(204, 334);
            this.total_parcelasTextBox.Name = "total_parcelasTextBox";
            this.total_parcelasTextBox.Size = new System.Drawing.Size(80, 23);
            this.total_parcelasTextBox.TabIndex = 21;
            // 
            // valor_parcelaTextBox
            // 
            this.valor_parcelaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "valor_parcela", true));
            this.valor_parcelaTextBox.Location = new System.Drawing.Point(525, 334);
            this.valor_parcelaTextBox.Name = "valor_parcelaTextBox";
            this.valor_parcelaTextBox.Size = new System.Drawing.Size(100, 23);
            this.valor_parcelaTextBox.TabIndex = 23;
            // 
            // situacaoComboBox
            // 
            this.situacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "situacao", true));
            this.situacaoComboBox.FormattingEnabled = true;
            this.situacaoComboBox.Items.AddRange(new object[] {
            "PAGO",
            "PENDENTE",
            "VENCIDO"});
            this.situacaoComboBox.Location = new System.Drawing.Point(204, 437);
            this.situacaoComboBox.Name = "situacaoComboBox";
            this.situacaoComboBox.Size = new System.Drawing.Size(160, 25);
            this.situacaoComboBox.TabIndex = 25;
            // 
            // contas_ReceberTableAdapter
            // 
            this.contas_ReceberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Contas_PagarTableAdapter = null;
            this.tableAdapterManager.Contas_ReceberTableAdapter = this.contas_ReceberTableAdapter;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.Projecoes_PagarTableAdapter = null;
            this.tableAdapterManager.Projecoes_ReceberTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // frm_cadastrarCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 577);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_cadastrarCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_cadastrarCredito_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contas_ReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Contas_DBDataSet contas_DBDataSet;
        private System.Windows.Forms.BindingSource contas_ReceberBindingSource;
        private Contas_DBDataSetTableAdapters.Contas_ReceberTableAdapter contas_ReceberTableAdapter;
        private Contas_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox devedorTextBox;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Button bt_salvar;
    }
}