using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Calculadora
{
    public partial class Cuaternios : Form
    {
        public Cuaternios()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Quaternion q1;
            Quaternion q2;
            Quaternion qR;
            try
            {
                q1 = new Quaternion(float.Parse(txtI.Text), float.Parse(txtJ.Text), float.Parse(txtK.Text), float.Parse(txtEscalar.Text));
                if (cmbOp.SelectedIndex != 4)
                {
                    q2 = new Quaternion(float.Parse(txtI2.Text), float.Parse(txtJ2.Text), float.Parse(txtK2.Text), float.Parse(txtEscalar2.Text));


                    if (cmbOp.SelectedIndex == 0)
                    {
                        qR = Quaternion.Add(q1, q2);
                        txtResultado.Text = qR.ToString();
                    }
                    if (cmbOp.SelectedIndex == 1)
                    {
                        qR = Quaternion.Subtract(q1, q2);
                        txtResultado.Text = qR.ToString();
                    }
                    if (cmbOp.SelectedIndex == 2)
                    {
                        qR = Quaternion.Multiply(q1, q2);
                        txtResultado.Text = qR.ToString();
                    }
                    if (cmbOp.SelectedIndex == 3)
                    {
                        qR = Quaternion.Multiply(q1, q2);
                        txtResultado.Text = qR.ToString();
                    }
                }
                if (cmbOp.SelectedIndex == 4)
                {
                    qR = Quaternion.Normalize(q1);
                    txtResultado.Text = qR.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error al capturar uno de los cuaternios", "Error");
            }
        }

        private void Cuaternios_Load(object sender, EventArgs e)
        {

        }

        private void cmbOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            gpbQ2.Show();
            if (cmbOp.SelectedIndex == 4)
            {
                gpbQ2.Hide();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            this.Close();
            mainMenu mainM = new mainMenu();
            mainM.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Cuaternios cuaternios = new Cuaternios();
            cuaternios.Show();
            this.Hide();
        }
    }
}
