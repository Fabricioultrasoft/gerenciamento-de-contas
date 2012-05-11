namespace Gerenciamento_de_Contas
{
    partial class frm_despesasPendentes
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RelatorioDespesasPendentes3 = new Gerenciamento_de_Contas.RelatorioDespesasPendentes();
            this.RelatorioDespesasPendentes1 = new Gerenciamento_de_Contas.RelatorioDespesasPendentes();
            this.RelatorioDespesasPendentes2 = new Gerenciamento_de_Contas.RelatorioDespesasPendentes();
            this.contas_DBDataSet = new Gerenciamento_de_Contas.Contas_DBDataSet();
            this.contas_PagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contas_PagarTableAdapter = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.Contas_PagarTableAdapter();
            this.tableAdapterManager = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_PagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.RelatorioDespesasPendentes3;
            this.crystalReportViewer1.Size = new System.Drawing.Size(865, 488);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // contas_DBDataSet
            // 
            this.contas_DBDataSet.DataSetName = "Contas_DBDataSet";
            this.contas_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contas_PagarBindingSource
            // 
            this.contas_PagarBindingSource.DataMember = "Contas_Pagar";
            this.contas_PagarBindingSource.DataSource = this.contas_DBDataSet;
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
            // frm_despesasPendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 488);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frm_despesasPendentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesas Pendentes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_despesasPendentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_PagarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private RelatorioDespesasPendentes RelatorioDespesasPendentes1;
        private RelatorioDespesasPendentes RelatorioDespesasPendentes3;
        private RelatorioDespesasPendentes RelatorioDespesasPendentes2;
        private Contas_DBDataSet contas_DBDataSet;
        private System.Windows.Forms.BindingSource contas_PagarBindingSource;
        private Contas_DBDataSetTableAdapters.Contas_PagarTableAdapter contas_PagarTableAdapter;
        private Contas_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}