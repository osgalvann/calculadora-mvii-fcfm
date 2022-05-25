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
    public partial class Matrices : Form
    {
        private TextBox[,] txbA;
        private TextBox[,] txbB;
        private TextBox[,] MatrizResultante;
        private void btnOkA_Click(object sender, EventArgs e)
        {
            gpbMatrizA.Controls.Clear();
            txbA = new TextBox[Convert.ToInt32(nudFilas.Value), Convert.ToInt32(nudColums.Value)];
            int txbSize = gpbMatrizA.Width / Convert.ToInt32(nudColums.Value);
            for (int x = 0; x < txbA.GetLength(0); x++)
            {
                for (int y = 0; y < txbA.GetLength(1); y++)
                {
                    txbA[x, y] = new TextBox();
                    txbA[x, y].Top = (x * txbA[x, y].Height) + 20;
                    txbA[x, y].Left = y * txbSize + 6;
                    txbA[x, y].Width = txbSize;
                    gpbMatrizA.Controls.Add(txbA[x, y]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gpbMatrizB.Controls.Clear();
            txbB = new TextBox[Convert.ToInt32(nudFilasB.Value), Convert.ToInt32(nudColumB.Value)];
            int txbSize = gpbMatrizB.Width / Convert.ToInt32(nudColumB.Value);
            for (int x = 0; x < txbB.GetLength(0); x++)
            {
                for (int y = 0; y < txbB.GetLength(1); y++)
                {
                    txbB[x, y] = new TextBox();
                    txbB[x, y].Top = (x * txbB[x, y].Height) + 20;
                    txbB[x, y].Left = y * txbSize + 6;
                    txbB[x, y].Width = txbSize;
                    gpbMatrizB.Controls.Add(txbB[x, y]);
                }
            }
        }

        public Matrices()
        {
            InitializeComponent();
        }

        private void Matrices_Load(object sender, EventArgs e)
        {
            nudColums.Value = 1;
            nudFilas.Value = 1;
            nudColumB.Value = 1;
            nudFilasB.Value = 1;
            btnCalcular.Enabled = false;
            lblOp.Hide();
            lblIgual.Hide();
        }

        private void nudFilas_ValueChanged(object sender, EventArgs e)
        {
            if (nudFilas.Value == 0)
                nudFilas.Value = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCalcular.Enabled = true;
            if (comboBox1.SelectedIndex == 0)
            {
                lblOp.Text = "+";
                lblOp.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                lblOp.Text = "-";
                lblOp.Show();
            }
            else if(comboBox1.SelectedIndex==2)
            {
                lblOp.Text = "x";
                lblOp.Show();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txbA == null || txbB == null)
            {
                MessageBox.Show("La matriz esta vacia", "Error");
                return;
            }
            if(comboBox1.SelectedIndex==0)
            {
                lbxLog.Items.Clear();
                float[,] tmpMatrizA = new float[txbA.GetLength(0), txbA.GetLength(1)];
                float[,] tmpMatrizB = new float[txbB.GetLength(0), txbB.GetLength(1)];
                if(tmpMatrizA.GetLength(0)!=tmpMatrizB.GetLength(0) || tmpMatrizA.GetLength(1)!=tmpMatrizB.GetLength(1))
                {
                    MessageBox.Show("Solo se pueden sumar matrices del mismo odrden", "Error");
                    return;
                }
                for (int x = 0; x < txbA.GetLength(0); x++)
                {
                    for (int y = 0; y < txbA.GetLength(1); y++)
                    {
                        float n = 0;
                        if (!float.TryParse(txbA[x, y].Text, out n) || txbA[x,y].Text=="")
                        {
                            MessageBox.Show("Error en captura de matriz", "Error");
                            return;
                        }
                        tmpMatrizA[x, y] = n;
                    }
                }
                for (int x = 0; x < txbB.GetLength(0); x++)
                {
                    for (int y = 0; y < txbB.GetLength(1); y++)
                    {
                        float n = 0;
                        if (!float.TryParse(txbB[x, y].Text, out n) || txbB[x, y].Text == "")
                        {
                            MessageBox.Show("Error en captura de matriz", "Error");
                            return;
                        }
                        tmpMatrizB[x, y] = n;
                    }
                }
                float[,] tmpMatrizResultante = CalculosMatrices.Suma(tmpMatrizA, tmpMatrizB);
                MatrizResultante = new TextBox[tmpMatrizResultante.GetLength(0), tmpMatrizResultante.GetLength(1)];
                int txbSize = gpbResultado.Width / MatrizResultante.GetLength(1);
                gpbResultado.Controls.Clear();
                int xm, ym;
                for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                {
                    xm = x + 1;
                    for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                    {
                        ym = y + 1;
                        lbxLog.Items.Add("A[" + xm.ToString() + ", " + ym.ToString() + "] + B["  + xm.ToString() + 
                            ", " + ym.ToString() + "] = " + tmpMatrizA[x, y].ToString() + " + " + tmpMatrizB[x, y].ToString() 
                            + " = " + tmpMatrizResultante[x, y]);
                        MatrizResultante[x, y] = new TextBox();
                        MatrizResultante[x, y].Text = tmpMatrizResultante[x, y].ToString();
                        MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                        MatrizResultante[x, y].Left = y * txbSize + 6;
                        MatrizResultante[x, y].Width = txbSize;
                        gpbResultado.Controls.Add(MatrizResultante[x, y]);
                    }
                }
                lblIgual.Show();
            }
            else if(comboBox1.Text=="Resta")
            {
                float[,] tmpMatrizA = new float[txbA.GetLength(0), txbA.GetLength(1)];
                float[,] tmpMatrizB = new float[txbB.GetLength(0), txbB.GetLength(1)];
                if (tmpMatrizA.GetLength(0) != tmpMatrizB.GetLength(0) || tmpMatrizA.GetLength(1) != tmpMatrizB.GetLength(1))
                {
                    MessageBox.Show("Solo se pueden sumar matrices del mismo odrden", "Error");
                    return;
                }
                for (int x = 0; x < txbA.GetLength(0); x++)
                {
                    for (int y = 0; y < txbA.GetLength(1); y++)
                    {
                        float n = 0;
                        if (!float.TryParse(txbA[x, y].Text, out n) || txbA[x, y].Text == "")
                        {
                            MessageBox.Show("Error en captura de matriz", "Error");
                            return;
                        }
                        tmpMatrizA[x, y] = n;
                    }
                }
                for (int x = 0; x < txbB.GetLength(0); x++)
                {
                    for (int y = 0; y < txbB.GetLength(1); y++)
                    {
                        float n = 0;
                        if (!float.TryParse(txbB[x, y].Text, out n) || txbB[x, y].Text == "")
                        {
                            MessageBox.Show("Error en captura de matriz", "Error");
                            return;
                        }
                        tmpMatrizB[x, y] = n;
                    }
                }
                float[,] tmpMatrizResultante = CalculosMatrices.Resta(tmpMatrizA, tmpMatrizB);
                MatrizResultante = new TextBox[tmpMatrizResultante.GetLength(0), tmpMatrizResultante.GetLength(1)];
                int txbSize = gpbResultado.Width / MatrizResultante.GetLength(1);
                gpbResultado.Controls.Clear();
                int xm, ym;
                for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                {
                    xm = x + 1;
                    for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                    {
                        ym = y + 1;
                        lbxLog.Items.Add("A[" + xm.ToString() + ", " + ym.ToString() + "] - B[" + xm.ToString() +
                            ", " + ym.ToString() + "] = " + tmpMatrizA[x, y].ToString() + " - " + tmpMatrizB[x, y].ToString()
                            + " = " + tmpMatrizResultante[x, y]);
                        MatrizResultante[x, y] = new TextBox();
                        MatrizResultante[x, y].Text = tmpMatrizResultante[x, y].ToString();
                        MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                        MatrizResultante[x, y].Left = y * txbSize + 6;
                        MatrizResultante[x, y].Width = txbSize;
                        gpbResultado.Controls.Add(MatrizResultante[x, y]);
                    }
                }
                lblIgual.Show();
            }
            else if(comboBox1.Text=="Multiplicacion")
            {
                lbxLog.Items.Clear();
                float[,] tmpMatrizA = new float[txbA.GetLength(0), txbA.GetLength(1)];
                float[,] tmpMatrizB = new float[txbB.GetLength(0), txbB.GetLength(1)];
                if (tmpMatrizA.GetLength(1) != tmpMatrizB.GetLength(0))
                {
                    MessageBox.Show("Para multiplicar el numero de columnas de la matriz A debe ser igual al numero de filas de la matriz B", "Error");
                    return;
                }
                for (int x = 0; x < txbA.GetLength(0); x++)
                {
                    for (int y = 0; y < txbA.GetLength(1); y++)
                    {
                        float n = 0;
                        if (!float.TryParse(txbA[x, y].Text, out n) || txbA[x, y].Text == "")
                        {
                            MessageBox.Show("Error en captura de matriz", "Error");
                            return;
                        }
                        tmpMatrizA[x, y] = n;
                    }
                }
                for (int x = 0; x < txbB.GetLength(0); x++)
                {
                    for (int y = 0; y < txbB.GetLength(1); y++)
                    {
                        float n = 0;
                        if (!float.TryParse(txbB[x, y].Text, out n) || txbB[x, y].Text == "")
                        {
                            MessageBox.Show("Error en captura de matriz", "Error");
                            return;
                        }
                        tmpMatrizB[x, y] = n;
                    }
                }
                float[,] tmpMatrizResultante = CalculosMatrices.Multiplicacion(tmpMatrizA, tmpMatrizB, lbxLog);
                MatrizResultante = new TextBox[tmpMatrizResultante.GetLength(0), tmpMatrizResultante.GetLength(1)];
                int txbSize = gpbResultado.Width / MatrizResultante.GetLength(1);
                gpbResultado.Controls.Clear();
                for (int x = 0; x < MatrizResultante.GetLength(0); x++)
                {
                    for (int y = 0; y < MatrizResultante.GetLength(1); y++)
                    {
                        MatrizResultante[x, y] = new TextBox();
                        MatrizResultante[x, y].Text = tmpMatrizResultante[x, y].ToString();
                        MatrizResultante[x, y].Top = (x * MatrizResultante[x, y].Height) + 20;
                        MatrizResultante[x, y].Left = y * txbSize + 6;
                        MatrizResultante[x, y].Width = txbSize;
                        gpbResultado.Controls.Add(MatrizResultante[x, y]);
                    }
                }
                lblIgual.Show();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            nudColums.Value = 1;
            nudFilas.Value = 1;
            nudColumB.Value = 1;
            nudFilasB.Value = 1;
            gpbMatrizA.Controls.Clear();
            gpbMatrizB.Controls.Clear();
            gpbResultado.Controls.Clear();
            comboBox1.SelectedIndex = -1;
            btnCalcular.Enabled = false;
            lbxLog.Items.Clear();
            ckbTransA.Checked = false;
            ckbTrans2.Checked = false;
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

        private void nudColums_ValueChanged(object sender, EventArgs e)
        {
            if (nudColums.Value == 0)
                nudColums.Value = 1;
        }

        private void nudFilasB_ValueChanged(object sender, EventArgs e)
        {
            if (nudFilasB.Value == 0)
                nudFilasB.Value = 1;
        }

        private void nudColumB_ValueChanged(object sender, EventArgs e)
        {
            if (nudColumB.Value == 0)
                nudColumB.Value = 1;
        }

        private void ckbTransA_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTransA.Checked == true)
            {
                float[,] tempResultante = new float[txbA.GetLength(0), txbA.GetLength(1)];
                if (txbA == null)
                {
                    MessageBox.Show("Matriz Vacia", "Error");
                    return;
                }
                for (int x = 0; x < txbA.GetLength(0); x++)
                {
                    for (int y = 0; y < txbA.GetLength(1); y++)
                    {
                        float n = 0;
                        float.TryParse(txbA[x, y].Text, out n);
                        tempResultante[x, y] = n;
                    }
                }

                float[,] tempMatrizResultante = CalculosMatrices.Transpuesta(tempResultante);
                int TamanhoText = gpbMatrizA.Width / tempMatrizResultante.GetLength(1);
                txbA = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
                gpbMatrizA.Controls.Clear();
                for (int x = 0; x < txbA.GetLength(0); x++)
                {
                    for (int y = 0; y < txbA.GetLength(1); y++)
                    {
                        txbA[x, y] = new TextBox();
                        txbA[x, y].Text = tempMatrizResultante[x, y].ToString();
                        txbA[x, y].Top = (x * txbA[x, y].Height) + 20;
                        txbA[x, y].Left = y * TamanhoText + 6;
                        txbA[x, y].Width = TamanhoText;
                        gpbMatrizA.Controls.Add(txbA[x, y]);
                    }
                }
            }
            else
            {
                float[,] tempResultante = new float[txbA.GetLength(0), txbA.GetLength(1)];
                if (txbA == null)
                {
                    MessageBox.Show("Matriz Vacia", "Error");
                    return;
                }
                for (int x = 0; x < txbA.GetLength(0); x++)
                {
                    for (int y = 0; y < txbA.GetLength(1); y++)
                    {
                        float n = 0;
                        float.TryParse(txbA[x, y].Text, out n);
                        tempResultante[x, y] = n;
                    }
                }

                float[,] tempMatrizResultante = CalculosMatrices.Transpuesta(tempResultante);
                int TamanhoText = gpbMatrizA.Width / tempMatrizResultante.GetLength(1);
                txbA = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
                gpbMatrizA.Controls.Clear();
                for (int x = 0; x < txbA.GetLength(0); x++)
                {
                    for (int y = 0; y < txbA.GetLength(1); y++)
                    {
                        txbA[x, y] = new TextBox();
                        txbA[x, y].Text = tempMatrizResultante[x, y].ToString();
                        txbA[x, y].Top = (x * txbA[x, y].Height) + 20;
                        txbA[x, y].Left = y * TamanhoText + 6;
                        txbA[x, y].Width = TamanhoText;
                        gpbMatrizA.Controls.Add(txbA[x, y]);
                    }
                }
            }
        }

        private void ckbTrans2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTrans2.Checked == true)
            {
                if (txbB == null)
                {
                    MessageBox.Show("Matriz Vacia", "Error");
                    return;
                }
                float[,] tempResultante = new float[txbB.GetLength(0), txbB.GetLength(1)];

                for (int x = 0; x < txbB.GetLength(0); x++)
                {
                    for (int y = 0; y < txbB.GetLength(1); y++)
                    {
                        float n = 0;
                        float.TryParse(txbB[x, y].Text, out n);
                        tempResultante[x, y] = n;
                    }
                }

                float[,] tempMatrizResultante = CalculosMatrices.Transpuesta(tempResultante);
                int TamanhoText = gpbMatrizB.Width / tempMatrizResultante.GetLength(1);
                txbB = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
                gpbMatrizB.Controls.Clear();
                for (int x = 0; x < txbB.GetLength(0); x++)
                {
                    for (int y = 0; y < txbB.GetLength(1); y++)
                    {
                        txbB[x, y] = new TextBox();
                        txbB[x, y].Text = tempMatrizResultante[x, y].ToString();
                        txbB[x, y].Top = (x * txbB[x, y].Height) + 20;
                        txbB[x, y].Left = y * TamanhoText + 6;
                        txbB[x, y].Width = TamanhoText;
                        gpbMatrizB.Controls.Add(txbB[x, y]);
                    }
                }
            }
            else
            {
                if (txbB == null)
                {
                    MessageBox.Show("Matriz Vacia", "Error");
                    return;
                }
                float[,] tempResultante = new float[txbB.GetLength(0), txbB.GetLength(1)];

                for (int x = 0; x < txbB.GetLength(0); x++)
                {
                    for (int y = 0; y < txbB.GetLength(1); y++)
                    {
                        float n = 0;
                        float.TryParse(txbB[x, y].Text, out n);
                        tempResultante[x, y] = n;
                    }
                }

                float[,] tempMatrizResultante = CalculosMatrices.Transpuesta(tempResultante);
                int TamanhoText = gpbMatrizB.Width / tempMatrizResultante.GetLength(1);
                txbB = new TextBox[tempMatrizResultante.GetLength(0), tempMatrizResultante.GetLength(1)];
                gpbMatrizB.Controls.Clear();
                for (int x = 0; x < txbB.GetLength(0); x++)
                {
                    for (int y = 0; y < txbB.GetLength(1); y++)
                    {
                        txbB[x, y] = new TextBox();
                        txbB[x, y].Text = tempMatrizResultante[x, y].ToString();
                        txbB[x, y].Top = (x * txbB[x, y].Height) + 20;
                        txbB[x, y].Left = y * TamanhoText + 6;
                        txbB[x, y].Width = TamanhoText;
                        gpbMatrizB.Controls.Add(txbB[x, y]);
                    }
                }
            }
        }
    }
}
