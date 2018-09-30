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
                button1.Text = "Plavo";
                button1.Font = new Font("Times New Roman", 16);
                button1.ForeColor = Color.White;
            }
            else
            {
                button1.BackColor = Color.Yellow;
                button1.Text = "Zolta";
                button1.Font = new Font("Arial", 12);
                button1.ForeColor = Color.Black;
            }
            
        }
    }
}
