using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnPersonMain_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnProductMain_Click(object sender, EventArgs e)
        {
            ProductPage page = new ProductPage();
            page.ShowDialog();
        }
    }
}
