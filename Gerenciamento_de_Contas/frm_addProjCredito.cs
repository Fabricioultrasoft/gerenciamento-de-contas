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
    public partial class frm_addProjCredito : Form
    {
        public frm_addProjCredito()
        {
            InitializeComponent();
        }

        private void projecoes_ReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projecoes_ReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contas_DBDataSet);

        }

        private void frm_addProjCredito_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contas_DBDataSet.Projecoes_Receber' table. You can move, or remove it, as needed.
            this.projecoes_ReceberTableAdapter.Fill(this.contas_DBDataSet.Projecoes_Receber);
            apagarTextBox();
            this.reportViewer1.RefreshReport();
        }

        public void GravarDados()
        {
            try
            {
                double valor = Convert.ToDouble(valorTextBox.Text);

                DadosProjecoesReceber Dados = new DadosProjecoesReceber();
                Dados.Inserir(mesComboBox.Text, valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar o registro! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AlterarDados()
        {
            try
            {
                double valor = Convert.ToDouble(valorTextBox.Text);

                DadosProjecoesReceber Dados = new DadosProjecoesReceber();
                Dados.Atualizar(mesComboBox.Text, valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao atualizar o registro! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int resul = this.projecoes_ReceberTableAdapter.FillByPRSelectByMes(contas_DBDataSet.Projecoes_Receber, mesComboBox.Text);

            if (string.IsNullOrEmpty(mesComboBox.Text) || string.IsNullOrEmpty(valorTextBox.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //else if (resul == 1)
            //{
            //    if (MessageBox.Show("Projeção já existente! Deseja alterá-la?", "Projeção das Receitas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        AlterarDados();
            //        frm_addProjCredito_Load(sender, e);
            //        MessageBox.Show("Projeção realizada com sucesso!", "Projeção das Receitas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            else
            {
                GravarDados();
                frm_addProjCredito_Load(sender, e);
                MessageBox.Show("Projeção realizada com sucesso!", "Projeção das Receitas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void apagarTextBox()
        {
            mesComboBox.Text = null;
            valorTextBox.Text = null;
        }
    }
}
