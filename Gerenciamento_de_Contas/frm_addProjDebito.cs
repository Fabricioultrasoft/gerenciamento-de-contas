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
    public partial class frm_addProjDebito : Form
    {
        public frm_addProjDebito()
        {
            InitializeComponent();
        }

        private void projecoes_PagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projecoes_PagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contas_DBDataSet);

        }

        private void frm_addProjDebito_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contas_DBDataSet.Projecoes_Pagar' table. You can move, or remove it, as needed.
            this.projecoes_PagarTableAdapter.Fill(this.contas_DBDataSet.Projecoes_Pagar);
            apagarTextBox();
            this.reportViewer1.RefreshReport();
        }

        public void GravarDados()
        {
            try
            {
                double valor = Convert.ToDouble(valorTextBox.Text);

                DadosProjecoesPagar Dados = new DadosProjecoesPagar();
                Dados.Inserir(mesComboBox.Text, valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o registro! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mesComboBox.Text) || string.IsNullOrEmpty(valorTextBox.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                GravarDados();
                MessageBox.Show("Projeção realizada com sucesso!", "Projeção das Despesas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_addProjDebito_Load(sender, e);
            }
        }

        public void apagarTextBox()
        {
            mesComboBox.Text = null;
            valorTextBox.Text = null;
        }
    }
}
