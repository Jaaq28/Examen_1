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
    public partial class Calculo_Descuento : Form
    {
        public Calculo_Descuento()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
      
        }

        int Precio;
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seleccion = ProductosCMBB.SelectedIndex;
            switch (seleccion)
            {
                case (0): Precio = 67; 
                    break;
                case (1):Precio = 56;  
                    break;
                case (2):Precio = 67;
                    break;
                case (3): Precio = 50;
                    break;
                case (4): Precio = 44;
                    break;
                case (5): Precio = 78;
                    break;
                   case (6):Precio = 99;
                    break;
                case (7): Precio = 54;
                    break;
                case (8): Precio = 78;
                    break;
                case (9): Precio = 34;
                    break;
                    
            }
        }

        public int CalcularProducto(int p1,int p2) 
        {
            
            int cpt = p1 + p2;

            return cpt;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (ProductosCMBB.Text==string.Empty)
            {
                MessageBox.Show( "La Selleccion No Ha sido Realizado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProductosCMBB.Focus();
                return;               
            }

            MuestraListBox.Items.Add(" EL Producto es " + ProductosCMBB.Text + " Con el Precio de  " + Precio);
            TotalTextBox.Text = CalcularProducto(Convert.ToInt32(Precio), Convert.ToInt32(TotalTextBox.Text)).ToString();

        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            TotalTextBox.Clear();
            DescuentoTextBox.Clear();
        }
    }

}
