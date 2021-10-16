
namespace JoseAcuna
{
    partial class Multiplos_ejercicio3_
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
            this.CalcularButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.ListBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ListBox3 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(269, 470);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(203, 56);
            this.CalcularButton.TabIndex = 0;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Multiplos de 3";
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 16;
            this.ListBox1.Location = new System.Drawing.Point(123, 78);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(215, 148);
            this.ListBox1.TabIndex = 2;
            // 
            // ListBox2
            // 
            this.ListBox2.FormattingEnabled = true;
            this.ListBox2.ItemHeight = 16;
            this.ListBox2.Location = new System.Drawing.Point(499, 78);
            this.ListBox2.Name = "ListBox2";
            this.ListBox2.Size = new System.Drawing.Size(215, 148);
            this.ListBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Multiplos de 5";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ListBox3
            // 
            this.ListBox3.FormattingEnabled = true;
            this.ListBox3.ItemHeight = 16;
            this.ListBox3.Location = new System.Drawing.Point(269, 271);
            this.ListBox3.Name = "ListBox3";
            this.ListBox3.Size = new System.Drawing.Size(215, 148);
            this.ListBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Multiplos de 3 y 5";
            // 
            // Multiplos_ejercicio3_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.ListBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcularButton);
            this.Name = "Multiplos_ejercicio3_";
            this.Text = "Multiplos_ejercicio3_";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.ListBox ListBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListBox3;
        private System.Windows.Forms.Label label3;
    }
}