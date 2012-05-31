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
    public partial class frm_graficoProjecoes : Form
    {
        public frm_graficoProjecoes()
        {
            InitializeComponent();
        }

        private void frm_graficoProjecoes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Contas_DBDataSet.Projecoes_Receber' table. You can move, or remove it, as needed.
            this.Projecoes_ReceberTableAdapter.Fill(this.Contas_DBDataSet.Projecoes_Receber);
            // TODO: This line of code loads data into the 'Contas_DBDataSet.Projecoes_Pagar' table. You can move, or remove it, as needed.
            this.Projecoes_PagarTableAdapter.Fill(this.Contas_DBDataSet.Projecoes_Pagar);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
