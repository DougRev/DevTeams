using DevTeams_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_UI
{
    public class ProgramUI
    {
        private readonly DeveloperRepository _devRepo;
        private readonly DeveloperTeamRepository _devTeamRepo;

        public ProgramUI()
        {
            _devRepo = new DeveloperRepository();
            _devTeamRepo = new DeveloperTeamRepository();
        }

        public void Run()
        {
            RunApplication();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Welcome to dev Teams\n" +
                    "1. Add a Developer\n +" +
                    "2. View All Existing Developers\n +" +
                    "3. View an Existing Developer\n +" +
                    "4. Update An Existing Developer \n +" +
                    "5. Delete An Existing Developer\n");
            }

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    AddADeveloper();
                    break;
                case "2":
                    ViewAllExistingDevelopers();
                    break;
                case "3":
                    ViewAnExistingDeveloper();
                    break;
                case "4":
                    UpdateAnExistingDeveloper();
                    break;
                case "5":
                    DeleteAnExistingDeveloper();
                    break;
                default:
                    Console.WriteLine("Invaled Selection. ");
                    Console.WaitForKey();
                    break;
            }
            Console.Clear();
        }

        private void RunApplication()
        {
            throw new NotImplementedException();
        }

        public void AddADeveloper()
        {

        }
        public void ViewAllExistingDevelopers()
        {

        }
        public void ViewAnExistingDeveloper()
        {

        }
        public void UpdateAnExistingDeveloper()
        {

        }
        public void DeleteAnExistingDeveloper()
        {

        }
    }
}

