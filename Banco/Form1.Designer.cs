namespace Banco
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdentidadTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SaldoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumeroCuentaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TipoMovimientoComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MontoMovimientoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MovimientoListBox = new System.Windows.Forms.ListBox();
            this.CrearCuentaButton = new System.Windows.Forms.Button();
            this.AgregarMovimientoButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombreClienteTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IdentidadTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Location = new System.Drawing.Point(122, 82);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.Size = new System.Drawing.Size(243, 22);
            this.NombreClienteTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // IdentidadTextBox
            // 
            this.IdentidadTextBox.Location = new System.Drawing.Point(122, 38);
            this.IdentidadTextBox.Name = "IdentidadTextBox";
            this.IdentidadTextBox.Size = new System.Drawing.Size(243, 22);
            this.IdentidadTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identidad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SaldoTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NumeroCuentaTextBox);
            this.groupBox2.Location = new System.Drawing.Point(446, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta";
            // 
            // SaldoTextBox
            // 
            this.SaldoTextBox.Location = new System.Drawing.Point(167, 73);
            this.SaldoTextBox.Name = "SaldoTextBox";
            this.SaldoTextBox.ReadOnly = true;
            this.SaldoTextBox.Size = new System.Drawing.Size(152, 22);
            this.SaldoTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saldo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Número de cuenta:";
            // 
            // NumeroCuentaTextBox
            // 
            this.NumeroCuentaTextBox.Location = new System.Drawing.Point(167, 29);
            this.NumeroCuentaTextBox.Name = "NumeroCuentaTextBox";
            this.NumeroCuentaTextBox.Size = new System.Drawing.Size(152, 22);
            this.NumeroCuentaTextBox.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TipoMovimientoComboBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.MontoMovimientoTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(37, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(716, 88);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movimiento";
            // 
            // TipoMovimientoComboBox
            // 
            this.TipoMovimientoComboBox.FormattingEnabled = true;
            this.TipoMovimientoComboBox.Items.AddRange(new object[] {
            "Depósito",
            "Retiro"});
            this.TipoMovimientoComboBox.Location = new System.Drawing.Point(492, 32);
            this.TipoMovimientoComboBox.Name = "TipoMovimientoComboBox";
            this.TipoMovimientoComboBox.Size = new System.Drawing.Size(190, 24);
            this.TipoMovimientoComboBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tipo movimiento:";
            // 
            // MontoMovimientoTextBox
            // 
            this.MontoMovimientoTextBox.Location = new System.Drawing.Point(75, 32);
            this.MontoMovimientoTextBox.Name = "MontoMovimientoTextBox";
            this.MontoMovimientoTextBox.Size = new System.Drawing.Size(152, 22);
            this.MontoMovimientoTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto:";
            // 
            // MovimientoListBox
            // 
            this.MovimientoListBox.FormattingEnabled = true;
            this.MovimientoListBox.ItemHeight = 16;
            this.MovimientoListBox.Location = new System.Drawing.Point(37, 298);
            this.MovimientoListBox.Name = "MovimientoListBox";
            this.MovimientoListBox.Size = new System.Drawing.Size(656, 196);
            this.MovimientoListBox.TabIndex = 3;
            // 
            // CrearCuentaButton
            // 
            this.CrearCuentaButton.Location = new System.Drawing.Point(724, 298);
            this.CrearCuentaButton.Name = "CrearCuentaButton";
            this.CrearCuentaButton.Size = new System.Drawing.Size(138, 61);
            this.CrearCuentaButton.TabIndex = 4;
            this.CrearCuentaButton.Text = "Crear Cuenta";
            this.CrearCuentaButton.UseVisualStyleBackColor = true;
            this.CrearCuentaButton.Click += new System.EventHandler(this.CrearCuentaButton_Click);
            // 
            // AgregarMovimientoButton
            // 
            this.AgregarMovimientoButton.Location = new System.Drawing.Point(724, 391);
            this.AgregarMovimientoButton.Name = "AgregarMovimientoButton";
            this.AgregarMovimientoButton.Size = new System.Drawing.Size(138, 70);
            this.AgregarMovimientoButton.TabIndex = 5;
            this.AgregarMovimientoButton.Text = "Agregar Movimiento";
            this.AgregarMovimientoButton.UseVisualStyleBackColor = true;
            this.AgregarMovimientoButton.Click += new System.EventHandler(this.AgregarMovimientoButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 537);
            this.Controls.Add(this.AgregarMovimientoButton);
            this.Controls.Add(this.CrearCuentaButton);
            this.Controls.Add(this.MovimientoListBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox MovimientoListBox;
        private System.Windows.Forms.Button CrearCuentaButton;
        private System.Windows.Forms.Button AgregarMovimientoButton;
        private System.Windows.Forms.TextBox NombreClienteTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdentidadTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SaldoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumeroCuentaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MontoMovimientoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TipoMovimientoComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

