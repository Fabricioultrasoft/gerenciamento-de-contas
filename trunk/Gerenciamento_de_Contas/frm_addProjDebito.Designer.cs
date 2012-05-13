namespace Gerenciamento_de_Contas
{
    partial class frm_addProjDebito
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.contas_DBDataSet = new Gerenciamento_de_Contas.Contas_DBDataSet();
            this.projecoes_PagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projecoes_PagarTableAdapter = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.Projecoes_PagarTableAdapter();
            this.tableAdapterManager = new Gerenciamento_de_Contas.Contas_DBDataSetTableAdapters.TableAdapterManager();
            this.mesComboBox = new System.Windows.Forms.ComboBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            mesLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_PagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(mesLabel);
            this.panel1.Controls.Add(this.mesComboBox);
            this.panel1.Controls.Add(valorLabel);
            this.panel1.Controls.Add(this.valorTextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 343);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salvar Projeção";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // mesLabel
            // 
            mesLabel.AutoSize = true;
            mesLabel.Location = new System.Drawing.Point(46, 114);
            mesLabel.Name = "mesLabel";
            mesLabel.Size = new System.Drawing.Size(34, 17);
            mesLabel.TabIndex = 1;
            mesLabel.Text = "Mês";
            // 
            // mesComboBox
            // 
            this.mesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projecoes_PagarBindingSource, "mes", true));
            this.mesComboBox.FormattingEnabled = true;
            this.mesComboBox.Location = new System.Drawing.Point(95, 111);
            this.mesComboBox.Name = "mesComboBox";
            this.mesComboBox.Size = new System.Drawing.Size(121, 25);
            this.mesComboBox.TabIndex = 2;
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(46, 145);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(41, 17);
            valorLabel.TabIndex = 3;
            valorLabel.Text = "Valor";
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projecoes_PagarBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(95, 142);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(121, 23);
            this.valorTextBox.TabIndex = 4;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.projecoes_PagarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gerenciamento_de_Contas.GraficoProjPagar.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(259, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(350, 226);
            this.reportViewer1.TabIndex = 5;
            // 
            // frm_addProjDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 343);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_addProjDebito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_addProjDebito";
            this.Load += new System.EventHandler(this.frm_addProjDebito_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contas_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecoes_PagarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private Contas_DBDataSet contas_DBDataSet;
        private System.Windows.Forms.BindingSource projecoes_PagarBindingSource;
        private Contas_DBDataSetTableAdapters.Projecoes_PagarTableAdapter projecoes_PagarTableAdapter;
        private Contas_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox mesComboBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}