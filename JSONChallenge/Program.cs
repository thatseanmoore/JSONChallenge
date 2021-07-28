using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Sean";
            person.LastName = "Moore";
            person.DOB = new DateTime(1993, 12, 8);
            person.FavoriteIceCreamFlavors = new List<string>
            { "Vanilla", "Cookies and Cream"};

            string json = JsonConvert.SerializeObject(person);

            Console.WriteLine(json);

            Console.ReadKey();
        }
    }
}
