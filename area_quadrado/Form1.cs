using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area_quadrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtLargura.Clear();
            txtAltura.Focus(); 
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, largura, area;
            altura = double.Parse(txtAltura.Text);
            largura = double.Parse(txtLargura.Text);
            area = altura * largura;

            MessageBox.Show("Para a Altura: " + altura + ", Largura: " + largura + ". A Área é: " + area);
        }
    }
}
