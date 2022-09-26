using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_StephenFolorunso.Controllers
{
    public class AddTencontroller : ApiController
    {
        /// <summary>
        /// Add 10 to input number
        /// </summary>
        /// <param name="id + 10">The input number plus ten</param>
        /// <returns>The input number + 10</returns>
        /// <example>
        /// GET api/AddTen/21 -> 31
        /// GET api/AddTen/0 -> 10
        /// </example>
        public int Get(int id)
        {
            int answer = id + 10;
            return answer;
        }


    }
}
