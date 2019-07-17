namespace calculadora_de_matrices
{
    partial class CalculadoraMatrices
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
            this.cargar = new System.Windows.Forms.Button();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.dgvM1 = new System.Windows.Forms.DataGridView();
            this.dgvM2 = new System.Windows.Forms.DataGridView();
            this.dgvMRes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.escala = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.escalar = new System.Windows.Forms.TextBox();
            this.INSTRUCCIONES = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMRes)).BeginInit();
            this.SuspendLayout();
            // 
            // cargar
            // 
            this.cargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargar.ForeColor = System.Drawing.Color.Black;
            this.cargar.Location = new System.Drawing.Point(672, 48);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(112, 23);
            this.cargar.TabIndex = 0;
            this.cargar.Text = "INSERTAR";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // txtFilas
            // 
            this.txtFilas.Location = new System.Drawing.Point(38, 46);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(215, 20);
            this.txtFilas.TabIndex = 1;
            this.txtFilas.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "CANTIDAD DE FILAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(315, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "CANTIDAD DE COLUMNAS";
            // 
            // txtColumnas
            // 
            this.txtColumnas.Location = new System.Drawing.Point(320, 51);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(215, 20);
            this.txtColumnas.TabIndex = 4;
            this.txtColumnas.Text = "0";
            // 
            // dgvM1
            // 
            this.dgvM1.AllowUserToAddRows = false;
            this.dgvM1.AllowUserToDeleteRows = false;
            this.dgvM1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvM1.Location = new System.Drawing.Point(66, 101);
            this.dgvM1.Name = "dgvM1";
            this.dgvM1.Size = new System.Drawing.Size(299, 193);
            this.dgvM1.TabIndex = 5;
            // 
            // dgvM2
            // 
            this.dgvM2.AllowUserToAddRows = false;
            this.dgvM2.AllowUserToDeleteRows = false;
            this.dgvM2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvM2.Location = new System.Drawing.Point(66, 328);
            this.dgvM2.Name = "dgvM2";
            this.dgvM2.Size = new System.Drawing.Size(299, 200);
            this.dgvM2.TabIndex = 6;
            // 
            // dgvMRes
            // 
            this.dgvMRes.AllowUserToAddRows = false;
            this.dgvMRes.AllowUserToDeleteRows = false;
            this.dgvMRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMRes.Location = new System.Drawing.Point(692, 189);
            this.dgvMRes.Name = "dgvMRes";
            this.dgvMRes.ReadOnly = true;
            this.dgvMRes.Size = new System.Drawing.Size(301, 193);
            this.dgvMRes.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(63, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "MATRIZ 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(63, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "MATRIZ 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(688, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "RESULTADO";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(469, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "SUMA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(469, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "RESTA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(469, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "PRODUCTO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // escala
            // 
            this.escala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escala.ForeColor = System.Drawing.Color.Black;
            this.escala.Location = new System.Drawing.Point(469, 407);
            this.escala.Name = "escala";
            this.escala.Size = new System.Drawing.Size(181, 23);
            this.escala.TabIndex = 14;
            this.escala.Text = "PRODUCTO ESCALAR";
            this.escala.UseVisualStyleBackColor = true;
            this.escala.Click += new System.EventHandler(this.button4_Click);
            // 
            // borrar
            // 
            this.borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrar.ForeColor = System.Drawing.Color.Black;
            this.borrar.Location = new System.Drawing.Point(845, 407);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(87, 23);
            this.borrar.TabIndex = 15;
            this.borrar.Text = "BORRAR";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // escalar
            // 
            this.escalar.Location = new System.Drawing.Point(469, 443);
            this.escalar.Name = "escalar";
            this.escalar.Size = new System.Drawing.Size(116, 20);
            this.escalar.TabIndex = 16;
            // 
            // INSTRUCCIONES
            // 
            this.INSTRUCCIONES.BackColor = System.Drawing.Color.Transparent;
            this.INSTRUCCIONES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.INSTRUCCIONES.Enabled = false;
            this.INSTRUCCIONES.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.INSTRUCCIONES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSTRUCCIONES.ForeColor = System.Drawing.Color.Transparent;
            this.INSTRUCCIONES.Location = new System.Drawing.Point(1013, 12);
            this.INSTRUCCIONES.Name = "INSTRUCCIONES";
            this.INSTRUCCIONES.Size = new System.Drawing.Size(12, 10);
            this.INSTRUCCIONES.TabIndex = 17;
            this.INSTRUCCIONES.UseVisualStyleBackColor = false;
            this.INSTRUCCIONES.Click += new System.EventHandler(this.INSTRUCCIONES_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(1013, 529);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(12, 10);
            this.button4.TabIndex = 18;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Enabled = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(14, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(12, 10);
            this.button5.TabIndex = 19;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Enabled = false;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(14, 529);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(12, 10);
            this.button6.TabIndex = 20;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(845, 505);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 23);
            this.button7.TabIndex = 21;
            this.button7.Text = "SALIR";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // CalculadoraMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1038, 551);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.INSTRUCCIONES);
            this.Controls.Add(this.escalar);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.escala);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMRes);
            this.Controls.Add(this.dgvM2);
            this.Controls.Add(this.dgvM1);
            this.Controls.Add(this.txtColumnas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilas);
            this.Controls.Add(this.cargar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CalculadoraMatrices";
            this.Text = "CalculadoraMatriz";
            ((System.ComponentModel.ISupportInitialize)(this.dgvM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.DataGridView dgvM1;
        private System.Windows.Forms.DataGridView dgvM2;
        private System.Windows.Forms.DataGridView dgvMRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button escala;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.TextBox escalar;
        private System.Windows.Forms.Button INSTRUCCIONES;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

