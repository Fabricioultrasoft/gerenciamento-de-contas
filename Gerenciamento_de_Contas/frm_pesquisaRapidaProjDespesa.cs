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
    public partial class frm_pesquisaRapidaProjDespesa : Form
    {
        public frm_pesquisaRapidaProjDespesa()
        {
            InitializeComponent();
        }

        string valor;
        string tipo;

        public frm_pesquisaRapidaProjDespesa(string tipo, string valor)
        {
            this.valor = valor;
            this.tipo = tipo;
        }

        private void projecoes_PagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projecoes_PagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contas_DBDataSet);

        }

        private void frm_pesquisaRapidaProjDespesa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contas_DBDataSet.Projecoes_Pagar' table. You can move, or remove it, as needed.
            this.projecoes_PagarTableAdapter.Fill(this.contas_DBDataSet.Projecoes_Pagar);

        }
    }
}
