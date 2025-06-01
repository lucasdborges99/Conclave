using Conclave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conclave
{
    public partial class frmGerenciar : Form
    {
        Form1 anterior;
        string[][] papaveis;

        public frmGerenciar(Form1 anterior, string[][] papaveis)
        {
            InitializeComponent();
            this.anterior = anterior;
            this.papaveis = papaveis;

            dgvPapaveis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPapaveis.MultiSelect = false;

            atualizar();
        }

        private void frmGerenciar_FormClosing(object sender, FormClosingEventArgs e)
        {
            anterior.AtribuirPapaveis(papaveis);
            anterior.Show();
        }

        void atualizar()
        {
            dgvPapaveis.Rows.Clear();
            for (int i = 0; i < funcoes.Length(papaveis); i++)
            {
                if (!string.IsNullOrEmpty(papaveis[i][0]))
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvPapaveis);
                    row.Cells[0].Value = papaveis[i][0];
                    dgvPapaveis.Rows.Add(row);
                }
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (funcoes.Length(papaveis) == papaveis.Length)
            {
                MessageBox.Show("Lista Cheia");
                return;
            }

            string nome = txtNome.Text.Trim();

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Indique um nome");
                return;
            }

            if (funcoes.buscar(papaveis, nome) > -1)
            {
                MessageBox.Show("Nome já cadastrado");
                return;
            }

            papaveis[funcoes.Length(papaveis)] = new string[] { nome, "0" };
            MessageBox.Show("Papável adicionado com sucesso");
            txtNome.Text = "";
            atualizar();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgvPapaveis.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cardeal para excluir.");
                return;
            }

            DataGridViewRow row = dgvPapaveis.SelectedRows[0];
            string nome = row.Cells[0].Value.ToString();

            DialogResult confirmar = MessageBox.Show($"Deseja excluir o cardeal {nome}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmar == DialogResult.Yes)
            {
                int indice = funcoes.buscar(papaveis, nome);

                if (indice > -1)
                {
                    for (int i = indice; i < funcoes.Length(papaveis) - 1; i++)
                    {
                        papaveis[i] = papaveis[i + 1];
                    }

                    papaveis[funcoes.Length(papaveis) - 1] = null;
                    atualizar();
                }
            }
        }
    }
}