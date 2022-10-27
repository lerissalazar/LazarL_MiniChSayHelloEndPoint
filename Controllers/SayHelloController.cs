//Lerissa Lazar
//10-25-22
//SayHello
//This is a webapi that gets inputs (name) and returns a sentence "Hello (name)"
//peer review: Marcel R. Program ran smooth, asked for a string and placed my name as the input. Output my name saying hello. It was nice to see :)

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LazarL_MiniChSayHello.Controllers
{
    [Route("[controller]")]
    public class SayHelloController : Controller
    {
        [HttpGet]
        [Route("Hello/{name}")]
        public string SayHello(string name)
        {
            return $"Hello {name}";
        }
    }
}