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
    public partial class frm_despesasPagas : Form
    {
        public frm_despesasPagas()
        {
            InitializeComponent();
        }

        private void frm_despesasPagas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Contas_DBDataSet.Contas_Pagar' table. You can move, or remove it, as needed.
            this.Contas_PagarTableAdapter.Fill(this.Contas_DBDataSet.Contas_Pagar);

            this.reportViewer1.RefreshReport();
        }
    }
}
