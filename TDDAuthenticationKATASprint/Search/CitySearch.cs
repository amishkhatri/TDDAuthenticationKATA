using System;
using System.Collections.Generic;
using System.Text;
using TDDAuthenticationSprint.Search;


namespace TDDAuthenticationSprint.Search
{
    public class CitySearch
    {
        
        public List<String> Search(string keyword)
        {
            List<string> resultData = new List<string>();

            //if (keyword == "umb" || keyword == "une" || keyword == "elh")
            if (KeywordCheck.isSufficientLength(keyword))
            {
                return CitiesContaining(keyword);
            }
            else
                return resultData;
            
        }

        private List<string> CitiesContaining(string keyword)
        {
            List<string> cities = new List<string> { "Mumbai", "Pune", "Delhi", "New Delhi" };

            return cities.FindAll(e => e.Contains(keyword));
        }


    }
}
