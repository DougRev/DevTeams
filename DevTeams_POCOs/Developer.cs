using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_POCOs
{
    /*
     * Developers have names and ID numbers;
     * we need to be able to identify one developer without mistaking them for another. 
     * We also need to know whether or not they have access to the online learning tool: Pluralsight.
     */

    public class Developer
    {

        public Developer() { }

        public Developer(int id, string firstName, string lastName, bool hasPluralsights, string teamName, int teamID)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            HasPluralSights = hasPluralsights; 
        }
        //unique identifier
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"(FirstName) (LastName)";
            }
        }
        public bool HasPluralSights { get; set; }
        public string TeamName { get; set; }
        public int TeamID { get; set; }
    }
}
