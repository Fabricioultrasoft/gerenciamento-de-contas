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
    public partial class frm_consultarDebito : Form
    {
        public frm_consultarDebito()
        {
            InitializeComponent();
        }

        private void contas_PagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contas_PagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contas_DBDataSet);

        }

        private void frm_consultarDebito_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contas_DBDataSet.Contas_Pagar' table. You can move, or remove it, as needed.
            this.contas_PagarTableAdapter.Fill(this.contas_DBDataSet.Contas_Pagar);

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ID")
            {
                this.contas_PagarTableAdapter.FillByPesquisaCodigo(contas_DBDataSet.Contas_Pagar, textBox1.Text);
            }
            else if (comboBox1.Text == "Credor")
            {
                this.contas_PagarTableAdapter.FillByPesquisaCredor(contas_DBDataSet.Contas_Pagar, textBox1.Text);
            }
            else if (comboBox1.Text == "Valor")
            {
                this.contas_PagarTableAdapter.FillByPesquisaValor(contas_DBDataSet.Contas_Pagar, textBox1.Text);
            }
            else if (comboBox1.Text == "Forma de Pagamento")
            {
                this.contas_PagarTableAdapter.FillByPesquisaFormaPagamento(contas_DBDataSet.Contas_Pagar, textBox1.Text);
            }
            else if (comboBox1.Text == "Data de Emissão")
            {
                this.contas_PagarTableAdapter.FillByPesquisaDataVencimento(contas_DBDataSet.Contas_Pagar, textBox1.Text);
            }
            else if (comboBox1.Text == "Status")
            {
                this.contas_PagarTableAdapter.FillByPesquisaSituacao(contas_DBDataSet.Contas_Pagar, textBox1.Text.ToUpper());
            }
        }
    }
}
