using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatarValoresParaQuery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Formatar();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void btnGerarCopiar_Click(object sender, EventArgs e)
        {
            Formatar();
            Copiar();
        }

        private void Formatar()
        {
            string temp = txtIn.Text.Replace("\r", "");
            txtOut.Text = "('" + temp.Replace("\n", "'),('") + "')";
        }

        private void Copiar()
        {
            Clipboard.SetText(txtOut.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIn.Text = txtOut.Text = "";
        }

    }
}
