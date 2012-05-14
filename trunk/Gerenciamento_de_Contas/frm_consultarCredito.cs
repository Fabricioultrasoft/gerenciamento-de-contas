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
    public partial class frm_consultarCredito : Form
    {
        public frm_consultarCredito()
        {
            InitializeComponent();
        }

        private void contas_ReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contas_ReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contas_DBDataSet);

        }

        private void frm_consultarCredito_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contas_DBDataSet.Contas_Receber' table. You can move, or remove it, as needed.
            this.contas_ReceberTableAdapter.Fill(this.contas_DBDataSet.Contas_Receber);

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ID")
            {
                this.contas_ReceberTableAdapter.FillByPesquisaCodigo(contas_DBDataSet.Contas_Receber, textBox1.Text);
            }
            else if (comboBox1.Text == "Devedor")
            {
                this.contas_ReceberTableAdapter.FillByPesquisaDevedor(contas_DBDataSet.Contas_Receber, textBox1.Text);
            }
            else if (comboBox1.Text == "Valor")
            {
                this.contas_ReceberTableAdapter.FillByPesquisaValor(contas_DBDataSet.Contas_Receber, textBox1.Text);
            }
            else if (comboBox1.Text == "Forma de Pagamento")
            {
                this.contas_ReceberTableAdapter.FillByPesquisaFormaPagamento(contas_DBDataSet.Contas_Receber, textBox1.Text.ToUpper());
            }
            else if (comboBox1.Text == "Status")
            {
                this.contas_ReceberTableAdapter.FillByPesquisaSituacao(contas_DBDataSet.Contas_Receber, textBox1.Text.ToUpper());
            }
        }
    }
}
