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
    public partial class PersonFrom : Form
    {
        private readonly PersonViewModel _personViewModel;
        public PersonFrom()
        {
            InitializeComponent();
            _personViewModel = new PersonViewModel();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            dgvPerson.DataSource = _personViewModel.FillGrid();
        }
    }
}
