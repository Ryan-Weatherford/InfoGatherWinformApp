using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonInfoLibrary;

namespace PersonInfoWinformUI
{
    public partial class AddressForm : Form
    {
        HomeForm _homeForm;
        PersonModel _newPerson;

        public AddressForm(HomeForm homeForm, PersonModel newPerson)
        {
            InitializeComponent();
            _homeForm = homeForm;
            _newPerson = newPerson;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            _newPerson.Address.Street = textBoxStreet.Text;
            _newPerson.Address.City = textBoxCity.Text;
            _newPerson.Address.State = textBoxState.Text;
            _newPerson.Address.ZipCode = textBoxZipCode.Text;
            _homeForm.ourPeopleList.Add(_newPerson);
            this.Close();
            _homeForm.Activate();
        }
    }
}
