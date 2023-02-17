using Microsoft.VisualBasic;
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
            var personDeleteDto = new PersonAndProductDeleteDto()
            {
                Id = System.Convert.ToInt32(txtDelete.Text),
            };
            _personViewModel.Delete(personDeleteDto);
            MessageBox.Show("Delete Kardiaaa , dir omadi zod naro");
            var ProductDeleteDt = new PersonAndProductDeleteDto()
            {
                Id = System.Convert.ToInt32(txtDelete.Text),
            };
            _personViewModel.Delete(ProductDeleteDt);
            MessageBox.Show("Delete Kardiaaa , dir omadi zod naro");
        }
    }
}
