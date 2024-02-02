namespace modul2_les4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double TaskThree(double a, double b)
            {
                double sumOfSquaresAandB = Math.Pow(a, 2) + Math.Pow(b, 2);
                double diagonal = Math.Sqrt(sumOfSquaresAandB);

                return diagonal;
            }
        }
    }
}
