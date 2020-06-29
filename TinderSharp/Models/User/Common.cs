using System;
using System.Collections.Generic;
using System.Text;

namespace TinderSharp.Models.User
{

    public enum Gender
    {
        Male = 0,
        Female = 1
    }
    public partial class School
    {
        public bool displayed { get; set; }
        public string metadata_id { get; set; }
        public string name { get; set; }
    }


    



    public partial class Job
    {
        public HideableField HideableField { get; set; }
        public HideableField Title { get; set; }
    }

    public class HideableField
    {
        public bool Displayed { get; set; }
        public string Name { get; set; }
    }

    public partial class SearchPreferences
    {
        // Min age match. Must be 18+
        public int age_filter_min { get; set; }
        // Max age match. Must be higier than MinAge
        public int age_filter_max { get; set; }

        // max search radius in kilometers
        public int distance_filter { get; set; }

        // YOUR gender. 0: Male, 1: Female
        public int Gender { get; set; }

        public bool Validate()
        {
            return age_filter_min >= 18 && age_filter_max > age_filter_min && distance_filter > 0 
                && ( (int)TinderSharp.Models.User.Gender.Female == Gender 
                || (int)TinderSharp.Models.User.Gender.Male == Gender) ;
        }
    }

}
