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
    public partial class frm_proximosVencimentosPagar : Form
    {
        public frm_proximosVencimentosPagar()
        {
            InitializeComponent();
        }

        private void contas_PagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contas_PagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contas_DBDataSet);

        }

        private void frm_proximosVencimentosPagar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contas_DBDataSet.Contas_Pagar' table. You can move, or remove it, as needed.
            this.contas_PagarTableAdapter.Fill(this.contas_DBDataSet.Contas_Pagar);

            SelecionarPorData();
            OrdenarPorData();
        }

        DateTime data_atual = DateTime.Now;      
        
        public void SelecionarPorData()
        {
            try
            {
                this.contas_PagarBindingSource.Filter = "data_vencimento >= '" + data_atual + "' AND situacao = 'PENDENTE'";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao filtrar os registros! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OrdenarPorData()
        {
            try
            {
                this.contas_PagarTableAdapter.FillByOrdenarPorDataVencimento(contas_DBDataSet.Contas_Pagar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao ordenar os registros! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
