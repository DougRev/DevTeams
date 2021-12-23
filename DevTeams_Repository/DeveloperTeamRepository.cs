using DevTeams_POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Repository
{
    public class DeveloperTeamRepository
    {
        private readonly List<DevTeam> _devTeamContext = new List<DevTeam>();
       
        private int _count;
        //Create
        public bool AddDevTeam(DevTeam devteam)
        {
            if (devteam == null)
            {
                return false;
            }

            _count++;
            devTeam.Id = _count; 
            _devTeamContext.Add(devteam);
            return true;
        }
        //Read
        public List<DevTeam> GetAllTeams()
        {
            return _devTeamContext;
        }

        //Update
        public bool UpdateExistingDevTeams(string originalDevTeam, DevTeam newdata)
        {
            DevTeam oldDevTeam = GetAllTeams(originalDevTeam);

            if (oldDevTeam !=null)
            {
                oldDevTeam.Id = newdata.Id;
                oldDevTeam.TeamName = newdata.TeamName;
                oldDevTeam.Developers = newdata.Developers;
                return true;
            }

            else
            {
                return false;
            }

            //Delete
            public bool DeleteExistingTeams(DevTeam existingDevTeam)
            {
                bool deleteDevTeam = _devTeamContext.Remove(existingDevTeam);
                return deleteDevTeam;
            }
        }
    }
}
