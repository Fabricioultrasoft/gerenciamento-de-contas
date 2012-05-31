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
    public partial class frm_pesquisaRapidaProjReceita : Form
    {
        public frm_pesquisaRapidaProjReceita()
        {
            InitializeComponent();
        }

        string valor;
        string tipo;

        public frm_pesquisaRapidaProjReceita(string valor, string tipo)
        {
            this.valor = valor;
            this.tipo = tipo;
        }
    
        private void projecoes_ReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projecoes_ReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contas_DBDataSet);

        }

        private void frm_pesquisaRapidaProjReceita_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contas_DBDataSet.Projecoes_Receber' table. You can move, or remove it, as needed.
            this.projecoes_ReceberTableAdapter.Fill(this.contas_DBDataSet.Projecoes_Receber);

        }
    }
}
