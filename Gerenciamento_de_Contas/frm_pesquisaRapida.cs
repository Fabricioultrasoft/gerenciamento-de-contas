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
    public partial class frm_pesquisaRapida : Form
    {
        public frm_pesquisaRapida()
        {
            InitializeComponent();
        }

        public frm_pesquisaRapida(bool opcao, string valor_tb, string tipo)
        {
            InitializeComponent();
            Procurar(opcao, tipo, valor_tb);
        }

        private void contas_PagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contas_PagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contas_DBDataSet);

        }

        private void frm_pesquisaRapida_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contas_DBDataSet.Contas_Receber' table. You can move, or remove it, as needed.
            this.contas_ReceberTableAdapter.Fill(this.contas_DBDataSet.Contas_Receber);
            // TODO: This line of code loads data into the 'contas_DBDataSet.Contas_Pagar' table. You can move, or remove it, as needed.
            this.contas_PagarTableAdapter.Fill(this.contas_DBDataSet.Contas_Pagar);

        }

        public void Procurar(bool opcao, string tipo, string valor_tb)
        {
            if (opcao == true)
            {
                ProcurarPagar(tipo, valor_tb);
            }
            else
            {
                ProcurarReceber(tipo, valor_tb);
            }
        }

        public void ProcurarPagar(string tipo, string valor_tb)
        {
            contas_ReceberDataGridView.Visible = false;

            if (tipo == "ID")
            {
                this.contas_PagarTableAdapter.FillByPesquisaCodigo(contas_DBDataSet.Contas_Pagar, valor_tb);
            }
            else if (tipo == "Credor | Devedor")
            {
                this.contas_PagarTableAdapter.FillByPesquisaCredor(contas_DBDataSet.Contas_Pagar, valor_tb);
            }
            else if (tipo == "Valor")
            {
                this.contas_PagarTableAdapter.FillByPesquisaValor(contas_DBDataSet.Contas_Pagar, valor_tb);
            }
        }

        public void ProcurarReceber(string tipo, string valor_tb)
        {
            contas_PagarDataGridView.Visible = false;

            if (tipo == "ID")
            {
                this.contas_ReceberTableAdapter.FillByPesquisaCodigo(contas_DBDataSet.Contas_Receber, valor_tb);
            }
            else if (tipo == "Credor | Devedor")
            {
                this.contas_ReceberTableAdapter.FillByPesquisaDevedor(contas_DBDataSet.Contas_Receber, valor_tb);
            }
            else if (tipo == "Valor")
            {
                this.contas_ReceberTableAdapter.FillByPesquisaValor(contas_DBDataSet.Contas_Receber, valor_tb);
            }
        }
    }
}
