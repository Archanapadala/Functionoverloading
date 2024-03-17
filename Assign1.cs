
//
namespace Functionoverloading
{

    class InterestCalculator
    {
        public double CalculateInterest(double principal, double rate, double time)
        {
            return (principal * rate * time) / 100;
        }

        public double CalculateInterest(double principal, double rate, double time, int frequency)
        {
            double amount = principal * Math.Pow((1 + rate / (frequency * 100)), frequency * time);
            return amount - principal;
        }
        public double CalculateInterest(double principal, double rate)
        {
            return (principal * rate) / 100;
        }
        public double CalculateInterest(double principal, double rate, double time, double maturityamount)
        {
            return (maturityamount - principal);
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
             InterestCalculator calculator = new InterestCalculator();

            double simpleinterest = calculator.CalculateInterest(2000 , 7 , 4);
            Console.WriteLine("Simple Interest "+simpleinterest);

            double compoundinterest = calculator.CalculateInterest(1000, 5, 2, 12);
            Console.WriteLine("Compound interest " + compoundinterest);

            double savings = calculator.CalculateInterest(1000, 2);
            Console.WriteLine("savings " + savings);

            double fixeddeposit = calculator.CalculateInterest(1000, 6, 2, 1200);
            Console.WriteLine("fixed deposit " + fixeddeposit);
        
        
            }
        }
    
}
