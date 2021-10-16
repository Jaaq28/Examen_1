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
    public partial class Calculo_Intereses : Form
    {
        public Calculo_Intereses()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            Interes();

        }
        public void Interes()
        {
            string Primero = Convert.ToString("En el Mes de Enero se gano un interes de       L   " + Enero());
            string Segundo = Convert.ToString("En el Mes de Febrero se gano un interes de    L   " + Febrero());
            string Tercero = Convert.ToString("En el Mes de Marzo se gano un interes de      L   " + Marzo());
            string Cuarto = Convert.ToString("En el Mes de Abril se gano un interes de         L   " + Abril());
            string quinto = Convert.ToString("En el Mes de Mayo se gano un interes de       L   " + Mayo());
            string Sexto = Convert.ToString("En el Mes de Junio se gano un interes de       L   " + Junio());
            string Septimo = Convert.ToString("En el Mes de Julio se gano un interes de        L   " + Julio());
            string Octavo = Convert.ToString("En el Mes de Agosto se gano un interes de      L   " + Agosto());
            string Noveno = Convert.ToString("En el Mes de Septiembre se gano un interes de   L   " + Septiembre());
            string Decimo = Convert.ToString("En el Mes de Octubre se gano un interes de       L  " + Octubre());
            string Onceavo = Convert.ToString("En el Mes de Noviembre se gano un interes de    L   " + Noviembre());
            string Doceavo = Convert.ToString("En el Mes de Diciembre se gano un interes de      L   " + Diciembre());


            listBox1 .Items.Add(Primero); listBox1.Items.Add(Segundo);
            listBox1.Items.Add(Tercero); listBox1.Items.Add(Cuarto);
            listBox1.Items.Add(quinto); listBox1.Items.Add(Sexto);
            listBox1.Items.Add(Septimo); listBox1.Items.Add(Octavo);
            listBox1.Items.Add(Noveno); listBox1.Items.Add(Decimo);
            listBox1.Items.Add(Onceavo); listBox1.Items.Add(Doceavo);


            listBox1.DataSource = null;
        }
        public double Enero()
        {

            int Capital = Convert.ToInt32(DepositoTextBox.Text);
            return ((Capital * 0.015) * 1);
        }

        public double Febrero()
        {
            int Capital = Convert.ToInt32(DepositoTextBox.Text);
            return ((Capital * 0.015) * 2);
        }

        public double Marzo()
        {
            int Capital = Convert.ToInt32(DepositoTextBox.Text);
            return ((Capital * 0.015) * 3);
        }

        public double Abril()
        {
            int Capital = Convert.ToInt32(DepositoTextBox.Text);
            return ((Capital * 0.015) * 4);
        }

        public double Mayo()
        {
            int Capital = Convert.ToInt32(DepositoTextBox.Text);
            return ((Capital * 0.015) * 5);
        }

        public double Junio()
        {int Capital = Convert.ToInt32(DepositoTextBox.Text);
            return ((Capital * 0.015) * 6);
        }

        public double Julio()
        {
            int capital  = Convert.ToInt32(DepositoTextBox.Text);
            return ((capital * 0.015) * 7);
        }

        public double Agosto()
        {
            int Capital = Convert.ToInt32(DepositoTextBox.Text);
            return ((Capital * 0.015) * 8);
        }

        public double Septiembre()
        {int Capital = Convert.ToInt32(DepositoTextBox.Text);
            return ((Capital * 0.015) * 9);
        }

        public double Octubre()
        {
            int capital  = Convert.ToInt32(DepositoTextBox.Text);
            return ((capital * 0.015) * 10);
        }

        public double Noviembre()
        {
            int Capital = Convert.ToInt32(DepositoTextBox.Text);
            return ((Capital * 0.015) * 11);
        }

        public double Diciembre()
        {
            int Capital  = Convert.ToInt32(DepositoTextBox.Text);
            return ((Capital * 0.015) * 12);
        }



        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            NombreTextBox.Clear();
            DepositoTextBox.Clear();
            
        }

        private void Calculo_Intereses_Load(object sender, EventArgs e)
        {
            DepositoTextBox.Text = Convert.ToString("200000");
        }
    }
}
