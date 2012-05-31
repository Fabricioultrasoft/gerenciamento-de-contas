namespace Gerenciamento_de_Contas
{
    partial class frm_receitasVencidas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Contas_DBDataSet = new Gerenciamento_de_Contas.Contas_DBDataSet();
            this.Contas_ReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Contas_ReceberTableAdapter = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.Contas_ReceberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Contas_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contas_ReceberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Contas_ReceberBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gerenciamento_de_Contas.RelatorioReceitasVencidas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1137, 572);
            this.reportViewer1.TabIndex = 0;
            // 
            // Contas_DBDataSet
            // 
            this.Contas_DBDataSet.DataSetName = "Contas_DBDataSet";
            this.Contas_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Contas_ReceberBindingSource
            // 
            this.Contas_ReceberBindingSource.DataMember = "Contas_Receber";
            this.Contas_ReceberBindingSource.DataSource = this.Contas_DBDataSet;
            // 
            // Contas_ReceberTableAdapter
            // 
            this.Contas_ReceberTableAdapter.ClearBeforeFill = true;
            // 
            // frm_receitasVencidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 572);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_receitasVencidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receitas Vencidas";
            this.Load += new System.EventHandler(this.frm_receitasVencidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Contas_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contas_ReceberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Contas_ReceberBindingSource;
        private Contas_DBDataSet Contas_DBDataSet;
        private Contas_DBDataSetTableAdapters.Contas_ReceberTableAdapter Contas_ReceberTableAdapter;
    }
}