using System;
using System.Collections.Generic;
using System.Linq;

namespace ExLinq
{
    class ExLinq
    {
        public static IEnumerable<string> Filterting()
        {
          var cities = new List<string> { "Arezzo", "Arezzo", "Siena", "Firenze", "Lucca" };
			var query =
				from city in cities
				where city == "Arezzo"
				let cityToUpperCase = city.ToUpper()
				select cityToUpperCase;
			return query;

			
        }
    }
}  

