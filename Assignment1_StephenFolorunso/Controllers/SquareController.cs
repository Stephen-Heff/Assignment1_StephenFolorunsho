using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_StephenFolorunso.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Return the square of the integer input{id}
        /// </summary>
        /// <param name = "(int)Math.Pow(id,2)"></param> or 
        /// <param name="id * id">The input number multiplied by itself</param>
        /// <returns>The input number squared</returns>
        /// <example>
        /// GET api/square/2 -> 4
        /// GET api/square/10 -> 100
        /// </example>

        public int Get(int id)
        {
            //int answer = (int)Math.Pow(id,2);
            int answer = id * id;
            return answer;
        }


    }
}
