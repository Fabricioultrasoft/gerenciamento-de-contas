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
    public partial class frm_pesquisaRapidaDespesa : Form
    {
        public frm_pesquisaRapidaDespesa()
        {
            InitializeComponent();
        }

        string valor;
        string tipo;

        public frm_pesquisaRapidaDespesa(string valor_tb, string tipo)
        {
            InitializeComponent();
            this.valor = valor_tb;
            this.tipo = tipo;
        }

        private void contas_PagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contas_PagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contas_DBDataSet);

        }

        private void frm_pesquisaRapida_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contas_DBDataSet.Contas_Pagar' table. You can move, or remove it, as needed.
            this.contas_PagarTableAdapter.Fill(this.contas_DBDataSet.Contas_Pagar);
            Filtrar(tipo, valor);
        }

        public void Filtrar(string tipo, string valor_tb)
        {
            if (tipo == "ID")
            {
                this.contas_PagarTableAdapter.FillByPesquisaCodigo(contas_DBDataSet.Contas_Pagar, valor_tb);
            }
            else if (tipo == "Credor")
            {
                this.contas_PagarTableAdapter.FillByPesquisaCredor(contas_DBDataSet.Contas_Pagar, valor_tb);
            }
            else if (tipo == "Valor")
            {
                this.contas_PagarTableAdapter.FillByPesquisaValor(contas_DBDataSet.Contas_Pagar, valor_tb);
            }
            else if (tipo == "Situação")
            {
                this.contas_PagarTableAdapter.FillByPesquisaSituacao(contas_DBDataSet.Contas_Pagar, valor_tb);
            }
        }
    }
}
