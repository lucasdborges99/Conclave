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
        string id = "";
        Form1 anterior;
        string[][] papaveis;
        public frmGerenciar(Form1 anterior, string[][] papaveis)
        {
            InitializeComponent();
            this.anterior = anterior;
            this.papaveis = papaveis;
            Atualizar();
        }
    int Lenght(string[][] v)
        {
            int q = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] != null)
                    q++;
            }
            return q;
        }

        int Buscar(string nome)
        {
            int indice = 0;
            for (int i = 0; i < Lenght(papaveis) && papaveis[i][1] != nome; indice++)
                if (indice < Lenght(papaveis))
                    return indice;
            return -1;
        }

        void Atualizar()
        {
            dgvPapaveis.Rows.Clear();

            for(int i = 0; i < Lenght(papaveis); i++)
            {
                DataGridViewRow linha = new DataGridViewRow();
                linha.CreateCells(dgvPapaveis);
                for(int j = 0; j < papaveis[i].Length; j++)
                    linha.Cells[j].Value = papaveis[i][j];

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
            if (Buscar(nome) > -1)
            {
                MessageBox.Show(nome + " já cadastrado!");
            }
            
            if(Lenght(papaveis) == papaveis.Length)
            {
                MessageBox.Show("Lista cheia!");
                return;
            }

            int id = 1;
            if (Lenght(papaveis) > 0)
                id = int.Parse(papaveis[Lenght(papaveis) - 1][0]) + 1;

            papaveis[Lenght(papaveis)] = new string[] {id.ToString(), nome };
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