namespace DZ6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var venus = new { Name = "Венера", Number = 2, EquatorLenth = 38052, PreviousPlanet = "null" };
            var earth = new { Name = "Земля", Number = 3, EquatorLenth = 40076, PreviousPlanet = venus };
            var mars = new { Name = "Марс", Number = 4, EquatorLenth = 21344, PreviousPlanet = earth };

            Print(venus);
            Print(earth);
            Print(mars);
            Print(venus);

            bool EqualToVenus(object planet)
            {
                return planet.Equals(venus);
            }

            void Print(object planet)
            {
                Console.WriteLine(planet + " Equal : " + EqualToVenus(planet));
            }
        }
    }
}