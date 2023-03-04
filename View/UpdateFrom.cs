using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModel.Dtos;
using ViewModel;

namespace View
{
    public partial class UpdateFrom : Form
    {
        private readonly PersonViewModel _personViewModel;
        private readonly ProductViewModel _productViewModel;
        public UpdateFrom()
        {
            InitializeComponent();
            _personViewModel = new PersonViewModel();
            _productViewModel = new ProductViewModel();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPersonUpdate_Click(object sender, EventArgs e)
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
    }
}
