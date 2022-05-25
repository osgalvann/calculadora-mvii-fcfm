using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMatrices_Click(object sender, EventArgs e)
        {
            Matrices matrices = new Matrices();
            matrices.Show();
            this.Hide();
        }

        private void btnCuaternios_Click(object sender, EventArgs e)
        {
            Cuaternios cuaternios = new Cuaternios();
            cuaternios.Show();
            this.Hide();
        }

        private void btnVectores_Click(object sender, EventArgs e)
        {
            Vectores vectores = new Vectores();
            vectores.Show();
            this.Hide();
        }

        private void btnTrazos_Click(object sender, EventArgs e)
        {
            Bresenham bresenham = new Bresenham();
            bresenham.Show();
            this.Hide();
        }

        private void btnMatrizComp_Click(object sender, EventArgs e)
        {
            MatrizCompuesta matrizCompuesta = new MatrizCompuesta();
            matrizCompuesta.Show();
            this.Hide();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
