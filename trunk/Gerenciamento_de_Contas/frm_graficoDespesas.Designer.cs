namespace Gerenciamento_de_Contas
{
    partial class frm_graficoDespesas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Contas_PagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Contas_DBDataSet = new Gerenciamento_de_Contas.Contas_DBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Contas_PagarTableAdapter = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.Contas_PagarTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Contas_PagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contas_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Contas_PagarBindingSource
            // 
            this.Contas_PagarBindingSource.DataMember = "Contas_Pagar";
            this.Contas_PagarBindingSource.DataSource = this.Contas_DBDataSet;
            // 
            // Contas_DBDataSet
            // 
            this.Contas_DBDataSet.DataSetName = "Contas_DBDataSet";
            this.Contas_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Contas_PagarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gerenciamento_de_Contas.GraficoDespesasBySituacao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(50, 137);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(350, 226);
            this.reportViewer1.TabIndex = 0;
            // 
            // Contas_PagarTableAdapter
            // 
            this.Contas_PagarTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Contas_PagarBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Gerenciamento_de_Contas.GraficoDespesasByMes.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(509, 91);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ShowToolBar = false;
            this.reportViewer2.Size = new System.Drawing.Size(419, 271);
            this.reportViewer2.TabIndex = 1;
            // 
            // frm_graficoDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_graficoDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_graficoDespesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Contas_PagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contas_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Contas_DBDataSet Contas_DBDataSet;
        private System.Windows.Forms.BindingSource Contas_PagarBindingSource;
        private Contas_DBDataSetTableAdapters.Contas_PagarTableAdapter Contas_PagarTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}