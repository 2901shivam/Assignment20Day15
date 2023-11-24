using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20Day15
{
    public class ExceptionHandeling
    {
        public void EnterAge()
        {
            do
            {
                Console.WriteLine("Enter yor age to check your are minor/adult/senior");
                int age = int.Parse(Console.ReadLine());
                try
                {
                    if (age > 0 && age < 18)
                    {
                        Console.WriteLine("Person is minor");
                    }
                    else if (age >= 18 && age < 65)
                    {
                        Console.WriteLine("Person is adult");
                    }
                    else
                    {
                        Console.WriteLine("Person is senior");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error Occured" + e.Message);
                }
            }
            while (false);
           
        }
        
        
    }
}
