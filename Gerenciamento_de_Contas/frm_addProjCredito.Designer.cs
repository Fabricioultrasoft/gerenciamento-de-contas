namespace Gerenciamento_de_Contas
{
    partial class frm_addProjCredito
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
            System.Windows.Forms.Label mesLabel;
            System.Windows.Forms.Label valorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addProjCredito));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.projecoes_ReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contas_DBDataSet = new Gerenciamento_de_Contas.Contas_DBDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.mesComboBox = new System.Windows.Forms.ComboBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.projecoes_ReceberTableAdapter = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.Projecoes_ReceberTableAdapter();
            this.tableAdapterManager = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.TableAdapterManager();
            mesLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_ReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mesLabel
            // 
            mesLabel.AutoSize = true;
            mesLabel.BackColor = System.Drawing.Color.Transparent;
            mesLabel.Location = new System.Drawing.Point(36, 167);
            mesLabel.Name = "mesLabel";
            mesLabel.Size = new System.Drawing.Size(34, 17);
            mesLabel.TabIndex = 0;
            mesLabel.Text = "Mês";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.BackColor = System.Drawing.Color.Transparent;
            valorLabel.Location = new System.Drawing.Point(36, 198);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(41, 17);
            valorLabel.TabIndex = 2;
            valorLabel.Text = "Valor";
            // 
            // projecoes_ReceberBindingSource
            // 
            this.projecoes_ReceberBindingSource.DataMember = "Projecoes_Receber";
            this.projecoes_ReceberBindingSource.DataSource = this.contas_DBDataSet;
            // 
            // contas_DBDataSet
            // 
            this.contas_DBDataSet.DataSetName = "Contas_DBDataSet";
            this.contas_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 396);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(mesLabel);
            this.panel2.Controls.Add(this.mesComboBox);
            this.panel2.Controls.Add(valorLabel);
            this.panel2.Controls.Add(this.valorTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 396);
            this.panel2.TabIndex = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.projecoes_ReceberBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gerenciamento_de_Contas.GraficoProjReceber.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(266, 123);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(350, 226);
            this.reportViewer1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salvar Projeção";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mesComboBox
            // 
            this.mesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.mesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projecoes_ReceberBindingSource, "mes", true));
            this.mesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mesComboBox.FormattingEnabled = true;
            this.mesComboBox.Items.AddRange(new object[] {
            "JANEIRO",
            "FEVEREIRO",
            "MARÇO",
            "ABRIL",
            "MAIO",
            "JUNHO",
            "JULHO",
            "AGOSTO",
            "SETEMBRO",
            "OUTUBRO",
            "NOVEMBRO",
            "DEZEMBRO"});
            this.mesComboBox.Location = new System.Drawing.Point(83, 164);
            this.mesComboBox.Name = "mesComboBox";
            this.mesComboBox.Size = new System.Drawing.Size(132, 25);
            this.mesComboBox.TabIndex = 1;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projecoes_ReceberBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(83, 195);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(97, 23);
            this.valorTextBox.TabIndex = 3;
            // 
            // projecoes_ReceberTableAdapter
            // 
            this.projecoes_ReceberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Contas_PagarTableAdapter = null;
            this.tableAdapterManager.Contas_ReceberTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.Projecoes_PagarTableAdapter = null;
            this.tableAdapterManager.Projecoes_ReceberTableAdapter = this.projecoes_ReceberTableAdapter;
            this.tableAdapterManager.UpdateOrder = Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // frm_addProjCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 396);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_addProjCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_addProjCredito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_ReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Contas_DBDataSet contas_DBDataSet;
        private System.Windows.Forms.BindingSource projecoes_ReceberBindingSource;
        private Contas_DBDataSetTableAdapters.Projecoes_ReceberTableAdapter projecoes_ReceberTableAdapter;
        private Contas_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox mesComboBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}