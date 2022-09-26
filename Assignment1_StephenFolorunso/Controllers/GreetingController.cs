using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_StephenFolorunso.Controllers
{
    /// <summary>
    /// Display the string "Hello World!"
    /// </summary>
    /// <returns>Hello World!</returns>
    /// <example>
    /// POST api/greeting -> "Hello World"
    /// curl -d "" localhost:51571/api/greeting
    /// </example>
    public class GreetingController : ApiController
    {
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Show the message "Greetings to {id} people!"
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns> "Greetings to {id} people!" </returns>
        public string Get(string id) 
        {
            return "Greetings to " + id + " people!";

        }


    }
}
