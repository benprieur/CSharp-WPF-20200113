using System.Collections.Generic;

namespace Countries
{
    class M
    {

        public Dictionary<string, string> GetCountries()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("France", "Paris");
            dict.Add("Spain", "Madrid");
            return dict;
        }
    }
}
