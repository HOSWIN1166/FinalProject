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
          
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(txtUpdateIdPerson.Text.ToString());
            var firstName = txtUpdateFname.Text.ToString();
            var lastName = txtUpdateLname.Text.ToString();
            var personUpdateDto = new PersonUpdateDto()
            {
                Id = id,
                NewFirstName = firstName,
                NewLastName = lastName,
            };
            _personViewModel.Update(personUpdateDto);
            MessageBox.Show("Updated succesfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var Input = txtPersonDelete.Text;
            var PersonId = int.Parse(Input);
            var personDeleteDto = new PersonDeleteDto()
            {
                Id = PersonId,
            };
            _personViewModel.Delete(personDeleteDto);
            MessageBox.Show("Person Deleted");
        }
    }
}