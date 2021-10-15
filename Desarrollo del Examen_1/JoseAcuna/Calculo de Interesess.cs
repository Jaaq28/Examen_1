using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoseAcuna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            capital();

        }
         
        public double CalcularInteres(double a, double b, double c) 
        {
            double total, total1 = 0;
            double t = b / 100;
            for (int d=0; d < c; d++) 
            {
                total = a * t;
                total1 = total1 + total;
            }
            return total1;
        }
        public void capital() 
        {
            double capital;
            double interes;
            double mes;


            capital = Convert.ToDouble(DepositoTextBox.Text);
            if (capital > 500000) 
            {
                MessageBox.Show(capital + "Capital Erroneo", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else 
            {
                interes = Convert.ToDouble(InteresTextBox.Text);
                if (interes > 1.5 || interes < 1) 
                {
                    MessageBox.Show(interes + "Tasa de Interes Erroneo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    mes = Convert.ToDouble(PeriodoTextBox.Text);
                    if (mes > 12 || mes < 1) 
                    {
                        MessageBox.Show(mes + "Numero de Mes Erroneo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else 
                    {
                        double x = CalcularInteres(capital, interes, mes);
                        listBox1.Items.Add(NombreTextBox.Text);
                        listBox1.Items.Add(x);
                        listBox1.Items.Add(mes);
                        double capt = x + capital;
                        MessageBox.Show(" su capital tota es de " +  capt);
                    }
                }
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTextBox.Clear();
            DepositoTextBox.Clear();
            PeriodoTextBox.Clear();
            InteresTextBox.Clear();
        }
    }
}
