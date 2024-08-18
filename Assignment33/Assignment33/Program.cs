using System;

namespace Assignment
{
    class Question3
    {
        public static void Main(string[] args)
        {
            const double rateUpto199 = 1.20;
            const double rate200To399 = 1.50;
            const double rate400To599 = 1.00;
            const double rate600AndAbove = 2.00;
            const double minimumBill = 100.00;
            const double surchargeThreshhold = 400.00;
            const double surchargePercentage = 0.15;




            Console.WriteLine("Welcome on app");
            

            Console.WriteLine("Enter your CustomId:");
            int cId=byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Name:");
            string cName= Console.ReadLine();

            Console.WriteLine("Enter your used units:");
            double unit = byte.Parse(Console.ReadLine());

            double initialBill = 0;
            if (unit <= 199)
            {
                initialBill=unit*rateUpto199;
            }
            else if(unit>=200 && unit<=399){
                initialBill*=unit*rate200To399;

            }
            else if(unit>=400 && unit <= 599)
            {
                initialBill = unit * rate400To599;
            }
            else {
                initialBill = initialBill * rate600AndAbove;
            }
            double finalFill = initialBill;
            if (initialBill > surchargeThreshhold)
            {
                double surcharge = initialBill * surchargePercentage;
                finalFill = finalFill + surcharge;
            }

            if (finalFill < minimumBill)
            {
                finalFill = minimumBill;
            }
                    Console.WriteLine($"Total bill: {finalFill:F2}");
                  
            
        }
    }
}