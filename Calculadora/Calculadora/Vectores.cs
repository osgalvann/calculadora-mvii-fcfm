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
    public partial class Vectores : Form
    {
        public Vectores()
        {
            InitializeComponent();
        }

        private void Vectores_Load(object sender, EventArgs e)
        {
            //rbnX.Hide();
            //rbnY.Hide();
            //rbnZ.Hide();
            //lblTheta.Hide();
            //txtTheta.Hide();
            gpbRotacion.Hide();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Vector3 V1;
            Vector3 V2;
            Vector3 VR;
            try
            {
                V1 = new Vector3(float.Parse(txtX.Text), float.Parse(txtY.Text), float.Parse(txtZ.Text));
                if(cmbOp.SelectedIndex<3)
                {
                    V2 = new Vector3(float.Parse(txtX2.Text), float.Parse(txtY2.Text), float.Parse(txtZ2.Text));
                    if (cmbOp.SelectedIndex == 0)
                    {
                        VR = Vector3.Add(V1, V2);
                        txtResultado.Text = VR.ToString();
                    }
                    if (cmbOp.SelectedIndex == 1)
                    {
                        VR = Vector3.Subtract(V1, V2);
                        txtResultado.Text = VR.ToString();
                    }
                    if (cmbOp.SelectedIndex == 2)
                    {
                        VR = Vector3.Multiply(V1, V2);
                        txtResultado.Text = VR.ToString();

                    }
                    
                }
                if(cmbOp.SelectedIndex==3)
                {
                    VR = Vector3.Normalize(V1);
                    txtResultado.Text = VR.ToString();
                }
                if(cmbOp.SelectedIndex==4) //Traslacion
                {
                    float tx = float.Parse(txtX2.Text);
                    float ty = float.Parse(txtY2.Text);
                    float tz = float.Parse(txtZ2.Text);
                    Vector3 tV = new Vector3(tx, ty, tz);
                    /*Matrix4x4 Traslacion = new Matrix4x4(1, 0, 0, tx, 0, 1, 0, ty, 0, 0, 1, tz, 0, 0, 0, 1);
                    VR = Vector3.Transform(V1, Traslacion);*/
                    VR = Vector3.Add(V1, tV);
                    txtResultado.Text = VR.ToString();
                }
                if(cmbOp.SelectedIndex==5) //Rotacion
                {
                    double theta=double.Parse(txtTheta.Text)*Math.PI/180;
                    float costh =  Convert.ToSingle(Math.Cos(theta));
                    float sinth = Convert.ToSingle(Math.Sin(theta));
                    float _sinth = Convert.ToSingle(Math.Sin(theta))*-1;
                    Matrix4x4 Rotacion;
                    if (rbnX.Checked)
                    {
                        Rotacion = new Matrix4x4(1, 0, 0, 0, 0, costh, _sinth, 0, 0, sinth, costh, 0, 0, 0, 0, 1);
                        VR = Vector3.Transform(V1, Rotacion);
                        txtResultado.Text = VR.ToString();
                    }
                    if (rbnY.Checked)
                    {
                        Rotacion = new Matrix4x4(costh, 0, sinth, 0, 0, 1, 0, 0, _sinth, 0, costh, 0, 0, 0, 0, 1);
                        VR = Vector3.Transform(V1, Rotacion);
                        txtResultado.Text = VR.ToString();
                    }
                    if (rbnZ.Checked)
                    {
                        Rotacion = new Matrix4x4(costh, _sinth, 0, 0, sinth, costh, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);
                        VR = Vector3.Transform(V1, Rotacion);
                        txtResultado.Text = VR.ToString();
                    }
                    
                }
                if(cmbOp.SelectedIndex==6)
                {
                    float sx = float.Parse(txtX2.Text);
                    float sy = float.Parse(txtY2.Text);
                    float sz = float.Parse(txtZ2.Text);
                    Matrix4x4 Escalamiento = new Matrix4x4(sx, 0, 0, 0, 0, sy, 0, 0, 0, 0, sz, 0, 0, 0, 0, 1);
                    VR = Vector3.Transform(V1, Escalamiento);
                    txtResultado.Text = VR.ToString();
                }
                if (cmbOp.SelectedIndex == 7)
                {
                    VR = Vector3.Multiply(float.Parse(txtY2.Text), V1);
                    txtResultado.Text = VR.ToString();
                }
                if(cmbOp.SelectedIndex==8)
                {
                    V2 = new Vector3(float.Parse(txtX2.Text), float.Parse(txtY2.Text), float.Parse(txtZ2.Text));
                    VR = Vector3.Cross(V1, V2);
                    txtResultado.Text = VR.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error en la captura del vector", "Error");
            }
        }

        private void cmbOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbOp.SelectedIndex==0)
            {
                gpbV2.Show();
                gpbRotacion.Hide();
                gpbV2.Text = "VectorB";
                lblTX.Text = "X2";
                lblTY.Text = "Y2";
                lblTZ.Text = "Z2";

            }
            else if (cmbOp.SelectedIndex == 1)
            {
                gpbV2.Show();
                gpbRotacion.Hide();
                gpbV2.Text = "VectorB";
                lblTX.Text = "X2";
                lblTY.Text = "Y2";
                lblTZ.Text = "Z2";
            }
            else if (cmbOp.SelectedIndex == 2)
            {
                gpbV2.Show();
                gpbRotacion.Hide();
                gpbV2.Text = "VectorB";
                lblTX.Text = "X2";
                lblTY.Text = "Y2";
                lblTZ.Text = "Z2";
            }
            else if (cmbOp.SelectedIndex == 3)
            {
                gpbV2.Hide();
            }
            else if(cmbOp.SelectedIndex==4)
            {
                gpbV2.Show();
                gpbRotacion.Hide();
                gpbV2.Text = "tx, ty, tz";
                lblTX.Text = "tx";
                lblTY.Text = "ty";
                lblTZ.Text = "tz";
            }
            else if(cmbOp.SelectedIndex==5)
            {

                gpbV2.Hide();
                gpbRotacion.Show();
            }
            else if(cmbOp.SelectedIndex==6)
            {
                gpbV2.Show();
                gpbRotacion.Hide();
                gpbV2.Text = "Sx, Sy, Sz";
                lblTX.Text = "Sx";
                lblTY.Text = "Ty";
                lblTZ.Text = "Tz";
            }
            if (cmbOp.SelectedIndex == 7)
            {
                lblTY.Hide();
                lblTZ.Hide();
                txtX2.Hide();
                txtZ2.Hide();
                lblTX.Text = "Escalar";
            }
            else
            {

                lblTY.Show();
                lblTZ.Show();
                txtX2.Show();
                txtZ2.Show();
               // lblTX.Text = "X2";
            }
            if (cmbOp.SelectedIndex == 8)
            {
                gpbV2.Show();
                gpbRotacion.Hide();
                gpbV2.Text = "VectorB";
                lblTX.Text = "X2";
                lblTY.Text = "Y2";
                lblTZ.Text = "Z2";
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
            Vectores vectores = new Vectores();
            vectores.Show();
            this.Hide();
        }
    }
}
