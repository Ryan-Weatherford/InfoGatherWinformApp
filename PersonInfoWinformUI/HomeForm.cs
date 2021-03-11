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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            ListBoxWire(ourPeopleList);
        }

        internal BindingList<PersonModel> ourPeopleList = new BindingList<PersonModel>();
        

        private void btnCreate_Click(object sender, EventArgs e)
        {
            PersonModel newPerson = new PersonModel();
            newPerson.FirstName = textBoxFirstName.Text;
            newPerson.LastName = textBoxLastName.Text;

            AddressForm addressForm = new AddressForm(this, newPerson);
            addressForm.Show();
            addressForm.Activate();
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
        }

        void ListBoxWire(BindingList<PersonModel> list)
        {
            listBoxOurPeople.DataSource = list;
            listBoxOurPeople.DisplayMember = nameof(PersonModel.OurPeopleDisplay);
        }
    }
}
