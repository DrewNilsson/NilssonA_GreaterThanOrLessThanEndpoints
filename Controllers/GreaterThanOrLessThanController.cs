//Andrew Nilsson
//10/25/22
//Greater Than or Less Than
//This is a webapi that takes 2 int inputs and returns if one of those numbers are greater than the other
//Peer reviewed by: Kenneth Fujimura -- Everything works as it's intended. The inputs all returned what they're supposed to so long as the inputs are whole integers. I like how the function calls ints to pass through but puts out strings. And there's some shortcuts for coding if statements that I didn't know that are useful. Good job, Drew!

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NilssonA_GreaterThanOrLessThanEndpoints.Controllers
{
    [Route("[controller]")]
    public class GreaterThanOrLessThanController : Controller
    {
        [HttpGet]
        [Route("Calculation/{num1}/{num2}")]

        public string Calculation(int num1, int num2)
        {
            if (num1 > num2) return $"{num1} is greater than {num2}";
            if (num1 < num2) return $"{num1} is less than {num2}";

            return $"{num1} is equal to {num2}";
        }
    }
}