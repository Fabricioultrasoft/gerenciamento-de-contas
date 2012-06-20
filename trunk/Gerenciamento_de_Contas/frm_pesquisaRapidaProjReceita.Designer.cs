namespace Gerenciamento_de_Contas
{
    partial class frm_pesquisaRapidaProjReceita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pesquisaRapidaProjReceita));
            this.projecoes_ReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contas_DBDataSet = new Gerenciamento_de_Contas.Contas_DBDataSet();
            this.projecoes_ReceberTableAdapter = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.Projecoes_ReceberTableAdapter();
            this.tableAdapterManager = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.TableAdapterManager();
            this.projecoes_ReceberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_ReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_ReceberDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
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
            // projecoes_ReceberDataGridView
            // 
            this.projecoes_ReceberDataGridView.AutoGenerateColumns = false;
            this.projecoes_ReceberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projecoes_ReceberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.projecoes_ReceberDataGridView.DataSource = this.projecoes_ReceberBindingSource;
            this.projecoes_ReceberDataGridView.Location = new System.Drawing.Point(42, 120);
            this.projecoes_ReceberDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.projecoes_ReceberDataGridView.Name = "projecoes_ReceberDataGridView";
            this.projecoes_ReceberDataGridView.Size = new System.Drawing.Size(283, 226);
            this.projecoes_ReceberDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "mes";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mês";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.projecoes_ReceberDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 384);
            this.panel1.TabIndex = 2;
            // 
            // frm_pesquisaRapidaProjReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 384);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_pesquisaRapidaProjReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_pesquisaRapidaProjReceita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_ReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_ReceberDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Contas_DBDataSet contas_DBDataSet;
        private System.Windows.Forms.BindingSource projecoes_ReceberBindingSource;
        private Contas_DBDataSetTableAdapters.Projecoes_ReceberTableAdapter projecoes_ReceberTableAdapter;
        private Contas_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView projecoes_ReceberDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}