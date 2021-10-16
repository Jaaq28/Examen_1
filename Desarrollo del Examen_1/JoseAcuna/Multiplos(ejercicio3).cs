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
    public partial class Multiplos_ejercicio3_ : Form
    {
        public Multiplos_ejercicio3_()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            MultiplosDe3();
            MultiplosDe5();
            MultiplosDE3Y5();
        }

        private void MultiplosDe3()
        {
            for (int n = 1; n <= 100; n++)
            {
                if (n % 3 == 0)
                {
                    ListBox1.Items.Add(n + " Jose A.");
                }
            }
        }

        private void MultiplosDe5()
        {
            for (int p = 1; p <= 100; p++)
            {
                if (p % 5 == 0)
                {
                    ListBox2.Items.Add(p + "  Acuna Quiroz");
                }
            }
        }

        private void MultiplosDE3Y5()
        {
            for (int o = 1; o <= 100; o++)
            {
                if (o % 3 == 0 && o % 5 == 0)
                {
                    ListBox3.Items.Add(o + "  Jose A. Acuna Quiroz");
                }
            }
        }

    }
}
