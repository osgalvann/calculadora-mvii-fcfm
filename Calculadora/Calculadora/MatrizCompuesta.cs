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
    public partial class MatrizCompuesta : Form
    {
        private TextBox[,] txtTrans;
        private TextBox[,] MatrizResultante;
        private float[,] traslation;
        private float[,] scalation;
        private float[,] rotationX;
        private float[,] rotationY;
        private float[,] rotationZ;

        public MatrizCompuesta()
        {
            InitializeComponent();
        }

        private void MatrizCompuesta_Load(object sender, EventArgs e)
        {
            gpbParamTras.Hide();
            gpbParamEsc.Hide();
            gpbParamRota.Hide();

            gpbMatrizR.Controls.Clear();
            MatrizResultante = new TextBox[4, 4];
            int txbSize = gpbMatrizR.Width / 4;
            for (int x = 0; x < MatrizResultante.GetLength(0); x++)
            {
                for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                {
                    MatrizResultante[x, y] = new TextBox();
                    MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                    MatrizResultante[x, y].Left = y * txbSize + 6;
                    MatrizResultante[x, y].Width = txbSize;
                    MatrizResultante[x, y].Text = "0";
                    gpbMatrizR.Controls.Add(MatrizResultante[x, y]);
                }
            }
            MatrizResultante[0, 0].Text = "1";
            MatrizResultante[1, 1].Text = "1";
            MatrizResultante[2, 2].Text = "1";
            MatrizResultante[3, 3].Text = "1";
        }

        private void cmbOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOp.SelectedIndex == 0)
            {
                gpbParamTras.Show();
            }
            else
            {
                gpbParamTras.Hide();
            }

            if (cmbOp.SelectedIndex == 1)
            {
                gpbParamEsc.Show();
            }
            else
            {
                gpbParamEsc.Hide();
            }

            if (cmbOp.SelectedIndex == 2)
            {
                gpbParamRota.Show();
            }
            else if (cmbOp.SelectedIndex == 3)
            {
                gpbParamRota.Show();
            }
            else if (cmbOp.SelectedIndex == 4)
            {
                gpbParamRota.Show();
            }
            else
            {
                gpbParamRota.Hide();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenu mainM = new mainMenu();
            mainM.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            MatrizCompuesta matrizCompuesta = new MatrizCompuesta();
            matrizCompuesta.Show();
            this.Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (cmbOp.SelectedIndex == 0)
            {
                try
                {
                    float tx = float.Parse(txtTX.Text);
                    float ty = float.Parse(txtTY.Text);
                    float tz = float.Parse(txtTZ.Text);
                    traslation = new float[,]{ 
                        { 1, 0, 0, tx}, 
                        { 0, 1, 0, ty}, 
                        { 0, 0, 1, tz}, 
                        { 0, 0, 0, 1} };
                    txtTrans = new TextBox[traslation.GetLength(0), traslation.GetLength(1)];
                    int txbSize = gpbTransformacion.Width / txtTrans.GetLength(1);
                    gpbTransformacion.Controls.Clear();
                    for (int x = 0; x < txtTrans.GetLength(0); x++)
                    {
                        for (int y = 0; y < txtTrans.GetLength(1); y++)
                        {
                            txtTrans[x, y] = new TextBox();
                            txtTrans[x, y].Text = traslation[x, y].ToString();
                            txtTrans[x, y].Top = (x * txtTrans[x, y].Height) + 20;
                            txtTrans[x, y].Left = y * txbSize + 6;
                            txtTrans[x, y].Width = txbSize;
                            gpbTransformacion.Controls.Add(txtTrans[x, y]);
                        }
                    }

                    float[,] tmpMR = new float[MatrizResultante.GetLength(0), MatrizResultante.GetLength(1)];
                    for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                    {
                        for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                        {
                            float n = 0;
                            if (!float.TryParse(MatrizResultante[x, y].Text, out n) || MatrizResultante[x, y].Text == "")
                            {
                                MessageBox.Show("Error en captura de matriz", "Error");
                                return;
                            }
                            tmpMR[x, y] = n;
                        }
                    }

                    float[,] resultado = CalculosMatrices.Multiplicacion(traslation, tmpMR, lbxLog);
                    MatrizResultante = new TextBox[resultado.GetLength(0), resultado.GetLength(1)];
                    txbSize = gpbMatrizR.Width / MatrizResultante.GetLength(1);
                    gpbMatrizR.Controls.Clear();
                    for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                    {
                        for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                        {
                            MatrizResultante[x, y] = new TextBox();
                            MatrizResultante[x, y].Text = resultado[x, y].ToString();
                            MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                            MatrizResultante[x, y].Left = y * txbSize + 6;
                            MatrizResultante[x, y].Width = txbSize;
                            gpbMatrizR.Controls.Add(MatrizResultante[x, y]);
                        }
                    }
                    lbxTrans.Items.Add(cmbOp.Text + " | tx: " + txtTX.Text + " | ty: " + txtTY.Text + " | ty: " + txtTZ.Text + " |");
                }
                catch
                {
                    MessageBox.Show("Error en la captura de los parametros", "Error");
                    return;
                }
                

            }
            if (cmbOp.SelectedIndex == 1) //Escalacion
            {
                try
                {
                    float sx = float.Parse(txtSX.Text);
                    float sy = float.Parse(txtSY.Text);
                    float sz = float.Parse(txtSZ.Text);
                    scalation = new float[,]{
                        { sx, 0, 0, 0},
                        { 0, sy, 0, 0},
                        { 0, 0, sz, 0},
                        { 0, 0, 0 , 1} };
                    txtTrans = new TextBox[scalation.GetLength(0), scalation.GetLength(1)];
                    int txbSize = gpbTransformacion.Width / txtTrans.GetLength(1);
                    gpbTransformacion.Controls.Clear();
                    for (int x = 0; x < txtTrans.GetLength(0); x++)
                    {
                        for (int y = 0; y < txtTrans.GetLength(1); y++)
                        {
                            txtTrans[x, y] = new TextBox();
                            txtTrans[x, y].Text = scalation[x, y].ToString();
                            txtTrans[x, y].Top = (x * txtTrans[x, y].Height) + 30;
                            txtTrans[x, y].Left = y * txbSize + 6;
                            txtTrans[x, y].Width = txbSize;
                            gpbTransformacion.Controls.Add(txtTrans[x, y]);
                        }
                    }

                    float[,] tmpMR = new float[MatrizResultante.GetLength(0), MatrizResultante.GetLength(1)];
                    for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                    {
                        for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                        {
                            float n = 0;
                            if (!float.TryParse(MatrizResultante[x, y].Text, out n) || MatrizResultante[x, y].Text == "")
                            {
                                MessageBox.Show("Error en captura de matriz", "Error");
                                return;
                            }
                            tmpMR[x, y] = n;
                        }
                    }

                    float[,] resultado = CalculosMatrices.Multiplicacion(scalation, tmpMR, lbxLog);
                    MatrizResultante = new TextBox[resultado.GetLength(0), resultado.GetLength(1)];
                    txbSize = gpbMatrizR.Width / MatrizResultante.GetLength(1);
                    gpbMatrizR.Controls.Clear();
                    for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                    {
                        for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                        {
                            MatrizResultante[x, y] = new TextBox();
                            MatrizResultante[x, y].Text = resultado[x, y].ToString();
                            MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                            MatrizResultante[x, y].Left = y * txbSize + 6;
                            MatrizResultante[x, y].Width = txbSize;
                            gpbMatrizR.Controls.Add(MatrizResultante[x, y]);
                        }
                    }
                    lbxTrans.Items.Add(cmbOp.Text + " | sx: " + txtSX.Text + " | sy: " + txtSY.Text + " | sz: " + txtSZ.Text + " |");
                }
                catch
                {
                    MessageBox.Show("Error en la captura de parametros", "Error");
                }
            }
            if (cmbOp.SelectedIndex == 2) //Rotacion X
            {
                try
                {
                    double theta = double.Parse(txtTheta.Text) * Math.PI / 180;
                    float costh = Convert.ToSingle(Math.Cos(theta));
                    float sinth = Convert.ToSingle(Math.Sin(theta));
                    float _sinth = Convert.ToSingle(Math.Sin(theta)) * -1;
                    rotationX = new float[,]{
                        { 1, 0, 0, 0},
                        { 0, costh, _sinth, 0},
                        { 0, sinth, costh, 0},
                        { 0, 0, 0, 1} };
                    txtTrans = new TextBox[rotationX.GetLength(0), rotationX.GetLength(1)];
                    int txbSize = gpbTransformacion.Width / txtTrans.GetLength(1);
                    gpbTransformacion.Controls.Clear();
                    for (int x = 0; x < txtTrans.GetLength(0); x++)
                    {
                        for (int y = 0; y < txtTrans.GetLength(1); y++)
                        {
                            txtTrans[x, y] = new TextBox();
                            txtTrans[x, y].Text = rotationX[x, y].ToString();
                            txtTrans[x, y].Top = (x * txtTrans[x, y].Height) + 20;
                            txtTrans[x, y].Left = y * txbSize + 6;
                            txtTrans[x, y].Width = txbSize;
                            gpbTransformacion.Controls.Add(txtTrans[x, y]);
                        }
                    }

                    float[,] tmpMR = new float[MatrizResultante.GetLength(0), MatrizResultante.GetLength(1)];
                    for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                    {
                        for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                        {
                            float n = 0;
                            if (!float.TryParse(MatrizResultante[x, y].Text, out n) || MatrizResultante[x, y].Text == "")
                            {
                                MessageBox.Show("Error en captura de matriz", "Error");
                                return;
                            }
                            tmpMR[x, y] = n;
                        }
                    }

                    float[,] resultado = CalculosMatrices.Multiplicacion(rotationX, tmpMR, lbxLog);
                    MatrizResultante = new TextBox[resultado.GetLength(0), resultado.GetLength(1)];
                    txbSize = gpbMatrizR.Width / MatrizResultante.GetLength(1);
                    gpbMatrizR.Controls.Clear();
                    for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                    {
                        for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                        {
                            MatrizResultante[x, y] = new TextBox();
                            MatrizResultante[x, y].Text = resultado[x, y].ToString();
                            MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                            MatrizResultante[x, y].Left = y * txbSize + 6;
                            MatrizResultante[x, y].Width = txbSize;
                            gpbMatrizR.Controls.Add(MatrizResultante[x, y]);
                        }
                    }
                    lbxTrans.Items.Add(cmbOp.Text + " | Angulo: " + txtTheta.Text + " grados |");
                }
                catch
                {
                    MessageBox.Show("Error en la captura de parametros", "Error");
                }
            }
            if(cmbOp.SelectedIndex==3) //RotacionY
            {
                try
                {
                    double theta = double.Parse(txtTheta.Text) * Math.PI / 180;
                    float costh = Convert.ToSingle(Math.Cos(theta));
                    float sinth = Convert.ToSingle(Math.Sin(theta));
                    float _sinth = Convert.ToSingle(Math.Sin(theta)) * -1;
                    rotationY = new float[,]{
                        { costh, 0, sinth, 0},
                        {0, 1, 0, 0},
                        { _sinth, 0, costh, 0},
                        {0, 0, 0, 1} };
                    txtTrans = new TextBox[rotationY.GetLength(0), rotationY.GetLength(1)];
                    int txbSize = gpbTransformacion.Width / txtTrans.GetLength(1);
                    gpbTransformacion.Controls.Clear();
                    for (int x = 0; x < txtTrans.GetLength(0); x++)
                    {
                        for (int y = 0; y < txtTrans.GetLength(1); y++)
                        {
                            txtTrans[x, y] = new TextBox();
                            txtTrans[x, y].Text = rotationY[x, y].ToString();
                            txtTrans[x, y].Top = (x * txtTrans[x, y].Height) + 20;
                            txtTrans[x, y].Left = y * txbSize + 6;
                            txtTrans[x, y].Width = txbSize;
                            gpbTransformacion.Controls.Add(txtTrans[x, y]);
                        }
                    }

                    float[,] tmpMR = new float[MatrizResultante.GetLength(0), MatrizResultante.GetLength(1)];
                    for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                    {
                        for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                        {
                            float n = 0;
                            if (!float.TryParse(MatrizResultante[x, y].Text, out n) || MatrizResultante[x, y].Text == "")
                            {
                                MessageBox.Show("Error en captura de matriz", "Error");
                                return;
                            }
                            tmpMR[x, y] = n;
                        }
                    }

                    float[,] resultado = CalculosMatrices.Multiplicacion(rotationY, tmpMR, lbxLog);
                    MatrizResultante = new TextBox[resultado.GetLength(0), resultado.GetLength(1)];
                    txbSize = gpbMatrizR.Width / MatrizResultante.GetLength(1);
                    gpbMatrizR.Controls.Clear();
                    for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                    {
                        for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                        {
                            MatrizResultante[x, y] = new TextBox();
                            MatrizResultante[x, y].Text = resultado[x, y].ToString();
                            MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                            MatrizResultante[x, y].Left = y * txbSize + 6;
                            MatrizResultante[x, y].Width = txbSize;
                            gpbMatrizR.Controls.Add(MatrizResultante[x, y]);
                        }
                    }
                    lbxTrans.Items.Add(cmbOp.Text + " | Angulo: " + txtTheta.Text + " grados |");
                }
                catch
                {
                    MessageBox.Show("Error en la captura de parametros", "Error");
                }
            }
            if(cmbOp.SelectedIndex==4)
            {
                try
                {
                    double theta = double.Parse(txtTheta.Text) * Math.PI / 180;
                    float costh = Convert.ToSingle(Math.Cos(theta));
                    float sinth = Convert.ToSingle(Math.Sin(theta));
                    float _sinth = Convert.ToSingle(Math.Sin(theta)) * -1;
                    rotationZ = new float[,]{
                        { costh, _sinth, 0, 0},
                        {sinth, costh, 0, 0},
                        { 0, 0, 1, 0},
                        {0, 0, 0, 1} };
                    txtTrans = new TextBox[rotationZ.GetLength(0), rotationZ.GetLength(1)];
                    int txbSize = gpbTransformacion.Width / txtTrans.GetLength(1);
                    gpbTransformacion.Controls.Clear();
                    for (int x = 0; x < txtTrans.GetLength(0); x++)
                    {
                        for (int y = 0; y < txtTrans.GetLength(1); y++)
                        {
                            txtTrans[x, y] = new TextBox();
                            txtTrans[x, y].Text = rotationZ[x, y].ToString();
                            txtTrans[x, y].Top = (x * txtTrans[x, y].Height) + 20;
                            txtTrans[x, y].Left = y * txbSize + 6;
                            txtTrans[x, y].Width = txbSize;
                            gpbTransformacion.Controls.Add(txtTrans[x, y]);
                        }
                    }

                    float[,] tmpMR = new float[MatrizResultante.GetLength(0), MatrizResultante.GetLength(1)];
                    for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                    {
                        for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                        {
                            float n = 0;
                            if (!float.TryParse(MatrizResultante[x, y].Text, out n) || MatrizResultante[x, y].Text == "")
                            {
                                MessageBox.Show("Error en captura de matriz", "Error");
                                return;
                            }
                            tmpMR[x, y] = n;
                        }
                    }

                    float[,] resultado = CalculosMatrices.Multiplicacion(rotationZ, tmpMR, lbxLog);
                    MatrizResultante = new TextBox[resultado.GetLength(0), resultado.GetLength(1)];
                    txbSize = gpbMatrizR.Width / MatrizResultante.GetLength(1);
                    gpbMatrizR.Controls.Clear();
                    for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                    {
                        for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                        {
                            MatrizResultante[x, y] = new TextBox();
                            MatrizResultante[x, y].Text = resultado[x, y].ToString();
                            MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                            MatrizResultante[x, y].Left = y * txbSize + 6;
                            MatrizResultante[x, y].Width = txbSize;
                            gpbMatrizR.Controls.Add(MatrizResultante[x, y]);
                        }
                    }
                    lbxTrans.Items.Add(cmbOp.Text + " | Angulo: " + txtTheta.Text + " grados |");
                }
                catch
                {
                    MessageBox.Show("Error en la captura de parametros", "Error");
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float[,] vector = { { float.Parse(txtX.Text) }
                                  , { float.Parse(txtY.Text) }
                                  ,{float.Parse(txtZ.Text) } 
                                  ,{1 } };
                float[,] tmpMR = new float[MatrizResultante.GetLength(0), MatrizResultante.GetLength(1)];
                for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                {
                    for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                    {
                        float n = 0;
                        if (!float.TryParse(MatrizResultante[x, y].Text, out n) || MatrizResultante[x, y].Text == "")
                        {
                            MessageBox.Show("Error en captura de matriz", "Error");
                            return;
                        }
                        tmpMR[x, y] = n;
                    }
                }
                float[,] resultado = CalculosMatrices.Multiplicacion(tmpMR, vector, lbxLog);
                txtResultado.Text = "<" + resultado[0, 0].ToString() + ", " + resultado[1, 0].ToString() + ", " + resultado[2, 0] + ">";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace + ex.TargetSite, ex.Source);
            }
        }
    }
}
