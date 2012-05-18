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
    public partial class frm_excluirProjCredito : Form
    {
        public frm_excluirProjCredito()
        {
            InitializeComponent();
        }

        private void projecoes_ReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projecoes_ReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contas_DBDataSet);

        }

        private void frm_excluirProjCredito_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contas_DBDataSet.Projecoes_Receber' table. You can move, or remove it, as needed.
            this.projecoes_ReceberTableAdapter.Fill(this.contas_DBDataSet.Projecoes_Receber);

            this.reportViewer1.RefreshReport();
        }

        public void Excluir()
        {
            try
            {
                DadosProjecoesReceber Dados = new DadosProjecoesReceber();
                Dados.Excluir(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir o registro! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Informe o mês da projeção a ser excluída!", "Excluir Projeção de Despesas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Excluir();
                frm_excluirProjCredito_Load(sender, e);
                MessageBox.Show("Projeção excluída com sucesso!", "Excluir Projeção de Receitas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Text = null;
            }
        }

        private void projecoes_ReceberDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = this.projecoes_ReceberDataGridView.CurrentCell.Value.ToString();
        }
    }
}
