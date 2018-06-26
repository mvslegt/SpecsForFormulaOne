using SpecsForFormulaOne.Web.Data;
using SpecsForFormulaOne.Web.Models;

namespace SpecsForFormulaOne.Web.Services
{
    public class TeamsManager
    {
        private readonly IRepository<Team> teamsRepository;

        public TeamsManager(IRepository<Team> teamsRepository)
        {
            this.teamsRepository = teamsRepository;
        }

        public Result<Team> AddTeam(string teamName)
        {
            var newTeam = new Team(teamName);
            teamsRepository.Add(newTeam);

            return new Result<Team>(teamsRepository.GetById(newTeam.Id));
        }
    }
}
