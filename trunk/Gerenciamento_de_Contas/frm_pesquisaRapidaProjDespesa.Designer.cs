namespace Gerenciamento_de_Contas
{
    partial class frm_pesquisaRapidaProjDespesa
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
            this.contas_DBDataSet = new Gerenciamento_de_Contas.Contas_DBDataSet();
            this.projecoes_PagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projecoes_PagarTableAdapter = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.Projecoes_PagarTableAdapter();
            this.tableAdapterManager = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.TableAdapterManager();
            this.projecoes_PagarDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_PagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_PagarDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.projecoes_PagarDataGridView.Location = new System.Drawing.Point(188, 110);
            this.projecoes_PagarDataGridView.Name = "projecoes_PagarDataGridView";
            this.projecoes_PagarDataGridView.Size = new System.Drawing.Size(300, 220);
            this.projecoes_PagarDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "mes";
            this.dataGridViewTextBoxColumn1.HeaderText = "mes";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn2.HeaderText = "valor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // frm_pesquisaRapidaProjDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 350);
            this.Controls.Add(this.projecoes_PagarDataGridView);
            this.Name = "frm_pesquisaRapidaProjDespesa";
            this.Text = "frm_pesquisaRapidaProjDespesa";
            this.Load += new System.EventHandler(this.frm_pesquisaRapidaProjDespesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_PagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_PagarDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Contas_DBDataSet contas_DBDataSet;
        private System.Windows.Forms.BindingSource projecoes_PagarBindingSource;
        private Contas_DBDataSetTableAdapters.Projecoes_PagarTableAdapter projecoes_PagarTableAdapter;
        private Contas_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView projecoes_PagarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}