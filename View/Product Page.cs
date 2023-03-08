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
            dgvProduct.DataSource = _productViewModel.FillGrid();
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(txtUpdateIdProduct.Text.ToString());
            var title = txtUpdateTitle.Text.ToString();
            var unitPrice = Int32.Parse(txtUpdateUnitPrice.Text.ToString());
            var productUpdateDto = new ProductUpdateDto()
            {
                Id = id,
                Title = title,
                UnitPrice = unitPrice,
            };
            _productViewModel.Update(productUpdateDto);
            MessageBox.Show("Updated succesfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var Input = txtProductDelete.Text;
            var PersonId = int.Parse(Input);
            var productDeleteDto = new ProductDeleteDto()
            {
                Id = PersonId,
            };
            _productViewModel.Delete(productDeleteDto);
            MessageBox.Show("Product Deleted");
        }
    }
}
