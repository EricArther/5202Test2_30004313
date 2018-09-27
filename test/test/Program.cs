/*------------------------------
Ayumu Nesfield (30004313)
comp 5202 test2
------------------------------*/

/*------------------------------
this program will capture infomation about a bird from the userinput and output the information on the console
------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting the default data
            Bird bird1 = new Bird("Name Unknown", "Species Unknown", "Sex Unknown", "Weight Unknown", "Band Number Unknown");

            //telling the user that defaul data is loaded
            Console.WriteLine("bird object created and default data loaded...");

            //blank line
            Console.WriteLine();
            //telling the user to input the data
            Console.WriteLine("please update bird data.");
            
            //blank line
            Console.WriteLine();
            //asking the user for the input
            Console.Write("enter name of bird: ");
            //assigning the user input to the valuable
            string birdName = Console.ReadLine();
            //asking the user for the input
            Console.Write("enter species of bird: ");
            //assigning the user input to the valuable
            string birdSpecies = Console.ReadLine();
            //asking the user for the input
            Console.Write("enter sex of bird: ");
            //assigning the user input to the valuable
            string birdSex = Console.ReadLine();
            //asking the user for the input
            Console.Write("enter weight of bird: ");
            //assigning the user input to the valuable
            string birdWeight = Console.ReadLine();
            //asking the user for the input
            Console.Write("enter band number of the bird: ");
            //assigning the user input to the valuable
            string birdBandNo = Console.ReadLine();

            //creating the bird ofject from data the user input
            bird1 = new Bird(birdName, birdSpecies, birdSex, birdWeight, birdBandNo);

            //colling the method
            bird1.displayBird();

            Console.ReadKey();
        }

        public class Bird{
            //auto-implememted properties
            public string Name { get; set; }
            public string Species { get; set; }
            public string Sex { get; set; }
            public string Weight { get; set; }
            public string BandNo { get; set; }

            //the constructor that contains 5 strings (name, species, sex, weight and band number)
            public Bird(string _name, string _species, string _sex, string _weight, string _bandNo)
            {
                Name = _name;
                Species = _species;
                Sex = _sex;
                Weight = _weight;
                BandNo = _bandNo;
            }

            //a method to display bird information
            public void displayBird()
            {
                //blank line
                Console.WriteLine();
                //displaying the name
                Console.WriteLine($"Name: {Name}");
                //displaying the species
                Console.WriteLine($"Species: {Species}");
                //displaying the sex
                Console.WriteLine($"Sex: {Sex}");
                //displaying the weight
                Console.WriteLine($"Weight: {Weight}");
                //displaying theband number
                Console.WriteLine($"BandNo: {BandNo}");
            }
        }
    }
}
