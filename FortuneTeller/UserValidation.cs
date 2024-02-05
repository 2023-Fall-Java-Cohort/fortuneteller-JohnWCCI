using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    internal class UserValidation
    {
        public static string ValidateFirstName(string name)
        {
            string errorString = string.Empty;
            if(string.IsNullOrEmpty(name))
            {
                errorString = "First Name can not be empty";
            }
            else if(name.Length> 50)
            {
                errorString = "First Name can not be longer then 50 character";
            }
            else
            {
                return name;
            }
            throw new ValidateException(errorString);

        }
        public static string ValidateLastName(string name)
        {
            string errorString = string.Empty;
            if (string.IsNullOrEmpty(name))
            {
                errorString = "Last Name can not be empty";
            }
            else if (name.Length > 50)
            {
                errorString = "Last Name can not be longer then 50 character";
            }
            else
            {
                return name;
            }
            throw new ValidateException(errorString);
        }

        public static int ValidateAge(int howOld) {
        
            string errorString = string.Empty;
            if(howOld < 0)
            {
                errorString = "User's age must be greater then 0";
            }else if(howOld > 130)
            {
                errorString = "User's age must be less then 131";
            }
            else
            {
                return howOld;
            }

            throw new ValidateException(errorString);
        }

        public static int ValidateMonth(int month)
        {
            string errorString = string.Empty;
            if(month <= 0)
            {
                errorString = "Birth Month must be greater then 0";
            }
            else if(month > 12)
            {
                errorString = "Birth month must be less 13";
            }
            else
            {
                return month;
            }
            throw new ValidateException(errorString);
        }

        public static int ValidateSibling(int sibling)
        {
            string errorString = string.Empty;
            if(sibling < 0)
            {
                errorString = "You can't have a siblings less then 0";
            }else if(sibling> 13)
            {
                errorString = "You can't have more the 13 siblings";
            }
            else
            {
                return sibling;
            }
            throw new ValidateException(errorString);
        }

    }
}
