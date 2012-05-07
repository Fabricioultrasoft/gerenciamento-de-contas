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
    public partial class frm_excluirDebito : Form
    {
        public frm_excluirDebito()
        {
            InitializeComponent();
        }

        private void contas_PagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contas_PagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contas_DBDataSet);

        }

        private void frm_excluirDebito_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contas_DBDataSet.Contas_Pagar' table. You can move, or remove it, as needed.
            this.contas_PagarTableAdapter.Fill(this.contas_DBDataSet.Contas_Pagar);

        }

        private void contas_PagarDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = Convert.ToString(contas_PagarDataGridView.CurrentCell.Value);
        }

        public void excluir(int id)
        {
            try
            {
                DadosContasPagar Dados = new DadosContasPagar();
                Dados.Excluir(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao ecluir o registro!" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Informe o ID do débito a ser excluído!", "Excluir Débito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                excluir(Convert.ToInt32(textBox2.Text));
                MessageBox.Show("Débito exluído com sucesso!", "Ecluir Débito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.contas_PagarTableAdapter.Fill(this.contas_DBDataSet.Contas_Pagar);
            }
        }
    }
}
