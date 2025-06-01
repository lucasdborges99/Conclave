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
    public partial class Form1 : Form
    {
        string[][] papaveis;
        public Form1()
        {
            InitializeComponent();
            papaveis = new string[300][];
        }
        private void btGerenciar_Click(object sender, EventArgs e)
        {
            frmGerenciar f = new frmGerenciar(this, papaveis);
            f.Show();
            this.Hide();
        }

        public void AtribuirPapaveis(string[][] papaveis)
        {
            this.papaveis = papaveis;
        }

        private void btVotar_Click(object sender, EventArgs e)
        {
            FrmVotar f = new FrmVotar(this, papaveis);
            f.ShowDialog();
        }

        private void btResultado_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("Deseja encerrar a votação?", "Encerrar Votação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar == DialogResult.No) return;

            int totalVotos = 0;
            for (int i = 0; i < funcoes.Length(papaveis); i++)
            {
                totalVotos += int.Parse(papaveis[i][1]);
            }

            int doisTerços = (int)Math.Ceiling(totalVotos * 2.0 / 3.0);
            bool houveVencedor = false;
            int vencedorIndex = -1;

            for (int i = 0; i < funcoes.Length(papaveis); i++)
            {
                int votos = int.Parse(papaveis[i][1]);
                if (votos >= doisTerços)
                {
                    houveVencedor = true;
                    vencedorIndex = i;
                    break;
                }
            }

            if (!houveVencedor)
            {
                MessageBox.Show("Nenhum cardeal atingiu 2/3 dos votos. Votação será reiniciada.");
                for (int i = 0; i < funcoes.Length(papaveis); i++)
                {
                    papaveis[i][1] = "0";
                }
            }
            else
            {
                string nome = papaveis[vencedorIndex][0];
                DialogResult aceitar = MessageBox.Show($"{nome} foi eleito! Você aceita a eleição canônica à Sumo Pontífice?", "Eleição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (aceitar == DialogResult.Yes)
                {
                    MessageBox.Show("HABEMUS PAPAM!");
                    for (int i = 0; i < funcoes.Length(papaveis); i++)
                    {
                        papaveis[i] = null;
                    }
                }
                else
                {
                    for (int i = 0; i < funcoes.Length(papaveis); i++)
                    {
                        papaveis[i][1] = "0";
                    }
                }
            }
        }
    }
}