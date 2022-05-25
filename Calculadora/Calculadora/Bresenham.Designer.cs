namespace Calculadora
{
    partial class Bresenham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbOp = new System.Windows.Forms.ComboBox();
            this.lblOp = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gpbRecta = new System.Windows.Forms.GroupBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxPuntos = new System.Windows.Forms.ListBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.gpbCircunferencia = new System.Windows.Forms.GroupBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gpbElipse = new System.Windows.Forms.GroupBox();
            this.txtRy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbRecta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.gpbCircunferencia.SuspendLayout();
            this.gpbElipse.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(358, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // cmbOp
            // 
            this.cmbOp.FormattingEnabled = true;
            this.cmbOp.Items.AddRange(new object[] {
            "Linea Recta",
            "Circunferencia",
            "Elipse"});
            this.cmbOp.Location = new System.Drawing.Point(121, 34);
            this.cmbOp.Name = "cmbOp";
            this.cmbOp.Size = new System.Drawing.Size(212, 29);
            this.cmbOp.TabIndex = 1;
            this.cmbOp.SelectedIndexChanged += new System.EventHandler(this.cmbOp_SelectedIndexChanged);
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(26, 34);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(89, 25);
            this.lblOp.TabIndex = 2;
            this.lblOp.Text = "Opcion: ";
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(60, 60);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(39, 29);
            this.txtX1.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatAppearance.BorderSize = 2;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Location = new System.Drawing.Point(31, 385);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 39);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gpbRecta
            // 
            this.gpbRecta.Controls.Add(this.txtY2);
            this.gpbRecta.Controls.Add(this.label5);
            this.gpbRecta.Controls.Add(this.label6);
            this.gpbRecta.Controls.Add(this.txtX2);
            this.gpbRecta.Controls.Add(this.txtY1);
            this.gpbRecta.Controls.Add(this.label4);
            this.gpbRecta.Controls.Add(this.label3);
            this.gpbRecta.Controls.Add(this.label2);
            this.gpbRecta.Controls.Add(this.txtX1);
            this.gpbRecta.Controls.Add(this.label1);
            this.gpbRecta.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbRecta.Location = new System.Drawing.Point(31, 117);
            this.gpbRecta.Name = "gpbRecta";
            this.gpbRecta.Size = new System.Drawing.Size(302, 224);
            this.gpbRecta.TabIndex = 16;
            this.gpbRecta.TabStop = false;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(156, 158);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(39, 29);
            this.txtY2.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Y2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "X2";
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(60, 158);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(39, 29);
            this.txtX2.TabIndex = 21;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(156, 60);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(39, 29);
            this.txtY1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Punto Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Punto Inicial";
            // 
            // lbxPuntos
            // 
            this.lbxPuntos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lbxPuntos.ForeColor = System.Drawing.SystemColors.Control;
            this.lbxPuntos.FormattingEnabled = true;
            this.lbxPuntos.ItemHeight = 21;
            this.lbxPuntos.Location = new System.Drawing.Point(718, 34);
            this.lbxPuntos.Name = "lbxPuntos";
            this.lbxPuntos.Size = new System.Drawing.Size(186, 319);
            this.lbxPuntos.TabIndex = 17;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(471, 358);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 18;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // gpbCircunferencia
            // 
            this.gpbCircunferencia.Controls.Add(this.txtRadio);
            this.gpbCircunferencia.Controls.Add(this.label12);
            this.gpbCircunferencia.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbCircunferencia.Location = new System.Drawing.Point(31, 117);
            this.gpbCircunferencia.Name = "gpbCircunferencia";
            this.gpbCircunferencia.Size = new System.Drawing.Size(302, 224);
            this.gpbCircunferencia.TabIndex = 25;
            this.gpbCircunferencia.TabStop = false;
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(156, 96);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(39, 29);
            this.txtRadio.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(97, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 21);
            this.label12.TabIndex = 17;
            this.label12.Text = "Radio";
            // 
            // gpbElipse
            // 
            this.gpbElipse.Controls.Add(this.txtRy);
            this.gpbElipse.Controls.Add(this.label8);
            this.gpbElipse.Controls.Add(this.txtRx);
            this.gpbElipse.Controls.Add(this.label7);
            this.gpbElipse.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbElipse.Location = new System.Drawing.Point(31, 117);
            this.gpbElipse.Name = "gpbElipse";
            this.gpbElipse.Size = new System.Drawing.Size(302, 224);
            this.gpbElipse.TabIndex = 26;
            this.gpbElipse.TabStop = false;
            // 
            // txtRy
            // 
            this.txtRy.Location = new System.Drawing.Point(131, 148);
            this.txtRy.Name = "txtRy";
            this.txtRy.Size = new System.Drawing.Size(39, 29);
            this.txtRy.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ry";
            // 
            // txtRx
            // 
            this.txtRx.Location = new System.Drawing.Point(131, 71);
            this.txtRx.Name = "txtRx";
            this.txtRx.Size = new System.Drawing.Size(39, 29);
            this.txtRx.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Rx";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(831, 387);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 37);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 2;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenu.Location = new System.Drawing.Point(718, 387);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(97, 37);
            this.btnMenu.TabIndex = 28;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Location = new System.Drawing.Point(605, 387);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 37);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Bresenham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(949, 439);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gpbElipse);
            this.Controls.Add(this.gpbCircunferencia);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lbxPuntos);
            this.Controls.Add(this.gpbRecta);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.cmbOp);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Bresenham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatrizCompuesta";
            this.Load += new System.EventHandler(this.Bresenham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbRecta.ResumeLayout(false);
            this.gpbRecta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.gpbCircunferencia.ResumeLayout(false);
            this.gpbCircunferencia.PerformLayout();
            this.gpbElipse.ResumeLayout(false);
            this.gpbElipse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbOp;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gpbRecta;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxPuntos;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox gpbCircunferencia;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gpbElipse;
        private System.Windows.Forms.TextBox txtRy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnLimpiar;
    }
}