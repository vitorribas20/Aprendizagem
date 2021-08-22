using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tá funcionando \n Vitor Ribas","");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BOTAO_Click(object sender, EventArgs e)
        {
            String nome = TXTNOME.Text;
            MessageBox.Show("Seu nome é:" + "\n" + nome, "Funciona mano");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
