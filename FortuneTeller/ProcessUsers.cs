using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    public class ProcessUsers
    {
        private readonly ConsoleDisplay display;

        public ProcessUsers(ConsoleDisplay display)
        {
            this.display = display;
        }

        public void StartProcess()
        {
            int controlDisplay = 0;
            while (true)
            {
                User user = new User();
                while (true)
                {
                    try
                    {
                        switch (controlDisplay)
                        {
                            case 0:
                                {
                                    display.ClearScreen("Type Quit to exit!!");
                                    break;
                                }
                            case 1:
                                {
                                    user.FirstName = display.PromptInput("First Name:");
                                    break;
                                }
                            case 2:
                                {
                                    user.LastName = display.PromptInput("Last Name:");
                                    break;
                                }
                            case 3:
                                {
                                    user.Age = int.Parse(display.PromptInput("Age:", true));
                                    break;
                                }
                            case 4:
                                {
                                    user.BirthMonth = int.Parse(display.PromptInput("Birth Month:", true));
                                    break;
                                }
                            case 5:
                                {
                                    user.Sibling = int.Parse(display.PromptInput("Siblings:", true));
                                    break;
                                }
                            case 6:
                                {
                                    user.FavoriteColor = ParseEnum(display.PromptInput("Favorite Color:", false, GetColorString()));
                                    break;
                                }
                        }
                        controlDisplay++;
                        if (controlDisplay > 6)
                        {
                            break;
                        }
                    }
                    catch(ValidateException ve)
                    {
                        Console.WriteLine($"\n{ve.Message}\n");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine($"\n{ex.Message}\n");
                        break;
                    }
                }
                UserFortune userFortune = new UserFortune(user);
                display.ClearScreen("Your fortune is: ");
                Console.WriteLine(userFortune);
                Console.ReadLine();
                controlDisplay = 0;

            }
        }
        /// <summary>
        /// Gets the color string.
        /// </summary>
        /// <returns>a list of valid colors</returns>
        private string GetColorString()
        {
            string retValue = "The Colors are: ";
            for(int x = 0; x < (int)RoygbivEnum.Max; x++)
            {
                retValue += $"{(RoygbivEnum)x}, ";
            }
            return retValue;
        }

        /// <summary>
        /// Parses the RoygbivEnum.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>valid RoygbivEnum</returns>
        /// <exception cref="FortuneTeller.ValidateException"></exception>
        private RoygbivEnum ParseEnum(string value)
        {
            try
            {
                return (RoygbivEnum)Enum.Parse(typeof(RoygbivEnum), value, true);
            }
            catch
            {

                throw new ValidateException($"{value} - Color not found");
            }
        }
    }
}
