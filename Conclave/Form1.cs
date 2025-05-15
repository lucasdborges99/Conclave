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
    public partial class Form1 : Form
    {
        string[][] vetor;
        public Form1()
        {
            InitializeComponent();
            vetor = new string[300][];
        }

        public void AtribuirPapaveis(string[][] papaveis)
        {

        }
        private void btGerenciar_Click(object sender, EventArgs e)
        {
            frmGerenciar frm = new frmGerenciar(this, vetor);
            frm.ShowDialog();
            //this.Hide();
        }
        private void btVotar_Click(object sender, EventArgs e)
        {
            FrmVotar frm = new FrmVotar(this, vetor);
            frm.ShowDialog();
        }
    }
}
