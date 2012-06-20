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
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_cadastrarDebito().ShowDialog();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_alterarDebito2().ShowDialog();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_excluirDebito().ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_consultarDebito().ShowDialog();
        }

        private void despesasPendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_despesasPendentes().ShowDialog();
        }

        private void novaProjeçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_addProjDebito().ShowDialog();
        }

        private void excluirProjeçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_excluirProjDebito().ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frm_cadastrarCredito().ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frm_consultarCredito().ShowDialog();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frm_alterarCredito().ShowDialog();
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frm_excluirCredito().ShowDialog();
        }

        private void novaProjeçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frm_addProjCredito().ShowDialog();
        }

        private void excluirProjeçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frm_excluirProjCredito().ShowDialog();
        }

        private void projeçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frm_graficoProjecoes().ShowDialog();
        }

        private void despesasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frm_relatorioDespesas().ShowDialog();
        }

        private void receitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_relatorioReceitas().ShowDialog();
        }

        private void despesasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new frm_graficoDespesas().ShowDialog();
        }

        private void despesasVencidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_despesasVencidas().ShowDialog();
        }

        private void despesasPagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_despesasPagas().ShowDialog();
        }

        private void receitasPagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_receitasPagas().ShowDialog();
        }

        private void receitasPendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_receitasPendentes().ShowDialog();
        }

        private void receitasVencidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_receitasVencidas().ShowDialog();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Contas_DBDataSet.Contas_Receber' table. You can move, or remove it, as needed.
            this.contas_ReceberTableAdapter.Fill(this.Contas_DBDataSet.Contas_Receber);
            // TODO: This line of code loads data into the 'Contas_DBDataSet.Contas_Pagar' table. You can move, or remove it, as needed.
            this.Contas_PagarTableAdapter.Fill(this.Contas_DBDataSet.Contas_Pagar);

            SumValorPagar();
            SumValorReceber();
            Saldos();
        }

        public void SumValorPagar()
        {
            try
            {
                lb_pendentes.Text = addVirgula(this.Contas_PagarTableAdapter.ScalarQuerySumPendetes().ToString());
                lb_pagos.Text = addVirgula(this.Contas_PagarTableAdapter.ScalarQuerySumPago().ToString());
                lb_vencidos.Text = addVirgula(this.Contas_PagarTableAdapter.ScalarQuerySumVencido().ToString());
                lb_total.Text = addVirgula(this.Contas_PagarTableAdapter.ScalarQuerySumValor().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao atualizar os dados! " + ex, "Atualizar Débitos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SumValorReceber()
        {
            try
            {
                lb_pendentes2.Text = addVirgula(this.contas_ReceberTableAdapter.ScalarQuerySumPendentes().ToString());
                lb_pagos2.Text = addVirgula(this.contas_ReceberTableAdapter.ScalarQuerySumPagos().ToString());
                lb_vencidos2.Text = addVirgula(this.contas_ReceberTableAdapter.ScalarQuerySumVencidos().ToString());
                lb_total2.Text = addVirgula(this.contas_ReceberTableAdapter.ScalarQuerySum().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao atualizar os dados! " + ex, "Atualizar Receitas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Saldos()
        {
            try
            {
                lb_s_pendentes.Text = addVirgula((Convert.ToDouble(this.contas_ReceberTableAdapter.ScalarQuerySumPendentes()) - Convert.ToDouble(this.Contas_PagarTableAdapter.ScalarQuerySumPendetes())).ToString());
                lb_s_pagos.Text = addVirgula((Convert.ToDouble(this.contas_ReceberTableAdapter.ScalarQuerySumPagos()) - Convert.ToDouble(this.Contas_PagarTableAdapter.ScalarQuerySumPago())).ToString());
                lb_s_vencidos.Text = addVirgula((Convert.ToDouble(this.contas_ReceberTableAdapter.ScalarQuerySumVencidos()) - Convert.ToDouble(this.Contas_PagarTableAdapter.ScalarQuerySumVencido())).ToString());
                lb_s_total.Text = addVirgula((Convert.ToDouble(this.contas_ReceberTableAdapter.ScalarQuerySum()) - Convert.ToDouble(this.Contas_PagarTableAdapter.ScalarQuerySumValor())).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao atualizar os dados! " + ex, "Atualizar Saldos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            SumValorPagar();
            AtualizarDatasPagar();
            MessageBox.Show("Despesas atualizadas com sucesso!", "Atualizar Despesas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bt_atualizar2_Click(object sender, EventArgs e)
        {
            SumValorReceber();
            AtualizarDatasReceber();
            MessageBox.Show("Receitas atualizadas com sucesso!", "Atualizar Receitas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bt_atualizar_saldos_Click(object sender, EventArgs e)
        {
            Saldos();
            MessageBox.Show("Atualização realizada com sucesso!", "Atualizar Valores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool formatoValor(string label)
        {
            bool formato = false;

            for (int i = 0; i < label.Length; i++)
            {
                if (label[i].ToString() == ",")
                {
                    formato = true;
                }
            }

            return formato;
        }

        public string addVirgula(string label)
        {
            if (formatoValor(label) == false)
            {
                label = label + ",00";
            }

            return label;
        }

        DateTime data_atual = DateTime.Now;

        public void AtualizarDatasPagar()
        {
            try
            {
                DadosContasPagar Dados = new DadosContasPagar();
                Dados.AtualizarDatas(data_atual);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao atualizar o registro! " + ex, "Atualizar Datas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AtualizarDatasReceber()
        {
            try
            {
                DadosContasReceber Dados = new DadosContasReceber();
                Dados.AtualizarDatas(data_atual);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao atualizar o registro! " + ex, "Atualizar Datas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            if (rbt_credito.Checked == true)
            {
                new frm_pesquisaRapidaReceita(textBox1.Text, comboBox1.Text).ShowDialog();
            }
            else if (rbt_debito.Checked == true)
            {
                new frm_pesquisaRapidaDespesa(textBox1.Text, comboBox1.Text).ShowDialog();
            }
            else if (rbt_projecoesdespesas.Checked == true)
            {
                new frm_pesquisaRapidaProjDespesa(textBox1.Text, comboBox1.Text).ShowDialog();
            }
            else if (rbt_projecoesreceitas.Checked == true)
            {
                new frm_pesquisaRapidaProjReceita(textBox1.Text, comboBox1.Text).ShowDialog();
            }
            else if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Preencha os dois campos!", "Pesquisa rápida!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecione uma opção!", "Pesquisa Rápida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_proximosVencimentosPagar_Click(object sender, EventArgs e)
        {
            new frm_proximosVencimentosPagar().ShowDialog();
        }

        string[] opcoesdespesa = new string[6] {"ID", "Credor", "Valor", "Status", "Data de Emissão", "Data de Vencimento"};
        string[] opcoesreceita = new string[6] { "ID", "Devedor", "Valor", "Status", "Data de Emissão", "Data de Vencimento"};
        string[] opcoesprojecoes = new string[2] {"Mês", "Valor"};

        private void rbt_debito_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(opcoesdespesa);
        }

        private void rbt_credito_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(opcoesreceita);
        }

        private void rbt_projecoesdespesas_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(opcoesprojecoes);
        }

        private void rbt_projecoesreceitas_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(opcoesprojecoes);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frm_proximosVencimentosReceber().ShowDialog();
        }

        private void prioridadesDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_prioridadesPagamento().ShowDialog();
        }

        private void prioridadesDeCobrançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_prioridadesCobranca().ShowDialog();
        }
    }
}
