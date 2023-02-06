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
            dgvPerson.DataSource = _personViewModel.FillGrid();
            dgvProduct.DataSource = _productViewModel.FillGrid();
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
            var productSaveDto = new ProductSaveDto()
            {
                Title=txtTitle.Text,
                UnitPrice =txtUnitPrice.Text,
            };
            _productViewModel.Save(productSaveDto);
            MessageBox.Show("Save shod zay");
        }
    }
}