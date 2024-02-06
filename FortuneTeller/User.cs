using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    public class User
    {
        private string firstName = null!;
        private string lastName = null!;
        private int age;
        private int birthMonth;
        private int sibling;
        private RoygbivEnum color;

        public string LastName { get => lastName; set => lastName = UserValidation.ValidateLastName(value); }

        public int Age { get => age; set => age =UserValidation.ValidateAge(value); }

        public int BirthMonth { get => birthMonth; set => birthMonth = UserValidation.ValidateMonth(value); }

        public int Sibling { get => sibling; set => sibling =UserValidation.ValidateSibling(value); }

        public RoygbivEnum FavoriteColor { get => color; set => color = value;  }

        public string FirstName { get => firstName; set => firstName = UserValidation.ValidateFirstName(value); }
        
    }
}
