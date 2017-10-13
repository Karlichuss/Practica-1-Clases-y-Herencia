namespace Figuras_geometricas
{
    partial class Form1
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblParametro1 = new System.Windows.Forms.Label();
            this.lblParametro2 = new System.Windows.Forms.Label();
            this.rbRectangulo = new System.Windows.Forms.RadioButton();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.rbCirculo = new System.Windows.Forms.RadioButton();
            this.txtParametro1 = new System.Windows.Forms.TextBox();
            this.txtParametro2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtParametro3 = new System.Windows.Forms.TextBox();
            this.lblParametro3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 244);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular...";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblParametro1
            // 
            this.lblParametro1.AutoSize = true;
            this.lblParametro1.Location = new System.Drawing.Point(12, 108);
            this.lblParametro1.Name = "lblParametro1";
            this.lblParametro1.Size = new System.Drawing.Size(43, 13);
            this.lblParametro1.TabIndex = 1;
            this.lblParametro1.Text = "Lado 1:";
            // 
            // lblParametro2
            // 
            this.lblParametro2.AutoSize = true;
            this.lblParametro2.Location = new System.Drawing.Point(12, 148);
            this.lblParametro2.Name = "lblParametro2";
            this.lblParametro2.Size = new System.Drawing.Size(43, 13);
            this.lblParametro2.TabIndex = 2;
            this.lblParametro2.Text = "Lado 2:";
            // 
            // rbRectangulo
            // 
            this.rbRectangulo.AutoSize = true;
            this.rbRectangulo.Checked = true;
            this.rbRectangulo.Location = new System.Drawing.Point(6, 19);
            this.rbRectangulo.Name = "rbRectangulo";
            this.rbRectangulo.Size = new System.Drawing.Size(80, 17);
            this.rbRectangulo.TabIndex = 3;
            this.rbRectangulo.TabStop = true;
            this.rbRectangulo.Text = "Rectangulo";
            this.rbRectangulo.UseVisualStyleBackColor = true;
            this.rbRectangulo.CheckedChanged += new System.EventHandler(this.cambioDeSeleccion);
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Location = new System.Drawing.Point(6, 43);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(69, 17);
            this.rbTriangulo.TabIndex = 4;
            this.rbTriangulo.Text = "Triangulo";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            this.rbTriangulo.CheckedChanged += new System.EventHandler(this.cambioDeSeleccion);
            // 
            // rbCirculo
            // 
            this.rbCirculo.AutoSize = true;
            this.rbCirculo.Location = new System.Drawing.Point(6, 67);
            this.rbCirculo.Name = "rbCirculo";
            this.rbCirculo.Size = new System.Drawing.Size(57, 17);
            this.rbCirculo.TabIndex = 5;
            this.rbCirculo.Text = "Circulo";
            this.rbCirculo.UseVisualStyleBackColor = true;
            this.rbCirculo.CheckedChanged += new System.EventHandler(this.cambioDeSeleccion);
            // 
            // txtParametro1
            // 
            this.txtParametro1.Location = new System.Drawing.Point(15, 125);
            this.txtParametro1.Name = "txtParametro1";
            this.txtParametro1.Size = new System.Drawing.Size(114, 20);
            this.txtParametro1.TabIndex = 7;
            this.txtParametro1.Text = "1,0";
            // 
            // txtParametro2
            // 
            this.txtParametro2.Location = new System.Drawing.Point(15, 165);
            this.txtParametro2.Name = "txtParametro2";
            this.txtParametro2.Size = new System.Drawing.Size(114, 20);
            this.txtParametro2.TabIndex = 8;
            this.txtParametro2.Text = "1,0";
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(149, 9);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(175, 258);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado";
            // 
            // txtParametro3
            // 
            this.txtParametro3.Location = new System.Drawing.Point(15, 205);
            this.txtParametro3.Name = "txtParametro3";
            this.txtParametro3.Size = new System.Drawing.Size(114, 20);
            this.txtParametro3.TabIndex = 11;
            this.txtParametro3.Text = "1,0";
            // 
            // lblParametro3
            // 
            this.lblParametro3.AutoSize = true;
            this.lblParametro3.Location = new System.Drawing.Point(12, 188);
            this.lblParametro3.Name = "lblParametro3";
            this.lblParametro3.Size = new System.Drawing.Size(43, 13);
            this.lblParametro3.TabIndex = 10;
            this.lblParametro3.Text = "Lado 3:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCirculo);
            this.groupBox1.Controls.Add(this.rbTriangulo);
            this.groupBox1.Controls.Add(this.rbRectangulo);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 92);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figura: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 279);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtParametro3);
            this.Controls.Add(this.lblParametro3);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtParametro2);
            this.Controls.Add(this.txtParametro1);
            this.Controls.Add(this.lblParametro2);
            this.Controls.Add(this.lblParametro1);
            this.Controls.Add(this.btnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblParametro1;
        private System.Windows.Forms.Label lblParametro2;
        private System.Windows.Forms.RadioButton rbRectangulo;
        private System.Windows.Forms.RadioButton rbTriangulo;
        private System.Windows.Forms.RadioButton rbCirculo;
        private System.Windows.Forms.TextBox txtParametro1;
        private System.Windows.Forms.TextBox txtParametro2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtParametro3;
        private System.Windows.Forms.Label lblParametro3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

