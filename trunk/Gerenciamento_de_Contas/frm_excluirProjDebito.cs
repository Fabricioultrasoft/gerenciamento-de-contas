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
    public partial class frm_excluirProjDebito : Form
    {
        public frm_excluirProjDebito()
        {
            InitializeComponent();
        }

        private void projecoes_PagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projecoes_PagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contas_DBDataSet);

        }

        private void frm_excluirProjDebito_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contas_DBDataSet.Projecoes_Pagar' table. You can move, or remove it, as needed.
            this.projecoes_PagarTableAdapter.Fill(this.contas_DBDataSet.Projecoes_Pagar);

            this.reportViewer1.RefreshReport();
        }

        public void Excluir()
        {
            try
            {
                DadosProjecoesPagar Dados = new DadosProjecoesPagar();
                Dados.Excluir(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o registro! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Informe o mês da projeção a ser excluída!", "Excluir Projeção de Despesas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Excluir();
                frm_excluirProjDebito_Load(sender, e);
                MessageBox.Show("Projeção excluída com sucesso!", "Excluir Projeção de Despesas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Text = null;
            }
        }

        private void projecoes_PagarDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = Convert.ToString(projecoes_PagarDataGridView.CurrentCell.Value);
        }
    }
}
