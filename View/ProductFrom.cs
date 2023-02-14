using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModel;

namespace View
{
    public partial class ProductFrom : Form
    {
        private readonly ProductViewModel _productViewModel;
        public ProductFrom()
        {
            InitializeComponent();
            _productViewModel = new ProductViewModel();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            dgvProduct.DataSource = _productViewModel.FillGrid();
        }
    }
}
