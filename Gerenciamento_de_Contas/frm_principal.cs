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

        DateTime data_hora;

        private void timer1_Tick(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;
            String data = String.Format("{0:d}", data_hora);
            String hora = data_hora.ToLongTimeString();
            lb_status1.Text = data;
            lb_status2.Text = hora;
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

        private void frm_principal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Contas_DBDataSet.Contas_Receber' table. You can move, or remove it, as needed.
            this.contas_ReceberTableAdapter.Fill(this.Contas_DBDataSet.Contas_Receber);
            // TODO: This line of code loads data into the 'Contas_DBDataSet.Contas_Pagar' table. You can move, or remove it, as needed.
            this.Contas_PagarTableAdapter.Fill(this.Contas_DBDataSet.Contas_Pagar);

            SumValorPagar();
            SumValorReceber();
        }

        public void SumValorPagar()
        {
            lb_pendentes.Text = this.Contas_PagarTableAdapter.ScalarQuerySumPendetes().ToString();
            lb_pagos.Text = this.Contas_PagarTableAdapter.ScalarQuerySumPago().ToString();
            lb_vencidos.Text = this.Contas_PagarTableAdapter.ScalarQuerySumVencido().ToString();
            lb_total.Text = this.Contas_PagarTableAdapter.ScalarQuerySumValor().ToString();
        }

        public void SumValorReceber()
        {
            lb_pendentes2.Text = this.contas_ReceberTableAdapter.ScalarQuerySumPendentes().ToString();
            lb_pagos2.Text = this.contas_ReceberTableAdapter.ScalarQuerySumPagos().ToString();
            lb_vencidos2.Text = this.contas_ReceberTableAdapter.ScalarQuerySumVencidos().ToString();
            lb_total2.Text = this.contas_ReceberTableAdapter.ScalarQuerySum().ToString();
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            SumValorPagar();
        }

        private void bt_atualizar2_Click(object sender, EventArgs e)
        {
            SumValorReceber();
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            if (rbt_credito.Checked == true)
            {
                new frm_pesquisaRapida(true, textBox1.Text, comboBox1.Text).ShowDialog();
            }
            else if (rbt_debito.Checked == true)
            {
                new frm_pesquisaRapida(false, textBox1.Text, comboBox1.Text).ShowDialog();
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
    }
}
