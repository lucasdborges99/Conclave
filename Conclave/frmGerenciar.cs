using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conclave
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
            Atualizar();
        }

        void Atualizar()
        {
            dgvPapaveis.Rows.Clear();

            for(int i = 0; i < Funcoes.Lenght(papaveis); i++)
            {
                DataGridViewRow linha = new DataGridViewRow();
                linha.CreateCells(dgvPapaveis);
                linha.Cells[0].Value = papaveis[i][0];
                dgvPapaveis.Rows.Add(linha);
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            if (String.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Indique um nome");
                return;
            }
            if (Funcoes.Buscar(papaveis, nome) > -1)
            {
                MessageBox.Show(nome + " já cadastrado!");
            }
            
            if(Funcoes.Lenght(papaveis) == papaveis.Length)
            {
                MessageBox.Show("Lista cheia!");
                return;
            }

            papaveis[Funcoes.Lenght(papaveis)] = new string[] {nome, "0"};
            MessageBox.Show("Adicionado!");
            txtNome.Text = "";
            Atualizar();
        }   

        private void frmGerenciar_FormClosing(object sender, FormClosingEventArgs e)
        {
            anterior.AtribuirPapaveis(papaveis);
            anterior.Show();
        }
    }
}