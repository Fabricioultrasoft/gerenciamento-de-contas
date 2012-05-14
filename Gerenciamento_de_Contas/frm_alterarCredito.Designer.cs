namespace Gerenciamento_de_Contas
{
    partial class frm_alterarCredito
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
            this.contas_DBDataSet = new Gerenciamento_de_Contas.Contas_DBDataSet();
            this.contas_ReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contas_ReceberTableAdapter = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.Contas_ReceberTableAdapter();
            this.tableAdapterManager = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_ReceberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contas_DBDataSet
            // 
            this.contas_DBDataSet.DataSetName = "Contas_DBDataSet";
            this.contas_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contas_ReceberBindingSource
            // 
            this.contas_ReceberBindingSource.DataMember = "Contas_Receber";
            this.contas_ReceberBindingSource.DataSource = this.contas_DBDataSet;
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
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(89, 115);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(220, 111);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(265, 23);
            this.idTextBox.TabIndex = 2;
            // 
            // devedorLabel
            // 
            devedorLabel.AutoSize = true;
            devedorLabel.Location = new System.Drawing.Point(89, 149);
            devedorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            devedorLabel.Name = "devedorLabel";
            devedorLabel.Size = new System.Drawing.Size(64, 17);
            devedorLabel.TabIndex = 3;
            devedorLabel.Text = "devedor:";
            // 
            // devedorTextBox
            // 
            this.devedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "devedor", true));
            this.devedorTextBox.Location = new System.Drawing.Point(220, 145);
            this.devedorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.devedorTextBox.Name = "devedorTextBox";
            this.devedorTextBox.Size = new System.Drawing.Size(265, 23);
            this.devedorTextBox.TabIndex = 4;
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(89, 183);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(73, 17);
            descricaoLabel.TabIndex = 5;
            descricaoLabel.Text = "descricao:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(220, 179);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(265, 23);
            this.descricaoTextBox.TabIndex = 6;
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(89, 217);
            valorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(43, 17);
            valorLabel.TabIndex = 7;
            valorLabel.Text = "valor:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(220, 213);
            this.valorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(265, 23);
            this.valorTextBox.TabIndex = 8;
            // 
            // data_emissaoLabel
            // 
            data_emissaoLabel.AutoSize = true;
            data_emissaoLabel.Location = new System.Drawing.Point(89, 252);
            data_emissaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_emissaoLabel.Name = "data_emissaoLabel";
            data_emissaoLabel.Size = new System.Drawing.Size(96, 17);
            data_emissaoLabel.TabIndex = 9;
            data_emissaoLabel.Text = "data emissao:";
            // 
            // data_emissaoDateTimePicker
            // 
            this.data_emissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contas_ReceberBindingSource, "data_emissao", true));
            this.data_emissaoDateTimePicker.Location = new System.Drawing.Point(220, 247);
            this.data_emissaoDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.data_emissaoDateTimePicker.Name = "data_emissaoDateTimePicker";
            this.data_emissaoDateTimePicker.Size = new System.Drawing.Size(265, 23);
            this.data_emissaoDateTimePicker.TabIndex = 10;
            // 
            // data_vencimentoLabel
            // 
            data_vencimentoLabel.AutoSize = true;
            data_vencimentoLabel.Location = new System.Drawing.Point(89, 286);
            data_vencimentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_vencimentoLabel.Name = "data_vencimentoLabel";
            data_vencimentoLabel.Size = new System.Drawing.Size(116, 17);
            data_vencimentoLabel.TabIndex = 11;
            data_vencimentoLabel.Text = "data vencimento:";
            // 
            // data_vencimentoDateTimePicker
            // 
            this.data_vencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contas_ReceberBindingSource, "data_vencimento", true));
            this.data_vencimentoDateTimePicker.Location = new System.Drawing.Point(220, 281);
            this.data_vencimentoDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.data_vencimentoDateTimePicker.Name = "data_vencimentoDateTimePicker";
            this.data_vencimentoDateTimePicker.Size = new System.Drawing.Size(265, 23);
            this.data_vencimentoDateTimePicker.TabIndex = 12;
            // 
            // data_pagamentoLabel
            // 
            data_pagamentoLabel.AutoSize = true;
            data_pagamentoLabel.Location = new System.Drawing.Point(89, 320);
            data_pagamentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_pagamentoLabel.Name = "data_pagamentoLabel";
            data_pagamentoLabel.Size = new System.Drawing.Size(115, 17);
            data_pagamentoLabel.TabIndex = 13;
            data_pagamentoLabel.Text = "data pagamento:";
            // 
            // data_pagamentoDateTimePicker
            // 
            this.data_pagamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contas_ReceberBindingSource, "data_pagamento", true));
            this.data_pagamentoDateTimePicker.Location = new System.Drawing.Point(220, 315);
            this.data_pagamentoDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.data_pagamentoDateTimePicker.Name = "data_pagamentoDateTimePicker";
            this.data_pagamentoDateTimePicker.Size = new System.Drawing.Size(265, 23);
            this.data_pagamentoDateTimePicker.TabIndex = 14;
            // 
            // forma_pagamentoLabel
            // 
            forma_pagamentoLabel.AutoSize = true;
            forma_pagamentoLabel.Location = new System.Drawing.Point(89, 353);
            forma_pagamentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            forma_pagamentoLabel.Name = "forma_pagamentoLabel";
            forma_pagamentoLabel.Size = new System.Drawing.Size(123, 17);
            forma_pagamentoLabel.TabIndex = 15;
            forma_pagamentoLabel.Text = "forma pagamento:";
            // 
            // forma_pagamentoComboBox
            // 
            this.forma_pagamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "forma_pagamento", true));
            this.forma_pagamentoComboBox.FormattingEnabled = true;
            this.forma_pagamentoComboBox.Location = new System.Drawing.Point(220, 349);
            this.forma_pagamentoComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.forma_pagamentoComboBox.Name = "forma_pagamentoComboBox";
            this.forma_pagamentoComboBox.Size = new System.Drawing.Size(265, 25);
            this.forma_pagamentoComboBox.TabIndex = 16;
            // 
            // multaLabel
            // 
            multaLabel.AutoSize = true;
            multaLabel.Location = new System.Drawing.Point(89, 388);
            multaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            multaLabel.Name = "multaLabel";
            multaLabel.Size = new System.Drawing.Size(46, 17);
            multaLabel.TabIndex = 17;
            multaLabel.Text = "multa:";
            // 
            // multaTextBox
            // 
            this.multaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "multa", true));
            this.multaTextBox.Location = new System.Drawing.Point(220, 385);
            this.multaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.multaTextBox.Name = "multaTextBox";
            this.multaTextBox.Size = new System.Drawing.Size(265, 23);
            this.multaTextBox.TabIndex = 18;
            // 
            // jurosLabel
            // 
            jurosLabel.AutoSize = true;
            jurosLabel.Location = new System.Drawing.Point(89, 422);
            jurosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            jurosLabel.Name = "jurosLabel";
            jurosLabel.Size = new System.Drawing.Size(43, 17);
            jurosLabel.TabIndex = 19;
            jurosLabel.Text = "juros:";
            // 
            // jurosTextBox
            // 
            this.jurosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "juros", true));
            this.jurosTextBox.Location = new System.Drawing.Point(220, 419);
            this.jurosTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jurosTextBox.Name = "jurosTextBox";
            this.jurosTextBox.Size = new System.Drawing.Size(265, 23);
            this.jurosTextBox.TabIndex = 20;
            // 
            // total_parcelasLabel
            // 
            total_parcelasLabel.AutoSize = true;
            total_parcelasLabel.Location = new System.Drawing.Point(89, 456);
            total_parcelasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            total_parcelasLabel.Name = "total_parcelasLabel";
            total_parcelasLabel.Size = new System.Drawing.Size(97, 17);
            total_parcelasLabel.TabIndex = 21;
            total_parcelasLabel.Text = "total parcelas:";
            // 
            // total_parcelasTextBox
            // 
            this.total_parcelasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "total_parcelas", true));
            this.total_parcelasTextBox.Location = new System.Drawing.Point(220, 453);
            this.total_parcelasTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.total_parcelasTextBox.Name = "total_parcelasTextBox";
            this.total_parcelasTextBox.Size = new System.Drawing.Size(265, 23);
            this.total_parcelasTextBox.TabIndex = 22;
            // 
            // valor_parcelaLabel
            // 
            valor_parcelaLabel.AutoSize = true;
            valor_parcelaLabel.Location = new System.Drawing.Point(89, 490);
            valor_parcelaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valor_parcelaLabel.Name = "valor_parcelaLabel";
            valor_parcelaLabel.Size = new System.Drawing.Size(94, 17);
            valor_parcelaLabel.TabIndex = 23;
            valor_parcelaLabel.Text = "valor parcela:";
            // 
            // valor_parcelaTextBox
            // 
            this.valor_parcelaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "valor_parcela", true));
            this.valor_parcelaTextBox.Location = new System.Drawing.Point(220, 487);
            this.valor_parcelaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valor_parcelaTextBox.Name = "valor_parcelaTextBox";
            this.valor_parcelaTextBox.Size = new System.Drawing.Size(265, 23);
            this.valor_parcelaTextBox.TabIndex = 24;
            // 
            // situacaoLabel
            // 
            situacaoLabel.AutoSize = true;
            situacaoLabel.Location = new System.Drawing.Point(89, 524);
            situacaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            situacaoLabel.Name = "situacaoLabel";
            situacaoLabel.Size = new System.Drawing.Size(65, 17);
            situacaoLabel.TabIndex = 25;
            situacaoLabel.Text = "situacao:";
            // 
            // situacaoComboBox
            // 
            this.situacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_ReceberBindingSource, "situacao", true));
            this.situacaoComboBox.FormattingEnabled = true;
            this.situacaoComboBox.Location = new System.Drawing.Point(220, 521);
            this.situacaoComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.situacaoComboBox.Name = "situacaoComboBox";
            this.situacaoComboBox.Size = new System.Drawing.Size(265, 25);
            this.situacaoComboBox.TabIndex = 26;
            // 
            // frm_alterarCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 712);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(devedorLabel);
            this.Controls.Add(this.devedorTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(data_emissaoLabel);
            this.Controls.Add(this.data_emissaoDateTimePicker);
            this.Controls.Add(data_vencimentoLabel);
            this.Controls.Add(this.data_vencimentoDateTimePicker);
            this.Controls.Add(data_pagamentoLabel);
            this.Controls.Add(this.data_pagamentoDateTimePicker);
            this.Controls.Add(forma_pagamentoLabel);
            this.Controls.Add(this.forma_pagamentoComboBox);
            this.Controls.Add(multaLabel);
            this.Controls.Add(this.multaTextBox);
            this.Controls.Add(jurosLabel);
            this.Controls.Add(this.jurosTextBox);
            this.Controls.Add(total_parcelasLabel);
            this.Controls.Add(this.total_parcelasTextBox);
            this.Controls.Add(valor_parcelaLabel);
            this.Controls.Add(this.valor_parcelaTextBox);
            this.Controls.Add(situacaoLabel);
            this.Controls.Add(this.situacaoComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_alterarCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_alterarCredito";
            this.Load += new System.EventHandler(this.frm_alterarCredito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_ReceberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}