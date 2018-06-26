using SpecsForFormulaOne.Mvc.Data;

namespace SpecsForFormulaOne.Mvc.Services
{
    public class TeamsManager
    {
        private readonly IRepository<Team> teamsRepository;

        public TeamsManager(IRepository<Team> teamsRepository)
        {
            this.teamsRepository = teamsRepository;
        }

        public void AddTeam(string teamName)
        {
            var newTeam = new Team(teamName);
            teamsRepository.Add(newTeam);

            teamsRepository.SaveChanges();
        }

        public Team GetTeam(int id)
        {
            return teamsRepository.GetById(id);
        }
    }
}
