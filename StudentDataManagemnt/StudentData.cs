using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataManagemnt
{
    internal class StudentData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int PhoneNo { get; set; }

        // creating an override method just to print student details.
        public override string ToString()
        {
            return $"ID:{Id} Name: {Name} Age:{Age} Address: {Address} PhoneNo: {PhoneNo}";
        }
    }
}
