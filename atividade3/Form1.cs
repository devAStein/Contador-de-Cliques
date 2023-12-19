using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        uint a = 0;


        private void iniciar_Click(object sender, EventArgs e)
        {
            subtrair.Enabled = true;
            somar.Enabled = true;
        }

        private void somar_Click(object sender, EventArgs e)
        {
            a++;
            contadorClick.Text = a.ToString();
        }

        private void subtrair_Click(object sender, EventArgs e)
        {
            if(a > 0)
            {
                a--;
                contadorClick.Text = a.ToString();
            }
            
        }

        private void numeroClick_Click(object sender, EventArgs e)
        {
            
        }

        private void reset_Click(object sender, EventArgs e)
        {

            a = 0;
            contadorClick.Text = a.ToString();
            subtrair.Enabled = false;
            somar.Enabled = false;
        }
    }
}
