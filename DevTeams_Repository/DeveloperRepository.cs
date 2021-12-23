using DevTeams_POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Repository
{
    public class DeveloperRepository
    {
        private readonly List<Developer> _developerContext = new List<Developer>();
        private int _count;

        public bool AddContentToDirectory(Developer newDev)
        {
            if (newDev == null)
            {
                return false;
            }
            else
            {
                _count++;
                newDev.ID = _count;
                _developerContext.Add(newDev);
                return true;
            }
        }

        public List<Developer> GetAllContent()
        {
            return _developerContext;
        }

        public List<Developer> GetAllDeveloperByHasPluralSight()
        {
            List<Developer> hasPluralSight = new List<Developer>();
            foreach (Developer content in _developerContext)
            {
                if (content .HasPluralSights)
                {
                    hasPluralSight.Add(content);
                }
            }
            return hasPluralSight;
        }

        public 
    }
}
