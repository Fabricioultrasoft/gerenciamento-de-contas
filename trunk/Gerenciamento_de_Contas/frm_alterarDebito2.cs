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
    public partial class frm_alterarDebito2 : Form
    {
        public frm_alterarDebito2()
        {
            InitializeComponent();
        }

        private void contas_PagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contas_PagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contas_DBDataSet);

        }

        private void frm_alterarDebito2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contas_DBDataSet.Contas_Pagar' table. You can move, or remove it, as needed.
            this.contas_PagarTableAdapter.Fill(this.contas_DBDataSet.Contas_Pagar);
            apagarTextBox();
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

            this.contas_PagarTableAdapter.Fill(this.contas_DBDataSet.Contas_Pagar);
        }

        private void bt_ultimo_Click(object sender, EventArgs e)
        {
            this.contas_PagarBindingSource.MoveLast();
        }

        private void bt_primeiro_Click(object sender, EventArgs e)
        {
            this.contas_PagarBindingSource.MoveFirst();
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            this.contas_PagarBindingSource.MovePrevious();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            this.contas_PagarBindingSource.MoveNext();
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

                DadosContasPagar Dados = new DadosContasPagar();
                Dados.Atualizar(id, credorTextBox.Text, descricaoTextBox.Text, valor, data_emissao, data_vencimento, data_pagamento, forma_pagamentoComboBox.Text, multa, juros, total_parcelas, valor_parcela, situacaoComboBox.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar o registro!" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(credorTextBox.Text) || string.IsNullOrEmpty(valorTextBox.Text) || string.IsNullOrEmpty(forma_pagamentoComboBox.Text) || string.IsNullOrEmpty(situacaoComboBox.Text))
            {
                MessageBox.Show("Peencha todos os campos indicados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                GravarDados();
                MessageBox.Show("Alteração realizada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void apagarTextBox()
        {
            credorTextBox.Text = null;
            descricaoTextBox.Text = null;
            valorTextBox.Text = null;
            forma_pagamentoComboBox.Text = null;
            multaTextBox.Text = null;
            jurosTextBox.Text = null;
            total_parcelasTextBox.Text = null;
            valor_parcelaTextBox.Text = null;
            situacaoComboBox.Text = null;
        }
    }
}
