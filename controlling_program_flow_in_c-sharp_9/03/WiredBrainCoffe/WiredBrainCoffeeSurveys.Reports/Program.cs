using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateTasksReport();
        }

        private static void GenerateTasksReport()
        {
            var tasks = new List<string>();
            // Calculated Values
            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            double overallScore = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.PriceScore) / 4;

            if (Q1Results.CoffeeScore < Q1Results.FoodScore)
            {
                tasks.Add("We need to improve in coffe.");
            }

            if (overallScore > 8.0)
            {
                tasks.Add("The score is great! The team must be rewarded.");
            }
            else
            {
                tasks.Add("Talk with the employees to get new ideas");
            }
            if (responseRate < .33)
            {
                tasks.Add("Research new options o improve response rate.");
            }
            else if (responseRate > .33 && responseRate < .66)
            {
                tasks.Add("Reward participants with free coffe coupom.");
            }
            else
            {
                tasks.Add("Rewards participants with discoun coffe coupon.");
            }

            switch (Q1Results.AreaToImprove)
            {
                case "RewardsProgram":
                    tasks.Add("Revisit the rewards deals.");
                    break;

                case "Cleanliness":
                    tasks.Add("Contact the cleaning vendor");
                    break;

                case "MobileApp":
                    tasks.Add("Contact consulting firm about app.");
                    break;

                default:
                    tasks.Add("Investigate individual comments for ideas");
                    break;
            }
        }
    }
}
