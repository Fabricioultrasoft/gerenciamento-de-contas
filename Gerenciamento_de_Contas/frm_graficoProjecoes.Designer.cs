namespace Gerenciamento_de_Contas
{
    partial class frm_graficoProjecoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_graficoProjecoes));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Projecoes_ReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Contas_DBDataSet = new Gerenciamento_de_Contas.Contas_DBDataSet();
            this.Projecoes_PagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Projecoes_PagarTableAdapter = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.Projecoes_PagarTableAdapter();
            this.Projecoes_ReceberTableAdapter = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.Projecoes_ReceberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Projecoes_ReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contas_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Projecoes_PagarBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Projecoes_ReceberBindingSource
            // 
            this.Projecoes_ReceberBindingSource.DataMember = "Projecoes_Receber";
            this.Projecoes_ReceberBindingSource.DataSource = this.Contas_DBDataSet;
            // 
            // Contas_DBDataSet
            // 
            this.Contas_DBDataSet.DataSetName = "Contas_DBDataSet";
            this.Contas_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Projecoes_PagarBindingSource
            // 
            this.Projecoes_PagarBindingSource.DataMember = "Projecoes_Pagar";
            this.Projecoes_PagarBindingSource.DataSource = this.Contas_DBDataSet;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.reportViewer2);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 394);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Projecoes_ReceberBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Gerenciamento_de_Contas.GraficoProjReceber.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(498, 126);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ShowToolBar = false;
            this.reportViewer2.Size = new System.Drawing.Size(350, 226);
            this.reportViewer2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Projecoes_PagarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gerenciamento_de_Contas.GraficoProjPagar.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(44, 126);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(350, 226);
            this.reportViewer1.TabIndex = 0;
            // 
            // Projecoes_PagarTableAdapter
            // 
            this.Projecoes_PagarTableAdapter.ClearBeforeFill = true;
            // 
            // Projecoes_ReceberTableAdapter
            // 
            this.Projecoes_ReceberTableAdapter.ClearBeforeFill = true;
            // 
            // frm_graficoProjecoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 394);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_graficoProjecoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_graficoProjecoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Projecoes_ReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contas_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Projecoes_PagarBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource Projecoes_PagarBindingSource;
        private Contas_DBDataSet Contas_DBDataSet;
        private Contas_DBDataSetTableAdapters.Projecoes_PagarTableAdapter Projecoes_PagarTableAdapter;
        private System.Windows.Forms.BindingSource Projecoes_ReceberBindingSource;
        private Contas_DBDataSetTableAdapters.Projecoes_ReceberTableAdapter Projecoes_ReceberTableAdapter;
    }
}