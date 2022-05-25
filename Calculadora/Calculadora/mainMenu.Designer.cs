namespace Calculadora
{
    partial class mainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMatrices = new System.Windows.Forms.Button();
            this.btnCuaternios = new System.Windows.Forms.Button();
            this.btnTrazos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnVectores = new System.Windows.Forms.Button();
            this.btnMatrizComp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMatrices
            // 
            this.btnMatrices.FlatAppearance.BorderSize = 2;
            this.btnMatrices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatrices.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMatrices.Location = new System.Drawing.Point(314, 83);
            this.btnMatrices.Margin = new System.Windows.Forms.Padding(6);
            this.btnMatrices.Name = "btnMatrices";
            this.btnMatrices.Size = new System.Drawing.Size(209, 74);
            this.btnMatrices.TabIndex = 0;
            this.btnMatrices.Text = "Operaciones con Matrices";
            this.btnMatrices.UseVisualStyleBackColor = true;
            this.btnMatrices.Click += new System.EventHandler(this.btnMatrices_Click);
            // 
            // btnCuaternios
            // 
            this.btnCuaternios.FlatAppearance.BorderSize = 2;
            this.btnCuaternios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuaternios.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCuaternios.Location = new System.Drawing.Point(314, 254);
            this.btnCuaternios.Margin = new System.Windows.Forms.Padding(6);
            this.btnCuaternios.Name = "btnCuaternios";
            this.btnCuaternios.Size = new System.Drawing.Size(209, 74);
            this.btnCuaternios.TabIndex = 1;
            this.btnCuaternios.Text = "Cuaternios";
            this.btnCuaternios.UseVisualStyleBackColor = true;
            this.btnCuaternios.Click += new System.EventHandler(this.btnCuaternios_Click);
            // 
            // btnTrazos
            // 
            this.btnTrazos.FlatAppearance.BorderSize = 2;
            this.btnTrazos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrazos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTrazos.Location = new System.Drawing.Point(314, 426);
            this.btnTrazos.Margin = new System.Windows.Forms.Padding(6);
            this.btnTrazos.Name = "btnTrazos";
            this.btnTrazos.Size = new System.Drawing.Size(209, 74);
            this.btnTrazos.TabIndex = 2;
            this.btnTrazos.Text = "Bresenham";
            this.btnTrazos.UseVisualStyleBackColor = true;
            this.btnTrazos.Click += new System.EventHandler(this.btnTrazos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(33, 461);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 39);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitle.Location = new System.Drawing.Point(277, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 47);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "LMAD Essencial";
            // 
            // btnVectores
            // 
            this.btnVectores.FlatAppearance.BorderSize = 2;
            this.btnVectores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVectores.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVectores.Location = new System.Drawing.Point(314, 340);
            this.btnVectores.Margin = new System.Windows.Forms.Padding(6);
            this.btnVectores.Name = "btnVectores";
            this.btnVectores.Size = new System.Drawing.Size(209, 74);
            this.btnVectores.TabIndex = 5;
            this.btnVectores.Text = "Vectores";
            this.btnVectores.UseVisualStyleBackColor = true;
            this.btnVectores.Click += new System.EventHandler(this.btnVectores_Click);
            // 
            // btnMatrizComp
            // 
            this.btnMatrizComp.FlatAppearance.BorderSize = 2;
            this.btnMatrizComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatrizComp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMatrizComp.Location = new System.Drawing.Point(314, 168);
            this.btnMatrizComp.Margin = new System.Windows.Forms.Padding(6);
            this.btnMatrizComp.Name = "btnMatrizComp";
            this.btnMatrizComp.Size = new System.Drawing.Size(209, 74);
            this.btnMatrizComp.TabIndex = 6;
            this.btnMatrizComp.Text = "Matriz Compuesta";
            this.btnMatrizComp.UseVisualStyleBackColor = true;
            this.btnMatrizComp.Click += new System.EventHandler(this.btnMatrizComp_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(834, 532);
            this.Controls.Add(this.btnMatrizComp);
            this.Controls.Add(this.btnVectores);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnTrazos);
            this.Controls.Add(this.btnCuaternios);
            this.Controls.Add(this.btnMatrices);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "mainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMatrices;
        private System.Windows.Forms.Button btnCuaternios;
        private System.Windows.Forms.Button btnTrazos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnVectores;
        private System.Windows.Forms.Button btnMatrizComp;
    }
}

