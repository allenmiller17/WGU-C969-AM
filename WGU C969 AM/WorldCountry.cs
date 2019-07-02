using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGU_C969_AM
{
    public class WorldCountry
    {
        public WorldCountry()
        {
            Name = null;
            Alpha2Code = null;
            Alpha3Code = null;
            NumericCode = null;
            Enabled = false;
        }

        public WorldCountry(string name, string alpha2Code, string alpha3Code, string numericCode, bool enabled)
        {
            Name = name;
            Alpha2Code = alpha2Code;
            Alpha3Code = alpha3Code;
            NumericCode = numericCode;
            Enabled = enabled;
        }

        public string Name { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public string NumericCode { get; set; }
        public bool Enabled { get; set; }

        public override string ToString()
        {
            //Returns "USA - United States"
            return string.Format("{0} - {1}", Alpha3Code, Name);
        }
    }

    public class CountryArray
    {
        public List<WorldCountry> countries;
        public CountryArray()
        {
            countries = new List<WorldCountry>(3);
            countries.Add(new WorldCountry("Canada", "CA", "CAN", "124", true));
            countries.Add(new WorldCountry("Mexico", "MX", "MEX", "484", false));
            countries.Add(new WorldCountry("United States", "US", "USA", "840", true));

        }

        /// <summary>
        /// List of 3 digit abbreviated country codes
        /// </summary>
        /// <returns></returns>
        public string[] Alpha3Codes()
        {
            List<string> abbrevList = new List<string>(countries.Count);
            foreach (var country in countries)
            {
                if (country.Enabled)
                    abbrevList.Add(country.Alpha3Code);
            }
            return abbrevList.ToArray();
        }

        /// <summary>
        /// List of 2 digit abbreviated country codes
        /// </summary>
        /// <returns></returns>
        public string[] Alpha2Codes()
        {
            List<string> abbrevList = new List<string>(countries.Count);
            foreach (var country in countries)
            {
                if (country.Enabled)
                    abbrevList.Add(country.Alpha2Code);
            }
            return abbrevList.ToArray();
        }

        /// <summary>
        /// List of Country names
        /// </summary>
        /// <returns></returns>
        public string[] Names()
        {
            List<string> nameList = new List<string>(countries.Count);
            foreach (var country in countries)
            {
                if (country.Enabled)
                    nameList.Add(country.Name);
            }
            return nameList.ToArray();
        }

        /// <summary>
        /// List of Countries
        /// </summary>
        /// <returns></returns>
        public WorldCountry[] Countries()
        {
            return countries.Where(c => c.Enabled == true).ToArray();
        }
    }
}
