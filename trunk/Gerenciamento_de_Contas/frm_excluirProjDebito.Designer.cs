namespace Gerenciamento_de_Contas
{
    partial class frm_excluirProjDebito
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contas_DBDataSet = new Gerenciamento_de_Contas.Contas_DBDataSet();
            this.projecoes_PagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projecoes_PagarTableAdapter = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.Projecoes_PagarTableAdapter();
            this.tableAdapterManager = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.TableAdapterManager();
            this.projecoes_PagarDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_PagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_PagarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.bt_excluir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.projecoes_PagarDataGridView);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 472);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 366);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 23);
            this.textBox1.TabIndex = 1;
            // 
            // contas_DBDataSet
            // 
            this.contas_DBDataSet.DataSetName = "Contas_DBDataSet";
            this.contas_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projecoes_PagarBindingSource
            // 
            this.projecoes_PagarBindingSource.DataMember = "Projecoes_Pagar";
            this.projecoes_PagarBindingSource.DataSource = this.contas_DBDataSet;
            // 
            // projecoes_PagarTableAdapter
            // 
            this.projecoes_PagarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Contas_PagarTableAdapter = null;
            this.tableAdapterManager.Contas_ReceberTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.Projecoes_PagarTableAdapter = this.projecoes_PagarTableAdapter;
            this.tableAdapterManager.Projecoes_ReceberTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // projecoes_PagarDataGridView
            // 
            this.projecoes_PagarDataGridView.AutoGenerateColumns = false;
            this.projecoes_PagarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projecoes_PagarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.projecoes_PagarDataGridView.DataSource = this.projecoes_PagarBindingSource;
            this.projecoes_PagarDataGridView.Location = new System.Drawing.Point(44, 119);
            this.projecoes_PagarDataGridView.Name = "projecoes_PagarDataGridView";
            this.projecoes_PagarDataGridView.Size = new System.Drawing.Size(234, 220);
            this.projecoes_PagarDataGridView.TabIndex = 1;
            this.projecoes_PagarDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projecoes_PagarDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mês";
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
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(118, 411);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 30);
            this.bt_excluir.TabIndex = 3;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.projecoes_PagarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gerenciamento_de_Contas.GraficoProjPagar.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(351, 113);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(350, 226);
            this.reportViewer1.TabIndex = 4;
            // 
            // frm_excluirProjDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 472);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_excluirProjDebito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_excluirProjDebito";
            this.Load += new System.EventHandler(this.frm_excluirProjDebito_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_PagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_PagarDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private Contas_DBDataSet contas_DBDataSet;
        private System.Windows.Forms.BindingSource projecoes_PagarBindingSource;
        private Contas_DBDataSetTableAdapters.Projecoes_PagarTableAdapter projecoes_PagarTableAdapter;
        private Contas_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView projecoes_PagarDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}