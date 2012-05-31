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
    public partial class frm_alterarCredito : Form
    {
        public frm_alterarCredito()
        {
            InitializeComponent();
        }

        private void contas_ReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contas_ReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contas_DBDataSet);

        }

        private void frm_alterarCredito_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contas_DBDataSet.Contas_Receber' table. You can move, or remove it, as needed.
            this.contas_ReceberTableAdapter.Fill(this.contas_DBDataSet.Contas_Receber);
            apagarTextBox();
        }

        public void GravarDados()
        {
            try
            {
                int id = Convert.ToInt32(idTextBox.Text);
                double valor = Convert.ToDouble(valorTextBox.Text);
                DateTime data_emissao = Convert.ToDateTime(data_emissaoDateTimePicker.Text);
                DateTime data_vencimento = Convert.ToDateTime(data_vencimentoDateTimePicker.Text);
                DateTime data_pagamento = Convert.ToDateTime(data_pagamentoDateTimePicker.Text);
                int multa = Convert.ToInt32(multaTextBox.Text);
                int juros = Convert.ToInt32(jurosTextBox.Text);
                int total_parcelas = Convert.ToInt32(total_parcelasTextBox.Text);
                double valor_parcela = Convert.ToDouble(valor_parcelaTextBox.Text);

                DadosContasReceber Dados = new DadosContasReceber();
                Dados.Atualizar(id, devedorTextBox.Text, descricaoTextBox.Text, valor, data_emissao, data_vencimento, data_pagamento, forma_pagamentoComboBox.Text, multa, juros, total_parcelas, valor_parcela, situacaoComboBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar o registro!" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(devedorTextBox.Text) || string.IsNullOrEmpty(valorTextBox.Text) || string.IsNullOrEmpty(forma_pagamentoComboBox.Text) || string.IsNullOrEmpty(situacaoComboBox.Text) || string.IsNullOrEmpty(multaTextBox.Text) || string.IsNullOrEmpty(jurosTextBox.Text) || string.IsNullOrEmpty(total_parcelasTextBox.Text) || string.IsNullOrEmpty(valor_parcelaTextBox.Text))
            {
                MessageBox.Show("Peencha todos os campos indicados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                GravarDados();
                MessageBox.Show("Alteração realizada com sucesso!", "Alterar Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void apagarTextBox()
        {
            devedorTextBox.Text = null;
            descricaoTextBox.Text = null;
            valorTextBox.Text = null;
            forma_pagamentoComboBox.Text = null;
            multaTextBox.Text = null;
            jurosTextBox.Text = null;
            total_parcelasTextBox.Text = null;
            valor_parcelaTextBox.Text = null;
            situacaoComboBox.Text = null;
        }

        private void bt_primeiro_Click(object sender, EventArgs e)
        {
            this.contas_ReceberBindingSource.MoveFirst();
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            this.contas_ReceberBindingSource.MovePrevious();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            this.contas_ReceberBindingSource.MoveNext();
        }

        private void bt_ultimo_Click(object sender, EventArgs e)
        {
            this.contas_ReceberBindingSource.MoveLast();
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

            this.contas_ReceberTableAdapter.Fill(this.contas_DBDataSet.Contas_Receber);
        }
    }
}
