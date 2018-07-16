using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_P5_FunWithEnums
{
    // A custom enumeration.
    enum EmpType
    {
        Manager,
        Grunt, 
        Contractor,
        VicePresident
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 4 - Project 5 - Enums in C# \n");

            #region Declaring Enum Variable

            EmpType type = EmpType.Contractor;

            //type = EmpType.abc; // error
            //type = abc; // error

            //AskforBonus(type);

            #endregion

            #region System.Enum Type

            //EmpType emp = EmpType.Contractor;

            //Type type1;

            //type1 = Enum.GetUnderlyingType(emp.GetType());

            //// Print storage for the enum.
            //Console.WriteLine("EmpType uses a {0} for storage", Enum.GetUnderlyingType(emp.GetType()));
            //Console.WriteLine("EmpType uses a {0} for storage", Enum.GetUnderlyingType(typeof(EmpType)));
            //Console.WriteLine("EmpType uses a {0} for storage", type1);
            //Console.WriteLine("EmpType uses a {0} for storage", typeof(EmpType));


            #endregion

            #region Dynamically Discovering an Enum's Name-Value Pairs

            EmpType emp = EmpType.Contractor;

            // Prints out "emp is a Contractor".
            //Console.WriteLine("emp is a {0}.", emp.ToString());
            //Console.WriteLine("value of emp is {0}.", (int)emp);

            EmpType e2 = EmpType.Contractor;
            // These types are enums in the System namespace.
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;
            EvaluateEnum(e2);
            //EvaluateEnum(day);
            //EvaluateEnum(cc);

            #endregion

            Console.ReadLine();
        }

        // This method will print out the details of any enum.
        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("=> Information about {0}", e.GetType().Name);
            Console.WriteLine("Underlying storage type: {0}",Enum.GetUnderlyingType(e.GetType()));
            
            // Get all name-value pairs for incoming parameter.
            //Array enumData = Enum.GetValues(e.GetType());
            //Array enumData = Enum.GetValues(e.GetType());
            Array enumData = Enum.GetValues(e.GetType());

            Console.WriteLine("This enum has {0} members.", enumData.Length);
            // Now show the string name and associated value, using the D format
            // flag (see Chapter 3).
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
            }
            Console.WriteLine();
        }

        private static void AskforBonus(EmpType type)
        {
            switch (type)
            {
                case EmpType.Manager:
                    break;
                case EmpType.Grunt:
                    break;
                case EmpType.Contractor:
                    break;
                case EmpType.VicePresident:
                    break;
                default:
                    break;
            }
        }
    }
}
