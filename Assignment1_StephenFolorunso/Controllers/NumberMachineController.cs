using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_StephenFolorunso.Controllers
{
    /// <summary>
    /// apply four mathematical operation to input{id}
    /// </summary>
    /// <param name="(id + 10) / 2 * (id - id)">The input number plus 10 divided by 2 multiplied by the input number minus the input number</param>
    /// <return>return input number({id}/2) * (id-id) </return>
    /// <example>
    /// GET api/numbermachine/1 -> 0
    /// GET api/numbermachine/-5 -> 0
    /// </example>
    public class NumberMachineController : ApiController
    {
        public int Get(int id)
        {
            int answer = (id + 10) / 2 * (id - id);
                return answer;
        }
    }
}
