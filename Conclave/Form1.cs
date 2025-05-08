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
        string[][] papaveis;
        public Form1()
        {
            InitializeComponent();
            papaveis = new string[300][];
        }

        public void AtribuirPapaveis(string[][] papaveis)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGerenciar frm = new frmGerenciar(this, papaveis);
            frm.ShowDialog();
            this.Hide();
        }
    }
}
