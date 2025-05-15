using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conclave
{
    public partial class FrmVotar : Form
    {
        Form1 anterior;
        string[][] cardeais;
        public FrmVotar(Form1 anterior, string[][]cardeais)
        {
            InitializeComponent();
            this.anterior = anterior;
            this.cardeais = cardeais;

            Carregar();
        }
        
        void Carregar()
        {
            for (int i = 0; i < Funcoes.Lenght(cardeais); i++)
                lbxCardeais.Items.Add(cardeais[i][0]);
        }

        private void btVotar_Click(object sender, EventArgs e)
        {
            if(lbxCardeais.SelectedItems.Count != 1)
            {
                MessageBox.Show("Selecione uma opção!");
                return;
            }

            string nome = lbxCardeais.SelectedItems[0].ToString();
            int indice = Funcoes.Buscar(cardeais, nome);

            int votos = int.Parse(cardeais[indice][1]);
            votos++;
            cardeais[indice][1] = votos + "";

            anterior.AtribuirPapaveis(cardeais);
            this.Close();

        }
    }
}
