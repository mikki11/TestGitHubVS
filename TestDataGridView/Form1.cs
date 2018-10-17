using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.LearnRepos;

namespace TestDataGridView
{
    public partial class Form1 : Form
    {
        List<MapOrderHeader> mpoh;
        List<string> Categories = new List<string> { "catA", "catB", "catC" };
        public Form1()
        {
            InitializeComponent();
            WireEvents();
        }
        private void WireEvents()
        {
            btnLoadData.Click += btnLoadData_OnClick;
            btnPush.Click += btnPush_OnClick;
            this.Load += mainForm_OnLoad;
            this.Load += btnLoadData_OnClick;
        }

        private void mainForm_OnLoad(object sender, EventArgs e)
        {
            comboBox1.DataSource = Categories;
        }

        private void btnPush_OnClick(object sender, EventArgs e)
        {
            foreach(DataGridViewTextBoxCell cell in dataGridView1.SelectedCells)
            {
                cell.Value = comboBox1.SelectedItem; //.ToString();
            }
        }


        private void btnLoadData_OnClick(object sender, EventArgs e)
        {
            var xyz = new MyControler();
            mpoh = xyz.GetSalesOrderBetween(43693, 43698).ToList();
            dataGridView1.DataSource = mpoh;
        }
    }
}
