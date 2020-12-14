using System;
using System.Collections.Generic;
using  System.Linq;
namespace Mountain

{
        class Peaks

        {
            public static void FirstColumn(string separator,string source)
            {
                IEnumerable<string> firstColumnQuery=
                    from element in source.Split(separator)
                    let trimmed = element.Trim()                  
                    let splitted = trimmed.Split(",")[0]
                    where splitted.Contains("Monte Falterona")
                    select splitted;

          foreach (var peaks in firstColumnQuery)
          {
              Console.WriteLine(peaks);
          }
            }
        }












}