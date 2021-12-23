using DevTeams_POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_UI
{
    public class Program
    {
        public void Main(string[] args);

            private readonly List<Developer> _developerContext = new List<Developer>();


        private int _count;
        public bool AddaDeveloper(Developer developer)
        {
            if (developer == null)
            {
                return false;
            }

            _count++;
            developer.ID = _count;
            _developerContext.Add(developer);
            return true;
        }

        public List<Developer> ViewAllExistingDevelopers()
        {
            return _developerContext; 
        }

        public List<Developer> ViewAnExistingDeveloper()
        {
            return ViewAllExistingDevelopers();
        }

        public bool UpdateAnExistingDeveloper(string originalDeveloperdata, Developer newdata)
        {
            Developer oldDeveloperdata = _developerContext[0];
            if (oldDeveloperdata == null)
            {
                oldDeveloperdata.ID = newdata.ID;
                oldDeveloperdata.FirstName = newdata.FirstName;
                oldDeveloperdata.LastName = newdata.LastName;
                oldDeveloperdata.HasPluralSights = newdata.HasPluralSights;
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool DeleteExistingDeveloper(Developer existingDeveloper)
        {
            bool deleteDeveloper = _developerContext.Remove(existingDeveloper);
            return deleteDeveloper;
        }
     
    }
}

