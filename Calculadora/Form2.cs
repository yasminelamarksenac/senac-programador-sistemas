using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form2 : Form
    {
      
        public Form2(string resultado)
        {
            InitializeComponent();  

            
            labelResultado2.Text = resultado;
        }
    }
}
