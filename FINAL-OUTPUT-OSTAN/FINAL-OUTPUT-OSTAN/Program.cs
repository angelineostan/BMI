using System;
namespace BMI
{
    class Program
    {
        static void Main()
        {
            /* Xiad Chin is applying for a job that requires a normal weight and she's wondering if she's in the normal weight range or not.
               If not, she can lose or gain weigth to qualify for the job she's applying for.
            
               Xiad Chin's height in meters is: 1.50
               and here weight in kilograms is : 55 
            
               The expected output would be 24.4 and her weight is normal.*/

            Console.Write("\n\n");
            Console.Write("\t BMI Calculator \t\n");
            Console.WriteLine("\t________________\t");
            Console.Write("\n\n");


            Console.Write("Enter your Height in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter your Weight in kilograms: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\n");
            double BMI = weight / (height * height);
            Console.WriteLine("Your BMI is " + BMI);

            if (BMI < 18.5)
            {
                Console.WriteLine("You are Underweight");
            }
            else if (BMI <= 24.9)
            {
                Console.WriteLine("Your weight is Normal");
            }
            else if (BMI <= 29.9)
            {
                Console.WriteLine("You are Overweight");
            }
            else if (BMI <= 34.9)
            {
                Console.WriteLine("You are Obese Class I");
            }
            else if (BMI <= 39.9)
            {
                Console.WriteLine("You are Obese Class II");
            }
            else if (BMI <= 40)
            {
                Console.WriteLine("You are Obese Class III");
            }
            else
            {
                Console.WriteLine("Cannot Be Classified");
            }

        }
    }
}