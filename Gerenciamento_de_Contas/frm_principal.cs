﻿using System;
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
    }
}