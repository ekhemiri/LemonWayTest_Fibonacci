using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FibonacciTest.Controllers
{
    /// <summary>
    /// Classe de routage fibonacci.
    /// </summary>
    public class FibonacciController : ApiController
    {
        // Get api/fibonacci/id
        public int GetFibonnacci(int id)
        {
            FibonacciHelper fiboHelper = new FibonacciHelper();
            return fiboHelper.Fibonacci(id);
        }

    }
}
