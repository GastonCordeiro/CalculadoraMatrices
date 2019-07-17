namespace calculadora_de_matrices
{
    partial class ProductoDeDosMatrices
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
            this.dgvProductoA = new System.Windows.Forms.DataGridView();
            this.dgvProductoB = new System.Windows.Forms.DataGridView();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRowA = new System.Windows.Forms.TextBox();
            this.txtColumnA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRowB = new System.Windows.Forms.TextBox();
            this.txtColumnB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cargaA = new System.Windows.Forms.Button();
            this.cargaB = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.INSTRUCCIONES = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductoA
            // 
            this.dgvProductoA.AllowUserToAddRows = false;
            this.dgvProductoA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductoA.Location = new System.Drawing.Point(235, 68);
            this.dgvProductoA.Name = "dgvProductoA";
            this.dgvProductoA.Size = new System.Drawing.Size(240, 150);
            this.dgvProductoA.TabIndex = 0;
            // 
            // dgvProductoB
            // 
            this.dgvProductoB.AllowUserToAddRows = false;
            this.dgvProductoB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductoB.Location = new System.Drawing.Point(235, 367);
            this.dgvProductoB.Name = "dgvProductoB";
            this.dgvProductoB.Size = new System.Drawing.Size(240, 150);
            this.dgvProductoB.TabIndex = 1;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(675, 198);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(240, 150);
            this.dgvResultado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MATRIZ 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MATRIZ 2";
            // 
            // txtRowA
            // 
            this.txtRowA.Location = new System.Drawing.Point(54, 93);
            this.txtRowA.Name = "txtRowA";
            this.txtRowA.Size = new System.Drawing.Size(100, 20);
            this.txtRowA.TabIndex = 6;
            this.txtRowA.Text = "0";
            // 
            // txtColumnA
            // 
            this.txtColumnA.Location = new System.Drawing.Point(54, 153);
            this.txtColumnA.Name = "txtColumnA";
            this.txtColumnA.Size = new System.Drawing.Size(100, 20);
            this.txtColumnA.TabIndex = 7;
            this.txtColumnA.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CANTIDAD DE FILAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CANTIDAD DE COLUMNAS";
            // 
            // txtRowB
            // 
            this.txtRowB.Location = new System.Drawing.Point(54, 402);
            this.txtRowB.Name = "txtRowB";
            this.txtRowB.Size = new System.Drawing.Size(100, 20);
            this.txtRowB.TabIndex = 10;
            this.txtRowB.Text = "0";
            // 
            // txtColumnB
            // 
            this.txtColumnB.Location = new System.Drawing.Point(54, 465);
            this.txtColumnB.Name = "txtColumnB";
            this.txtColumnB.Size = new System.Drawing.Size(100, 20);
            this.txtColumnB.TabIndex = 11;
            this.txtColumnB.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "CANTIDAD DE FILAS";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "CANTIDAD DE COLUMNAS";
            // 
            // cargaA
            // 
            this.cargaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargaA.Location = new System.Drawing.Point(54, 209);
            this.cargaA.Name = "cargaA";
            this.cargaA.Size = new System.Drawing.Size(102, 23);
            this.cargaA.TabIndex = 14;
            this.cargaA.Text = "INSERTAR";
            this.cargaA.UseVisualStyleBackColor = true;
            this.cargaA.Click += new System.EventHandler(this.cargaA_Click);
            // 
            // cargaB
            // 
            this.cargaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargaB.Location = new System.Drawing.Point(54, 505);
            this.cargaB.Name = "cargaB";
            this.cargaB.Size = new System.Drawing.Size(100, 23);
            this.cargaB.TabIndex = 15;
            this.cargaB.Text = "INSERTAR";
            this.cargaB.UseVisualStyleBackColor = true;
            this.cargaB.Click += new System.EventHandler(this.cargaB_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Result.Location = new System.Drawing.Point(482, 252);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(132, 50);
            this.Result.TabIndex = 16;
            this.Result.Text = "=";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 46);
            this.label3.TabIndex = 17;
            this.label3.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(672, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "RESULTADO";
            // 
            // INSTRUCCIONES
            // 
            this.INSTRUCCIONES.BackColor = System.Drawing.Color.Transparent;
            this.INSTRUCCIONES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.INSTRUCCIONES.Enabled = false;
            this.INSTRUCCIONES.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.INSTRUCCIONES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSTRUCCIONES.ForeColor = System.Drawing.Color.Transparent;
            this.INSTRUCCIONES.Location = new System.Drawing.Point(939, 12);
            this.INSTRUCCIONES.Name = "INSTRUCCIONES";
            this.INSTRUCCIONES.Size = new System.Drawing.Size(10, 10);
            this.INSTRUCCIONES.TabIndex = 19;
            this.INSTRUCCIONES.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(939, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(10, 10);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(12, 549);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(10, 10);
            this.button3.TabIndex = 22;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // ProductoDeDosMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(961, 571);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.INSTRUCCIONES);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.cargaB);
            this.Controls.Add(this.cargaA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtColumnB);
            this.Controls.Add(this.txtRowB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtColumnA);
            this.Controls.Add(this.txtRowA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.dgvProductoB);
            this.Controls.Add(this.dgvProductoA);
            this.Name = "ProductoDeDosMatrices";
            this.Text = "ProductoMatrices";
            this.Load += new System.EventHandler(this.ProductoDeDosMatrices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductoA;
        private System.Windows.Forms.DataGridView dgvProductoB;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRowA;
        private System.Windows.Forms.TextBox txtColumnA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRowB;
        private System.Windows.Forms.TextBox txtColumnB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cargaA;
        private System.Windows.Forms.Button cargaB;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button INSTRUCCIONES;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}