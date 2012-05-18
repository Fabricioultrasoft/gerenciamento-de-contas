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
    public partial class frm_cadastrarCredito : Form
    {
        public frm_cadastrarCredito()
        {
            InitializeComponent();
        }

        private void contas_ReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contas_ReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contas_DBDataSet);

        }

        private void frm_cadastrarCredito_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contas_DBDataSet.Contas_Receber' table. You can move, or remove it, as needed.
            this.contas_ReceberTableAdapter.Fill(this.contas_DBDataSet.Contas_Receber);
            apagarTextBox();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            apagarTextBox();

            idTextBox.Text = Convert.ToString(this.contas_ReceberTableAdapter.ScalarQueryGetUltimoCodigo() + 1); 
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

        public void GravarDados()
        {
            try
            {
                string devedor = devedorTextBox.Text;
                string descricao = descricaoTextBox.Text;
                double valor = Convert.ToDouble(valorTextBox.Text);
                DateTime data_emissao = Convert.ToDateTime(data_emissaoDateTimePicker.Text).Date;
                DateTime data_vencimento = Convert.ToDateTime(data_vencimentoDateTimePicker.Text).Date;
                DateTime data_pagamento = Convert.ToDateTime(data_pagamentoDateTimePicker.Text).Date;
                string forma_pagamento = forma_pagamentoComboBox.Text;
                int multa = Convert.ToInt32(multaTextBox.Text);
                int juros = Convert.ToInt32(jurosTextBox.Text);
                int total_parcelas = Convert.ToInt32(total_parcelasTextBox.Text);
                double valor_parcela = Convert.ToDouble(valor_parcelaTextBox.Text);
                string situacao = situacaoComboBox.Text;

                DadosContasReceber Dados = new DadosContasReceber();
                Dados.Inserir(devedor, descricao, valor, data_emissao, data_vencimento, data_pagamento, forma_pagamento, multa, juros, total_parcelas, valor_parcela, situacao);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar o registro! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(devedorTextBox.Text) || string.IsNullOrEmpty(valorTextBox.Text) || string.IsNullOrEmpty(forma_pagamentoComboBox.Text) || string.IsNullOrEmpty(situacaoComboBox.Text))
            {
                MessageBox.Show("Peencha todos os campos indicados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                GravarDados();
                MessageBox.Show("Cadastro realizado com sucesso!", "Cadastrar Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
