using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblbase.Text != "" && lblAltura.Text != "" && lblbase.Text != "0" && lblAltura.Text != "0")
            {
                double baseTriangulo = double.Parse(txtbase.Text);
                double alturaTriangulo = double.Parse(txtaltura.Text);
                double areaTriangulo = baseTriangulo * alturaTriangulo / 2;

                lblArea.Text = "Area "+ areaTriangulo.ToString();
            }
            else
            {
                MessageBox.Show("Incorreto!.");
            }
        }
    }
}
        
    

