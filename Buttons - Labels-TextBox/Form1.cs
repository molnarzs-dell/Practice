using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttons___Labels_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            int numbersOne = Convert.ToInt32(tbx_First.Text);
            int numbersTwo = Convert.ToInt32(tbx_Second.Text);

            int összeg = numbersOne + numbersTwo;

            Result.Text = Convert.ToString(összeg);
           
        }
    }
}
