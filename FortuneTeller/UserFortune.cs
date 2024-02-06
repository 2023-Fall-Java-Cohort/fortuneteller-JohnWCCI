using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    public class UserFortune
    {
        private readonly User user;

        private string[] VacationLocation = {
             "Boca Raton, FL",
             "Nassau, Bahamas",
             "Ponta Negra, Brazil",
             "Portland, Oregon",
             "Baton Rouge, LA" };

        private string[] Transportation =
       {
           "Maserati",
           "Stallion",
           "Chariot",
           "Taxi",
           "Rickshaw",
           "Motor Scooter",
           "Flying saucer"};
        public UserFortune(User user)
        {
            this.user = user;
        }
        public string Transport { get => Transportation[(int)user.FavoriteColor]; }

        public int RetirementYears()
        {
            int years = 14;
            if (user.Age % 2 == 0)
                years = 12;
            return years;
        }

        public string VacationHome()
        {
            if (user.Sibling > 3)
            {
                return VacationLocation[4];
            }
            else
            {
                return VacationLocation[user.Sibling];
            }
        }

        public string BankBalance()
        {
            switch (user.BirthMonth)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    {
                        return "$256,000.76";
                    }
                case 5:
                case 6:
                case 7:
                case 8:
                    {
                        return "$3,687,105.42";
                    }
                case 9:
                case 10:
                case 11:
                case 12:
                    {
                        return "$86.23";
                    }
                default:
                    {
                        return "$0.00";
                    }
            }
        }
        public override string ToString()
        {
            return @$"[{user.FirstName}] [{user.LastName}] 
                        will retire in [{RetirementYears()}] with [{BankBalance()}] in the bank, 
                        a vacation home in [{VacationHome()}], and travel by [{Transport}].";
        }

    }
}
