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
using ViewModel.Dtos;

namespace View
{
    public partial class ProductPage : Form
    {
        private readonly ProductViewModel _productViewModel;
        public ProductPage()
        {
            InitializeComponent();
            _productViewModel= new ProductViewModel();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ProductFrom productFrom = new ProductFrom();
            productFrom.ShowDialog();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region [-Save Product-]
            var productSaveDto = new ProductSaveDto()
            {
                Title = txtTitle.Text,
                UnitPrice = System.Convert.ToInt32(txtUnitPrice.Text),
            };
            _productViewModel.Save(productSaveDto);
            MessageBox.Show("Save shod zay");
            #endregion
        }
    }
}
