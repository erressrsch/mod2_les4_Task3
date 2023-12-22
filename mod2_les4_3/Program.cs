namespace modul2_les4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static double diagonal(double width = 0, double length = 0)
            {
                int number = 2;

                Console.WriteLine("Enter width: ");
                width = double.Parse(Console.ReadLine());
                width = Math.Pow(width, number);

                Console.WriteLine("Enter length: ");
                length = double.Parse(Console.ReadLine());
                length = Math.Pow(length, number);

                return Math.Sqrt(width + length);


            }
            Console.WriteLine(diagonal());
        }
    }
}