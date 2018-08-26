using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace thing_2._1
{
    class Quantile
    {
        public static double StudQuan(double alfa, int Nu)
        {
            if (alfa < 0 || alfa > 1)
            {
                Console.WriteLine("Shiet");
            }
            //if (Nu <= 60)
            {
                double quan = StanQuanDv(alfa);
                double g1 = 0.25 * (quan * quan * quan + quan);
                double g2 = (1.0 / 96) * (5 * Math.Pow(quan, 5) + 16 * quan * quan * quan + 3 * quan);
                double g3 = (1.0 / 384) * (3 * Math.Pow(quan, 7) + 19 * Math.Pow(quan, 5) + 17 * quan * quan * quan + 15 * quan);
                double g4 = (1.0 / 92160) * (79 * Math.Pow(quan, 9) + 779 * Math.Pow(quan, 7) + 1482 * Math.Pow(quan, 5) - 1920 * quan * quan * quan - 945 * quan);
                return quan + (1.0 / Nu) * g1 + (1.0 / (Nu * Nu)) * g2 + (1.0 / (Nu * Nu * Nu)) * g3 + (1.0 / (Nu * Nu * Nu * Nu)) * g4;
            }
            //else
            {
            //    return StanQuanOdn(alfa);
            }
        }
        public static double HirsQuan(double alfa, int Nu)
        {
            if (alfa < 0 || alfa > 1)
            {
                Console.WriteLine("Shiet");
            }
           /* double lil = StanQuanOdn(alfa);
            double lal = (1 - (2.0 / (Nu * 9)) + Math.Sqrt((2.0 / (Nu * 9))) * StanQuanDv(alfa));
            double lol = StanQuanDv(alfa);
            double x1 = (Nu * Math.Pow((1 - (2.0 / (Nu * 9)) + Math.Sqrt((2.0 / (Nu * 9))) * StanQuanDv(alfa)), 3));
            double x2 = (Nu * Math.Pow((1 - (2.0 / (Nu * 9)) + Math.Sqrt((2.0 / (Nu * 9))) * StanQuanOdn(alfa)), 3));*/
            return (Nu * Math.Pow((1 - (2.0 / (Nu * 9)) + Math.Sqrt((2.0 / (Nu * 9))) * StanQuanDv(alfa)), 3));
        }
        public static double StanQuanDv(double alfa)
        {
            if (alfa < 0 || alfa > 1)
            {
                Console.WriteLine("Shiet");
            }
            double t = Math.Sqrt(Math.Log(1.0/(alfa*alfa)));
            double c0 = 2.515517;
            double c1 = 0.802853;
            double c2 = 0.010328;
            double d1 = 1.432788;
            double d2 = 0.1892659;
            double d3 = 0.001308;
            return t - (c0+c1*t+c2*t*t)/(1+d1*t+d2*t*t+d3*t*t*t);

        }
        public static double StanQuanOdn(double alfa)
        {
            if (alfa < 0 || alfa > 1)
            {
                Console.WriteLine("Shiet");
            }
            if (alfa <= 0.5)
            {
                return StanQuanDv(alfa);//-1*????
            }
            else
            {
                return StanQuanDv(1 - alfa);
            }
        }
        public static double FishQuan(double alfa,double Nu1, double Nu2)
        {
            if (alfa < 0 || alfa > 1)
            {
                Console.WriteLine("Shiet");
            }
            double quan = StanQuanOdn(alfa);
            double sigma = 1.0 / Nu1 + 1.0 / Nu2;
            double delta = 1.0 / Nu1 - 1.0 / Nu2;
            double a1 = quan * Math.Sqrt(sigma / 2);
            double a2 = (1.0 / 6) * delta * (quan * quan + 2);
            double a3 = Math.Sqrt(sigma / 2)*((sigma/24)*(quan*quan + 3*quan)+((delta*delta)/(72*sigma))*(quan*quan*quan+11*quan));
            double a4 = ((delta*sigma)/(120))*(Math.Pow(quan,4)+9*quan*quan+8);
            double a5 = ((delta * delta * delta) / (3240 * sigma)) * (3 * Math.Pow(quan, 4) + 7 * quan * quan - 16);
            double a61 = ((sigma*sigma)/(1920))*(Math.Pow(quan,5)+20*quan*quan*quan+15*quan);
            double a62 = (Math.Pow(delta,4)/2880)*(Math.Pow(quan,5)+44*quan*quan*quan+183*quan);
            double a63 = (Math.Pow(delta, 4) / (sigma*sigma*2880))*(9*Math.Pow(quan,5)-284*quan+1513*quan);
            double a6 = Math.Sqrt(sigma / 2) * (a61 + a62 + a63);
            double zet = a1 - a2 + a3 - a4 + a5 + a6;
            double result = Math.Exp(2*zet);
            return result;
        }
    }
}
