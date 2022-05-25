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
    public partial class Bresenham : Form
    {
        Image imgOriginal;
        Bitmap bitmap;
        public Bresenham()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lbxPuntos.Items.Clear();
            try
            {
                if (cmbOp.SelectedIndex == 0)
                {
                    Point pIni = new Point(int.Parse(txtX1.Text), int.Parse(txtY1.Text));
                    Point pFin = new Point(int.Parse(txtX2.Text), int.Parse(txtY2.Text));
                    DrawLine(pIni, pFin);
                }
                if (cmbOp.SelectedIndex == 1)
                {
                    
                    double r, Xk, Yk, P0, Pk;
                    r = double.Parse(txtRadio.Text);
                    bitmap = new Bitmap(Convert.ToInt32(r)+1,Convert.ToInt32(r)+1);
                    
                    if (r % 1 == 0)
                    {
                        P0 = 1 - r;
                    }
                    else
                    {
                        P0 = (5 / 4) - r;
                    }
                    Pk = P0;
                    Xk = 0;
                    Yk = r;
                    while (Xk < Yk)
                    {
                        if (Pk < 0)
                        {
                            Xk++;
                            Pk = Pk + (2 * (Xk) + 1);
                            lbxPuntos.Items.Add("("+(Xk).ToString() + ", " + (Yk).ToString()+")");
                            bitmap.SetPixel(Convert.ToInt32(Xk), Convert.ToInt32(Yk), Color.White);
                        }
                        else
                        {
                            Xk++;
                            Yk = Yk - 1;
                            Pk = Pk + (2 * (Xk) + 1) - (2 * (Yk));
                            lbxPuntos.Items.Add("(" + (Xk).ToString() + ", " + (Yk).ToString() + ")");
                            bitmap.SetPixel(Convert.ToInt32(Xk), Convert.ToInt32(Yk), Color.White);
                        }
                    }
                    pictureBox1.Image = bitmap;
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                if(cmbOp.SelectedIndex==2)
                {
                    double Rx, Ry, PkX, PkY, P1, P2;
                    Rx = double.Parse(txtRx.Text);
                    Ry = double.Parse(txtRy.Text);
                    bitmap = new Bitmap(Convert.ToInt32(Rx) + 1, Convert.ToInt32(Ry) + 1);
                    PkX = 0;
                    PkY = Ry;
                    lbxPuntos.Items.Add("Parte 1");
                    P1 = (Ry * Ry) - ((Rx * Rx) * Ry) + (0.25 * (Rx * Rx));
                    while ((2 * (Ry * Ry) * PkX) < (2 * (Rx * Rx) * PkY))
                    {
                        if (P1 < 0)
                        {
                            PkX++;
                            P1 = P1 + ((2 * (Ry * Ry) * PkX) + (Ry * Ry));
                            //MessageBox.Show((PkX).ToString() + " , " + (PkY).ToString());
                            lbxPuntos.Items.Add("(" + PkX.ToString() + ", " + PkY.ToString() + ")");
                            bitmap.SetPixel(Convert.ToInt32(PkX), Convert.ToInt32(PkY), Color.White);
                        }
                        else
                        {
                            PkX++;
                            PkY = PkY - 1;
                            P1 = P1 + ((2 * (Ry * Ry) * PkX)) - (((2*(Rx*Rx)*PkY)) + (2*(Ry * Ry)));
                            lbxPuntos.Items.Add("(" + PkX.ToString() + ", " + PkY.ToString() + ")");
                            bitmap.SetPixel(Convert.ToInt32(PkX), Convert.ToInt32(PkY), Color.White);
                        }
                    }
                    lbxPuntos.Items.Add("Parte 2");
                    P2 = (((Ry * Ry) * ((PkX + 0.5) * (PkX + 0.5))) + ((Rx * Rx) * ((PkY - 1) * (PkY - 1))) - ((Rx * Rx) * (Ry * Ry)));
                    while (PkY != 0)
                    {
                        
                        if (P2 > 0)
                        {
                            PkY--;
                            P2 = P2 - ((2 * (Rx * Rx) * PkY) - (2 * (Rx * Rx))) + (Rx * Rx);
                            lbxPuntos.Items.Add("(" + PkX.ToString() + ", " + PkY.ToString() + ")");
                            bitmap.SetPixel(Convert.ToInt32(PkX), Convert.ToInt32(PkY), Color.White);
                        }
                        else
                        {
                            PkX++;
                            PkY--;
                            P2 = P2 + ((2 * (Ry * Ry) * PkX) + (2 * (Ry * Ry))) - ((2 * (Rx * Rx) * PkY) - (2 * (Rx * Rx))) + (Rx * Rx);
                            lbxPuntos.Items.Add("(" + PkX.ToString() + ", " + PkY.ToString() + ")");
                            bitmap.SetPixel(Convert.ToInt32(PkX), Convert.ToInt32(PkY), Color.White);
                        }
                    }
                    pictureBox1.Image = bitmap;
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace+ex.TargetSite, ex.Source);
            }
        }

        private void DrawLine(Point from, Point to)
        {
            
            bitmap = new Bitmap(to.X+1,to.Y+1);
            
            double deltaX = to.X - from.X;
            double deltaY = to.Y - from.Y;
            double m = Math.Abs(deltaY / deltaX);
            double E = m - 0.5;
            int y = from.Y;
            for(int x = from.X; x <= to.X; x++)
            {
                bitmap.SetPixel(x, y, Color.White);
                lbxPuntos.Items.Add("(" + x.ToString() + ", " + y.ToString() + ")");
                E += m;
                if (E >= 0.5)
                {
                    y += 1;
                    E -= 1.0;
                }
            }
            
            pictureBox1.Image = bitmap;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            imgOriginal = pictureBox1.Image;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(30,18);
            e.Graphics.ScaleTransform(1, -1);
        }

        Image Zoom(Image img, Size size)
        {
            
            Bitmap bmp = new Bitmap(img, img.Width * size.Width, img.Height * size.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            return bmp;
        }

        private void Bresenham_Load(object sender, EventArgs e)
        {
            gpbCircunferencia.Hide();
            gpbRecta.Hide();
            gpbElipse.Hide();
            trackBar1.Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                imgOriginal = pictureBox1.Image;
                if (trackBar1.Value > 0)
                {
                    pictureBox1.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                }
            }
            catch
            {
                return;
            }
        }

        private void cmbOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOp.SelectedIndex == 0)
            {
                gpbRecta.Show();
                trackBar1.Show();
            }
            else
            {
                gpbRecta.Hide();
                trackBar1.Hide();
            }

            if (cmbOp.SelectedIndex == 1)
            {
                gpbCircunferencia.Show();
            }
            else
            {
                gpbCircunferencia.Hide();
            }

            if (cmbOp.SelectedIndex == 2)
            {
                gpbElipse.Show();
            }
            else
            {
                gpbElipse.Hide();
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
            Bresenham bresenham = new Bresenham();
            bresenham.Show();
            this.Close();
        }
    }
}
