using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gerenciamento_de_Contas
{
    public partial class frm_prioridadesCobranca : Form
    {
        public frm_prioridadesCobranca()
        {
            InitializeComponent();
        }

        private void contas_ReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contas_ReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contas_DBDataSet);

        }

        private void frm_prioridadesCobranca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contas_DBDataSet.Contas_Receber' table. You can move, or remove it, as needed.
            this.contas_ReceberTableAdapter.Fill(this.contas_DBDataSet.Contas_Receber);
            SelecionarPorStatus();
            Ordenar();
        }

        public void SelecionarPorStatus()
        {
            try
            {
                this.contas_ReceberBindingSource.Filter = "situacao <> 'PAGO'";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao filtrar os registros! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Ordenar()
        {
            try
            {
                this.contas_ReceberTableAdapter.FillByPrioridadesCobranca(contas_DBDataSet.Contas_Receber);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao filtrar os registros! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
