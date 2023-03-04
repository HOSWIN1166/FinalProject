using ViewModel;
using ViewModel.Dtos;

namespace View
{
    public partial class DeleteFrom : Form
    {
        private readonly PersonViewModel _personViewModel;
        private readonly ProductViewModel _productViewModel;
        public DeleteFrom()
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
            MessageBox.Show("Person Deleted");
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {

        }
    }
}