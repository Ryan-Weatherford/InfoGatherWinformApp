using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoLibrary
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public AddressModel Address { get; set; } = new AddressModel();
        public string FullAddress => $"{Address.Street},  {Address.City},  {Address.State},  {Address.ZipCode}";
        public string OurPeopleDisplay => $"{FullName}:  {FullAddress}";
       
    }

   
}
