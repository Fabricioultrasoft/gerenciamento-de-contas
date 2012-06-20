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
    public partial class frm_pesquisaRapidaReceita : Form
    {
        public frm_pesquisaRapidaReceita()
        {
            InitializeComponent();
        }

        string valor;
        string tipo;

        public frm_pesquisaRapidaReceita(string valor2, string tipo2)
        {
            this.valor = valor2;
            this.tipo = tipo2;
            InitializeComponent();
        }

        private void contas_ReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contas_ReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contas_DBDataSet);

        }

        private void frm_pesquisaRapidaReceita_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contas_DBDataSet.Contas_Receber' table. You can move, or remove it, as needed.
            this.contas_ReceberTableAdapter.Fill(this.contas_DBDataSet.Contas_Receber);
            Filtar(valor, tipo);
        }

        public void Filtar(string valor_tb, string tipo)
        {
            try
            {
                if (tipo == "ID")
                {
                    this.contas_ReceberTableAdapter.FillByPesquisaCodigo(contas_DBDataSet.Contas_Receber, valor_tb);
                }
                else if (tipo == "Devedor")
                {
                    this.contas_ReceberTableAdapter.FillByPesquisaDevedor(contas_DBDataSet.Contas_Receber, valor_tb);
                }
                else if (tipo == "Valor")
                {
                    this.contas_ReceberTableAdapter.FillByPesquisaValor(contas_DBDataSet.Contas_Receber, valor_tb);
                }
                else if (tipo == "Status")
                {
                    this.contas_ReceberTableAdapter.FillByPesquisaSituacao(contas_DBDataSet.Contas_Receber, valor_tb);
                }
                else if (tipo == "Data de Emissão")
                {
                    this.contas_ReceberTableAdapter.ScalarQueryPesquisaDataEmissao(valor_tb);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao filtrar os registros!" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
