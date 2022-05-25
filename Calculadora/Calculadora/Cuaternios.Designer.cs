namespace Calculadora
{
    partial class Cuaternios
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
            this.cmbOp = new System.Windows.Forms.ComboBox();
            this.lblOp = new System.Windows.Forms.Label();
            this.gpbQ1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtI = new System.Windows.Forms.TextBox();
            this.txtEscalar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbQ2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtK2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtJ2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtI2 = new System.Windows.Forms.TextBox();
            this.txtEscalar2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gpbQ1.SuspendLayout();
            this.gpbQ2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbOp
            // 
            this.cmbOp.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOp.FormattingEnabled = true;
            this.cmbOp.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Producto",
            "Producto de Grassman",
            "Normalizacion"});
            this.cmbOp.Location = new System.Drawing.Point(144, 24);
            this.cmbOp.Name = "cmbOp";
            this.cmbOp.Size = new System.Drawing.Size(146, 28);
            this.cmbOp.TabIndex = 0;
            this.cmbOp.SelectedIndexChanged += new System.EventHandler(this.cmbOp_SelectedIndexChanged);
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(37, 25);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(89, 21);
            this.lblOp.TabIndex = 1;
            this.lblOp.Text = "Operacion";
            // 
            // gpbQ1
            // 
            this.gpbQ1.Controls.Add(this.label5);
            this.gpbQ1.Controls.Add(this.txtK);
            this.gpbQ1.Controls.Add(this.label4);
            this.gpbQ1.Controls.Add(this.txtJ);
            this.gpbQ1.Controls.Add(this.label3);
            this.gpbQ1.Controls.Add(this.label2);
            this.gpbQ1.Controls.Add(this.txtI);
            this.gpbQ1.Controls.Add(this.txtEscalar);
            this.gpbQ1.Controls.Add(this.label1);
            this.gpbQ1.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbQ1.Location = new System.Drawing.Point(41, 82);
            this.gpbQ1.Name = "gpbQ1";
            this.gpbQ1.Size = new System.Drawing.Size(316, 100);
            this.gpbQ1.TabIndex = 2;
            this.gpbQ1.TabStop = false;
            this.gpbQ1.Text = "Cuaternio 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "k";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(252, 44);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(33, 27);
            this.txtK.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "j +";
            // 
            // txtJ
            // 
            this.txtJ.Location = new System.Drawing.Point(182, 44);
            this.txtJ.Name = "txtJ";
            this.txtJ.Size = new System.Drawing.Size(33, 27);
            this.txtJ.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "i +";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "+";
            // 
            // txtI
            // 
            this.txtI.Location = new System.Drawing.Point(115, 44);
            this.txtI.Name = "txtI";
            this.txtI.Size = new System.Drawing.Size(33, 27);
            this.txtI.TabIndex = 6;
            // 
            // txtEscalar
            // 
            this.txtEscalar.Location = new System.Drawing.Point(52, 44);
            this.txtEscalar.Name = "txtEscalar";
            this.txtEscalar.Size = new System.Drawing.Size(33, 27);
            this.txtEscalar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "q1 = ";
            // 
            // gpbQ2
            // 
            this.gpbQ2.Controls.Add(this.label6);
            this.gpbQ2.Controls.Add(this.txtK2);
            this.gpbQ2.Controls.Add(this.label7);
            this.gpbQ2.Controls.Add(this.txtJ2);
            this.gpbQ2.Controls.Add(this.label8);
            this.gpbQ2.Controls.Add(this.label9);
            this.gpbQ2.Controls.Add(this.txtI2);
            this.gpbQ2.Controls.Add(this.txtEscalar2);
            this.gpbQ2.Controls.Add(this.label10);
            this.gpbQ2.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbQ2.Location = new System.Drawing.Point(429, 82);
            this.gpbQ2.Name = "gpbQ2";
            this.gpbQ2.Size = new System.Drawing.Size(316, 100);
            this.gpbQ2.TabIndex = 13;
            this.gpbQ2.TabStop = false;
            this.gpbQ2.Text = "Cuaternio 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(287, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "k";
            // 
            // txtK2
            // 
            this.txtK2.Location = new System.Drawing.Point(252, 44);
            this.txtK2.Name = "txtK2";
            this.txtK2.Size = new System.Drawing.Size(33, 27);
            this.txtK2.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(218, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "j +";
            // 
            // txtJ2
            // 
            this.txtJ2.Location = new System.Drawing.Point(182, 44);
            this.txtJ2.Name = "txtJ2";
            this.txtJ2.Size = new System.Drawing.Size(33, 27);
            this.txtJ2.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(148, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "i +";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "+";
            // 
            // txtI2
            // 
            this.txtI2.Location = new System.Drawing.Point(115, 44);
            this.txtI2.Name = "txtI2";
            this.txtI2.Size = new System.Drawing.Size(33, 27);
            this.txtI2.TabIndex = 6;
            // 
            // txtEscalar2
            // 
            this.txtEscalar2.Location = new System.Drawing.Point(52, 44);
            this.txtEscalar2.Name = "txtEscalar2";
            this.txtEscalar2.Size = new System.Drawing.Size(33, 27);
            this.txtEscalar2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "q1 = ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatAppearance.BorderSize = 2;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Location = new System.Drawing.Point(41, 209);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 39);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(15, 468);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 39);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(223, 217);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(522, 27);
            this.txtResultado.TabIndex = 13;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 2;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenu.Location = new System.Drawing.Point(146, 468);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(119, 39);
            this.btnMenu.TabIndex = 16;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Location = new System.Drawing.Point(703, 468);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(6);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 39);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Cuaternios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(837, 522);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpbQ2);
            this.Controls.Add(this.gpbQ1);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.cmbOp);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cuaternios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuaternios";
            this.Load += new System.EventHandler(this.Cuaternios_Load);
            this.gpbQ1.ResumeLayout(false);
            this.gpbQ1.PerformLayout();
            this.gpbQ2.ResumeLayout(false);
            this.gpbQ2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOp;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.GroupBox gpbQ1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.TextBox txtEscalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbQ2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtK2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtJ2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtI2;
        private System.Windows.Forms.TextBox txtEscalar2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnLimpiar;
    }
}