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
    public partial class frm_excluirCredito : Form
    {
        public frm_excluirCredito()
        {
            InitializeComponent();
        }

        private void contas_ReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contas_ReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contas_DBDataSet);

        }

        private void frm_excluirCredito_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contas_DBDataSet.Contas_Receber' table. You can move, or remove it, as needed.
            this.contas_ReceberTableAdapter.Fill(this.contas_DBDataSet.Contas_Receber);

        }

        public void ExcluirDados()
        {
            try
            {
                int id = Convert.ToInt32(textBox2.Text);

                DadosContasReceber Dados = new DadosContasReceber();
                Dados.Excluir(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir o registro! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Informe o ID do crédito a ser excluído!", "Excluir Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ExcluirDados();
                this.contas_ReceberTableAdapter.Fill(this.contas_DBDataSet.Contas_Receber);
                MessageBox.Show("Crédito exluído com sucesso!", "Excluir Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                apagarTextBox();
            }
        }

        public void apagarTextBox()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            comboBox1.Text = null;
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
            else if (comboBox1.Text == "Status")
            {
                this.contas_ReceberTableAdapter.FillByPesquisaSituacao(contas_DBDataSet.Contas_Receber, textBox1.Text.ToUpper());
            }
        }

        private void contas_ReceberDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = Convert.ToString(contas_ReceberDataGridView.CurrentCell.Value);
        }
    }
}
