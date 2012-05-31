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
    public partial class frm_relatorioReceitas : Form
    {
        public frm_relatorioReceitas()
        {
            InitializeComponent();
        }

        private void frm_relatorioReceitas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Contas_DBDataSet.Contas_Receber' table. You can move, or remove it, as needed.
            this.Contas_ReceberTableAdapter.Fill(this.Contas_DBDataSet.Contas_Receber);

            this.reportViewer1.RefreshReport();
        }
    }
}
