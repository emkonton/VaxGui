using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaSuiteGui
{
    public partial class aform : Form
    {
        public aform()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void DarkThmB_Click(object sender, EventArgs e)
        {
            tabPage2.BackColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabPage2.BackColor= Color.White;
        }
    }
}
