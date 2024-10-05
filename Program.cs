
namespace FishClass
{
    public class Fish
    {
        public int numberOfFishes;
        public string Species {
            get;
            set;
        }
        public double PricePerFish
        {
            get; set;
        }
        public class FishUtilityClass : Fish
        {
            public void AddFish(string Species, double PricePerFish)
            {
                this.Species = Species;
                this.PricePerFish = PricePerFish;
                Console.WriteLine(Species);
                Console.WriteLine(PricePerFish);
            }
            public bool Buyfish(string species)
            {

                return (
                    species.Equals("Clownfish", StringComparison.Ordinal) ||
                    species.Equals("Goldfish", StringComparison.Ordinal)
                    );
                
            }
            public double CalculatePrice(int numberOfFishes, string species)
            {
  
                if (species.Equals("Clownfish", StringComparison.Ordinal))
                {
                    return numberOfFishes * PricePerFish + 100;
                }
                else if (species.Equals("Goldfish", StringComparison.Ordinal))
                {
                    return numberOfFishes * PricePerFish + 150;
                }
                return 0;
            }

            static void Main(string[] args)
            {
                FishUtilityClass fis = new FishUtilityClass();
               
                Console.WriteLine("enter the species to buy");

                string Species = Console.ReadLine();

                bool val = fis.Buyfish(Species);
                if (val == false)
                {
                    Console.WriteLine("species not found");
                }

                Console.WriteLine("enter the price per fish:");
                fis.PricePerFish = double.Parse(Console.ReadLine());
                double rate1 = fis.PricePerFish;

                Console.WriteLine("enter the number of fishes you need to buy:");
                fis.numberOfFishes = int.Parse(Console.ReadLine());
                int value1 = fis.numberOfFishes;

                double Price = fis.CalculatePrice(value1,Species);
                Console.WriteLine("total cost is:" + Price);

            }
        }
    }
}




