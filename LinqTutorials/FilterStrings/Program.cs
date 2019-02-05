using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterStrings
{
    class Program
    {

        delegate bool EvaluateCondition(string value);

        static void Main(string[] args)
        {
            // Create a list of sci-fi shows.

            List<string> scifiShows = new List<string>
        {
            "Star Trek: The Next Generation",
            "Star Trek: Voyager",
            "Star Trek: Deep Space Nine",
            "Battlestar Gallactica",
            "Doctor Who",
            "Stargate SG-1",
            "Stargate Atlantis",
            "Stargate Universe",
            "Futurama"
        };

            // Get a filtered list of shows by calling FilterList() and passing in our 
            // list of shows and a delegate to be used when checking values to be filtered.
            // The delegate uses the string method .StartsWith() to check if the string starts
            // with a certain value.

            IEnumerable<string> filteredList = FilterList(scifiShows, delegate (string value)
            {
                return value.StartsWith("Star");
            });

            // Print each show in the filtered list to the console.

            foreach (string show in filteredList)
            {
                Console.WriteLine(show);
            }
        }

        /// <summary>
        /// Filters a string list based on a delegate function used to check each value in the list.
        /// </summary>
        /// <param name="list">The list to be filtered.</param>
        /// <param name="evaluateCondition">The delegate to be invoked when checking each value.</param>
        /// <returns>The filtered string list.</returns>
        static IEnumerable<string> FilterList(IEnumerable<string> list, EvaluateCondition evaluateCondition)
        {
            //List<string> filteredList = new List<string>();

            foreach (string show in list)
                if (evaluateCondition(show))
                    yield return show;

            //return filteredList;

        }
    }
}
