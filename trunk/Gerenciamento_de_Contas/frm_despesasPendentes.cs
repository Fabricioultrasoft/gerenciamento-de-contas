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
    public partial class frm_despesasPendentes : Form
    {
        public frm_despesasPendentes()
        {
            InitializeComponent();
        }

        private void frm_despesasPendentes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contas_DBDataSet.Contas_Pagar' table. You can move, or remove it, as needed.
            this.contas_PagarTableAdapter.Fill(this.contas_DBDataSet.Contas_Pagar);

            RelatorioDespesasPendentes RDP = new RelatorioDespesasPendentes();

            RDP.SetDataSource(contas_DBDataSet);

            crystalReportViewer1.ReportSource = RDP;
        }

        private void contas_PagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contas_PagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contas_DBDataSet);

        }
    }
}
