/*
 * Sami Alzoubi
 * * CPSC 23000
 * January 18th, 2024
 */

using static System.Console;

namespace ShapeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("*********************************");
            WriteLine("Shape Calculator V1.0");
            WriteLine("*********************************");
            WriteLine();

            // now the real stuff begins
            WriteLine("First, let's deal with a cube");
            Write("What is the width? ");
            double width1;
            string entry;
            entry = ReadLine();
            try
            {
                width1 = double.Parse(entry);
            } catch (FormatException)
            {
                WriteLine("You needed to enter a number.\nSetting it to 0.");
                width1 = 0;
            }
            //get the length now
            Write("What is the length? ");
            double length1;
            string entry2;
            entry2 = ReadLine();
            try
            {
                length1 = double.Parse(entry2);
            }
            catch (FormatException)
            {
                WriteLine("You needed to enter a number.\nSetting it to 0.");
                length1 = 0;
            }
            // get the height done
            Write("What is the height? ");
            double height1;
            string entry3;
            entry3 = ReadLine();
            try
            {
                height1 = double.Parse(entry3);
            }
            catch (FormatException)
            {
                WriteLine("You needed to enter a number.\nSetting it to 0.");
                height1 = 0;
            }

            // get the volume of the cube
            double cubeVolume = width1 * length1 * height1;
            WriteLine($"Volume of the cube is: " + cubeVolume);

            // being the sphere
            WriteLine();
            WriteLine("Now let's deal with a sphere");
            Write("What is the radius? ");
            double radius;
            string entry4;
            entry4 = ReadLine();
            try
            {
                radius = double.Parse(entry4);
            }
            catch (FormatException)
            {
                WriteLine("You needed to enter a number.\nSetting it to 0.");
                radius = 0;
            }

            // calculate the sphere's volume
            double sphereVolume = 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
            WriteLine($"The Volume of the sphere is: " +  sphereVolume);

            WriteLine();
            double totalVolume = cubeVolume + sphereVolume;
            WriteLine($"The total volume of the cube and sphere is: " + totalVolume);

            WriteLine();
            WriteLine("Thank you for using this program.");
        }
    }
}
