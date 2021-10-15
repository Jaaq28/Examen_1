
namespace JoseAcuna
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.DepositoTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.PeriodoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.InteresTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad a Depositar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tasa De Interes:";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(161, 43);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(172, 22);
            this.NombreTextBox.TabIndex = 3;
            // 
            // DepositoTextBox
            // 
            this.DepositoTextBox.Location = new System.Drawing.Point(535, 43);
            this.DepositoTextBox.Name = "DepositoTextBox";
            this.DepositoTextBox.Size = new System.Drawing.Size(172, 22);
            this.DepositoTextBox.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(87, 166);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(620, 228);
            this.listBox1.TabIndex = 8;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(118, 419);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(133, 52);
            this.CalcularButton.TabIndex = 9;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(470, 419);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(133, 52);
            this.LimpiarButton.TabIndex = 10;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // PeriodoTextBox
            // 
            this.PeriodoTextBox.Location = new System.Drawing.Point(434, 121);
            this.PeriodoTextBox.Name = "PeriodoTextBox";
            this.PeriodoTextBox.Size = new System.Drawing.Size(114, 22);
            this.PeriodoTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Periodo:";
            // 
            // InteresTextBox
            // 
            this.InteresTextBox.Location = new System.Drawing.Point(234, 121);
            this.InteresTextBox.Name = "InteresTextBox";
            this.InteresTextBox.Size = new System.Drawing.Size(89, 22);
            this.InteresTextBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 516);
            this.Controls.Add(this.InteresTextBox);
            this.Controls.Add(this.PeriodoTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DepositoTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculo_De_Intereses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox DepositoTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.TextBox PeriodoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox InteresTextBox;
    }
}

