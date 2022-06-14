namespace SalarioEmpleado
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ValorVentasTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AñosTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SalarioTextBox = new System.Windows.Forms.TextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(323, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la fecha de nacimiento:";
            // 
            // ValorVentasTextBox
            // 
            this.ValorVentasTextBox.Location = new System.Drawing.Point(313, 182);
            this.ValorVentasTextBox.Name = "ValorVentasTextBox";
            this.ValorVentasTextBox.Size = new System.Drawing.Size(141, 22);
            this.ValorVentasTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor de las ventas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Años de antiguedad:";
            // 
            // AñosTextBox
            // 
            this.AñosTextBox.Location = new System.Drawing.Point(313, 228);
            this.AñosTextBox.Name = "AñosTextBox";
            this.AñosTextBox.Size = new System.Drawing.Size(141, 22);
            this.AñosTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nuevo salario:";
            // 
            // SalarioTextBox
            // 
            this.SalarioTextBox.Enabled = false;
            this.SalarioTextBox.Location = new System.Drawing.Point(313, 311);
            this.SalarioTextBox.Name = "SalarioTextBox";
            this.SalarioTextBox.Size = new System.Drawing.Size(141, 22);
            this.SalarioTextBox.TabIndex = 6;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(492, 277);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(148, 66);
            this.CalcularButton.TabIndex = 8;
            this.CalcularButton.Text = "Calcular salario";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SalarioTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AñosTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ValorVentasTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ValorVentasTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AñosTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SalarioTextBox;
        private System.Windows.Forms.Button CalcularButton;
    }
}

