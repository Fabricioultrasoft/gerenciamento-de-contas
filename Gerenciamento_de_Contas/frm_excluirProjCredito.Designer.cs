namespace Gerenciamento_de_Contas
{
    partial class frm_excluirProjCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_excluirProjCredito));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.projecoes_ReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contas_DBDataSet = new Gerenciamento_de_Contas.Contas_DBDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.projecoes_ReceberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projecoes_ReceberTableAdapter = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.Projecoes_ReceberTableAdapter();
            this.tableAdapterManager = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_ReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_ReceberDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.projecoes_ReceberDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 468);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 398);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 23);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mês";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.projecoes_ReceberBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gerenciamento_de_Contas.GraficoProjReceber.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(363, 119);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(350, 226);
            this.reportViewer1.TabIndex = 1;
            // 
            // projecoes_ReceberDataGridView
            // 
            this.projecoes_ReceberDataGridView.AutoGenerateColumns = false;
            this.projecoes_ReceberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projecoes_ReceberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.projecoes_ReceberDataGridView.DataSource = this.projecoes_ReceberBindingSource;
            this.projecoes_ReceberDataGridView.Location = new System.Drawing.Point(56, 119);
            this.projecoes_ReceberDataGridView.Name = "projecoes_ReceberDataGridView";
            this.projecoes_ReceberDataGridView.Size = new System.Drawing.Size(234, 226);
            this.projecoes_ReceberDataGridView.TabIndex = 0;
            this.projecoes_ReceberDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projecoes_ReceberDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "mes";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mês";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
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
            // frm_excluirProjCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 468);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_excluirProjCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_excluirProjCredito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_ReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_ReceberDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Contas_DBDataSet contas_DBDataSet;
        private System.Windows.Forms.BindingSource projecoes_ReceberBindingSource;
        private Contas_DBDataSetTableAdapters.Projecoes_ReceberTableAdapter projecoes_ReceberTableAdapter;
        private Contas_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView projecoes_ReceberDataGridView;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}