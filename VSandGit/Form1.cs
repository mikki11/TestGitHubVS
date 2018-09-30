using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSandGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != Color.Blue)
            {
                button1.BackColor = Color.Blue;
            }
            else
            {
                button1.BackColor = Color.Yellow;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button buttonX = sender as Button;
            if(buttonX.Width != 120)
            {
                buttonX.Size = new Size(120, 50);
            }
            else
            {
                buttonX.Size = new Size(70, 30);
            }

        }
    }
}
