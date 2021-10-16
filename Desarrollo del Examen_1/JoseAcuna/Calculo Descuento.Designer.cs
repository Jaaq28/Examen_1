
namespace JoseAcuna
{
    partial class Calculo_Descuento
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
            this.label1 = new System.Windows.Forms.Label();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.ProductosCMBB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.MuestraListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "VAlor de descuendo:";
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Location = new System.Drawing.Point(263, 116);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(160, 22);
            this.DescuentoTextBox.TabIndex = 1;
            this.DescuentoTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // ProductosCMBB
            // 
            this.ProductosCMBB.FormattingEnabled = true;
            this.ProductosCMBB.Items.AddRange(new object[] {
            "Naranjas",
            "Leches",
            "Carnes",
            "Atun",
            "Pollo",
            "Melon",
            "Sandia",
            "Platano",
            "Huevo",
            "Malteadas"});
            this.ProductosCMBB.Location = new System.Drawing.Point(263, 36);
            this.ProductosCMBB.Name = "ProductosCMBB";
            this.ProductosCMBB.Size = new System.Drawing.Size(160, 24);
            this.ProductosCMBB.TabIndex = 2;
            this.ProductosCMBB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto:";
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(284, 397);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(119, 45);
            this.CalcularButton.TabIndex = 4;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(493, 397);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(119, 45);
            this.LimpiarButton.TabIndex = 5;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(263, 79);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(160, 22);
            this.TotalTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total:";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(88, 397);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(119, 45);
            this.AgregarButton.TabIndex = 8;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // MuestraListBox
            // 
            this.MuestraListBox.FormattingEnabled = true;
            this.MuestraListBox.ItemHeight = 16;
            this.MuestraListBox.Location = new System.Drawing.Point(103, 207);
            this.MuestraListBox.Name = "MuestraListBox";
            this.MuestraListBox.Size = new System.Drawing.Size(492, 148);
            this.MuestraListBox.TabIndex = 9;
            // 
            // Calculo_Descuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 502);
            this.Controls.Add(this.MuestraListBox);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductosCMBB);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Calculo_Descuento";
            this.Text = "Calculo_Descuento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.ComboBox ProductosCMBB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.ListBox MuestraListBox;
    }
}