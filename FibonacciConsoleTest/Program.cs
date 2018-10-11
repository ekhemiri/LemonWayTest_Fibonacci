using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciConsoleTest
{
    class Program
    {
        /// <summary>
        /// Affichage en mode console du résultat de fibonacci 10.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string urlServer = "http://localhost:3000/";

            HttpClient client = new HttpClient();

            var reponseHttp = client.GetAsync(urlServer + "api/fibonacci/10").Result;

            Console.WriteLine(reponseHttp);
            Console.WriteLine("Le résultat est : " + reponseHttp.Content.ReadAsStringAsync().Result);
            Console.ReadLine();
        }
    }
}
