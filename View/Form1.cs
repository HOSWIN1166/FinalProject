using System.Reflection;
using ViewModel;
using ViewModel.Dtos;

namespace View
{
    public partial class Form1 : Form
    {
        private readonly PersonViewModel _personViewModel;
        private readonly ProductViewModel _productViewModel;
        public Form1()
        {
            InitializeComponent();
            _personViewModel = new PersonViewModel();
            _productViewModel= new ProductViewModel();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PersonFrom personFrom = new PersonFrom();
            personFrom.ShowDialog();
            ProductFrom productFrom = new ProductFrom();
            productFrom.ShowDialog();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region [-Save Person-]
            var personSaveDto = new PersonSaveDto()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
            };
            _personViewModel.Save(personSaveDto);
            MessageBox.Show("Save shod balamisar");
            #endregion
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateFrom updateFrom = new UpdateFrom();
            updateFrom.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteFrom personAndProductDelete = new DeleteFrom();
            personAndProductDelete.ShowDialog();
        }
    }
}