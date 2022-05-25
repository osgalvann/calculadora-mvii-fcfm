namespace Calculadora
{
    partial class Matrices
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
            this.btnOkA = new System.Windows.Forms.Button();
            this.nudFilas = new System.Windows.Forms.NumericUpDown();
            this.nudColums = new System.Windows.Forms.NumericUpDown();
            this.gpbMatrizA = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbMatrizB = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudFilasB = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nudColumB = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblIgual = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ckbTransA = new System.Windows.Forms.CheckBox();
            this.ckbTrans2 = new System.Windows.Forms.CheckBox();
            this.lbxLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilasB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOkA
            // 
            this.btnOkA.FlatAppearance.BorderSize = 2;
            this.btnOkA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkA.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOkA.Location = new System.Drawing.Point(223, 5);
            this.btnOkA.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnOkA.Name = "btnOkA";
            this.btnOkA.Size = new System.Drawing.Size(41, 37);
            this.btnOkA.TabIndex = 1;
            this.btnOkA.Text = "OK";
            this.btnOkA.UseVisualStyleBackColor = true;
            this.btnOkA.Click += new System.EventHandler(this.btnOkA_Click);
            // 
            // nudFilas
            // 
            this.nudFilas.Location = new System.Drawing.Point(52, 12);
            this.nudFilas.Name = "nudFilas";
            this.nudFilas.Size = new System.Drawing.Size(36, 25);
            this.nudFilas.TabIndex = 3;
            this.nudFilas.ValueChanged += new System.EventHandler(this.nudFilas_ValueChanged);
            // 
            // nudColums
            // 
            this.nudColums.Location = new System.Drawing.Point(176, 12);
            this.nudColums.Name = "nudColums";
            this.nudColums.Size = new System.Drawing.Size(36, 25);
            this.nudColums.TabIndex = 4;
            this.nudColums.ValueChanged += new System.EventHandler(this.nudColums_ValueChanged);
            // 
            // gpbMatrizA
            // 
            this.gpbMatrizA.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbMatrizA.Location = new System.Drawing.Point(11, 43);
            this.gpbMatrizA.Name = "gpbMatrizA";
            this.gpbMatrizA.Size = new System.Drawing.Size(395, 384);
            this.gpbMatrizA.TabIndex = 5;
            this.gpbMatrizA.TabStop = false;
            this.gpbMatrizA.Text = "MatrizA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Columnas";
            // 
            // gpbMatrizB
            // 
            this.gpbMatrizB.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbMatrizB.Location = new System.Drawing.Point(455, 43);
            this.gpbMatrizB.Name = "gpbMatrizB";
            this.gpbMatrizB.Size = new System.Drawing.Size(395, 384);
            this.gpbMatrizB.TabIndex = 6;
            this.gpbMatrizB.TabStop = false;
            this.gpbMatrizB.Text = "MatrizB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Columnas";
            // 
            // nudFilasB
            // 
            this.nudFilasB.Location = new System.Drawing.Point(502, 12);
            this.nudFilasB.Name = "nudFilasB";
            this.nudFilasB.Size = new System.Drawing.Size(36, 25);
            this.nudFilasB.TabIndex = 9;
            this.nudFilasB.ValueChanged += new System.EventHandler(this.nudFilasB_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Filas";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(673, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nudColumB
            // 
            this.nudColumB.Location = new System.Drawing.Point(626, 12);
            this.nudColumB.Name = "nudColumB";
            this.nudColumB.Size = new System.Drawing.Size(36, 25);
            this.nudColumB.TabIndex = 10;
            this.nudColumB.ValueChanged += new System.EventHandler(this.nudColumB_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion"});
            this.comboBox1.Location = new System.Drawing.Point(202, 447);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Operacion";
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatAppearance.BorderSize = 2;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Location = new System.Drawing.Point(349, 442);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(97, 37);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gpbResultado
            // 
            this.gpbResultado.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbResultado.Location = new System.Drawing.Point(900, 43);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(395, 384);
            this.gpbResultado.TabIndex = 7;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(413, 220);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(35, 35);
            this.lblOp.TabIndex = 16;
            this.lblOp.Text = "+";
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgual.Location = new System.Drawing.Point(859, 220);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(35, 35);
            this.lblIgual.TabIndex = 17;
            this.lblIgual.Text = "=";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Location = new System.Drawing.Point(940, 440);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 37);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 2;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenu.Location = new System.Drawing.Point(1053, 440);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(97, 37);
            this.btnMenu.TabIndex = 19;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(1166, 440);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 37);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ckbTransA
            // 
            this.ckbTransA.AutoSize = true;
            this.ckbTransA.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTransA.Location = new System.Drawing.Point(296, 11);
            this.ckbTransA.Name = "ckbTransA";
            this.ckbTransA.Size = new System.Drawing.Size(121, 25);
            this.ckbTransA.TabIndex = 21;
            this.ckbTransA.Text = "Transpuesta";
            this.ckbTransA.UseVisualStyleBackColor = true;
            this.ckbTransA.CheckedChanged += new System.EventHandler(this.ckbTransA_CheckedChanged);
            // 
            // ckbTrans2
            // 
            this.ckbTrans2.AutoSize = true;
            this.ckbTrans2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTrans2.Location = new System.Drawing.Point(725, 11);
            this.ckbTrans2.Name = "ckbTrans2";
            this.ckbTrans2.Size = new System.Drawing.Size(121, 25);
            this.ckbTrans2.TabIndex = 22;
            this.ckbTrans2.Text = "Transpuesta";
            this.ckbTrans2.UseVisualStyleBackColor = true;
            this.ckbTrans2.CheckedChanged += new System.EventHandler(this.ckbTrans2_CheckedChanged);
            // 
            // lbxLog
            // 
            this.lbxLog.FormattingEnabled = true;
            this.lbxLog.ItemHeight = 19;
            this.lbxLog.Location = new System.Drawing.Point(462, 442);
            this.lbxLog.Name = "lbxLog";
            this.lbxLog.Size = new System.Drawing.Size(384, 99);
            this.lbxLog.TabIndex = 23;
            // 
            // Matrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1308, 554);
            this.Controls.Add(this.lbxLog);
            this.Controls.Add(this.ckbTrans2);
            this.Controls.Add(this.ckbTransA);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudFilasB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudColumB);
            this.Controls.Add(this.gpbMatrizB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpbMatrizA);
            this.Controls.Add(this.nudFilas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOkA);
            this.Controls.Add(this.nudColums);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Matrices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrices";
            this.Load += new System.EventHandler(this.Matrices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilasB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOkA;
        private System.Windows.Forms.NumericUpDown nudFilas;
        private System.Windows.Forms.NumericUpDown nudColums;
        private System.Windows.Forms.GroupBox gpbMatrizA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbMatrizB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudFilasB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nudColumB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox ckbTransA;
        private System.Windows.Forms.CheckBox ckbTrans2;
        public System.Windows.Forms.ListBox lbxLog;
    }
}