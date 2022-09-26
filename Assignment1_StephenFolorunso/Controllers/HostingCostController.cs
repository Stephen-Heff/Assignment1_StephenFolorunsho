using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_StephenFolorunso.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <example>
        /// GET api/HostingCost/0 -> “1 fortnights at $5.50/FN = $5.50 CAD 
        /// HST 13% = $0.72 CAD 
        /// Total = $6.22 CAD”
        /// </example>
        public dynamic Get(double id)
        {

            
          
            //variables
            int firstFn = 14;
            int secondFn = 28;
            int thirdFn = 42;
            double hst = 0.13;
            double price = 5.50;
            


            //logic

            if (id < firstFn)
            {
                 double  answer = 1 * price;
                double  hstAnswer = answer * hst;
                double total = answer + hstAnswer;
                return "1 fortnights at $" + price + " = $" + answer +
                    Environment.NewLine + "HST 13% = " + Math.Round(hstAnswer, 2) +
                    Environment.NewLine + "Total = $" + Math.Round(total, 2);


            }
            else if (id < secondFn)
            {
                double answer = 2 * price;
                double hstAnswer = answer * hst;
                double total = answer + hstAnswer;
                return "2 fortnights at $" + price + " = $" + answer +
                     Environment.NewLine + "HST 13% = " + Math.Round(hstAnswer, 2) +
                     Environment.NewLine + "Total = $" + Math.Round(total, 2);
            }
            else if(id < thirdFn)
            {
                double answer = 3 * price;
                double hstAnswer = answer * hst;
                double total = answer + hstAnswer;
                return "3 fortnights at $" + price + " = $" + answer + 
                    Environment.NewLine + "HST 13% = " + Math.Round(hstAnswer, 2) + 
                    Environment.NewLine + "Total = $" + Math.Round(total, 2);
            }
            else
            {
                return "Sorry, we do not offer this!";
            }
               


            

        }
    }
}
