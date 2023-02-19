using ViewModel;
using ViewModel.Dtos;

namespace View
{
    public partial class PersonAndProductDelete : Form
    {
        private readonly PersonViewModel _personViewModel;
        private readonly ProductViewModel _productViewModel;
        public PersonAndProductDelete()
        {
            InitializeComponent();
            _personViewModel = new PersonViewModel();
            _productViewModel = new ProductViewModel();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var Input = txtPersonDelete.Text;
            var PersonId = int.Parse(Input);
            var personDeleteDto = new PersonDeleteDto()
            {
                Id= PersonId,
            };
            _personViewModel.Delete(personDeleteDto);
            MessageBox.Show("Delete Kardiaaa , dir omadi zod naro");

            var productDeleteDto = new ProductDeleteDto()
            {
                Id = System.Convert.ToInt32(txtProductDelete.Text.ToString()),
            };
            _personViewModel.Delete(productDeleteDto);
            MessageBox.Show("Delete Kardiaaa , dir omadi zod naro");
        }
    }
}
