using Moq;
using NUnit.Framework;
using SpecsFor;
using SpecsForFormulaOne.Mvc.Data;
using SpecsForFormulaOne.Mvc.Services;
using Should;

namespace SpecsForFormulaOne.Specs
{
    public class TeamsManagerSpecs
    {
        public class given_a_valid_teams_repository_is_available : SpecsFor<TeamsManager>
        {
            protected override void Given()
            {
                GetMockFor<IRepository<Team>>()
                    .Setup(r => r.GetById(It.IsAny<int>()))
                    .Returns(new Team("Red Bull"));
            }

            protected override void When()
            {
                SUT.AddTeam("Red Bull");
            }

            [Test]
            public void then_the_created_team_will_be_added_to_the_repository()
            {
                GetMockFor<IRepository<Team>>().Verify(r => r.Add(It.IsAny<Team>()), Times.Once);
            }

            [Test]
            public void and_then_the_created_team_will_be_persisted_to_the_datastore()
            {
                GetMockFor<IRepository<Team>>().Verify(r => r.SaveChanges(), Times.Once);
            }
        }

        public class given_a_valid_teams_repository_containing_a_team : SpecsFor<TeamsManager>
        {
            Team _result;

            protected override void Given()
            {
                GetMockFor<IRepository<Team>>()
                    .Setup(repo => repo.GetById(It.IsAny<int>()))
                    .Returns(new Team("Red Bull"));
            }

            protected override void When()
            {
                _result = SUT.GetTeam(1);
            }

            [Test]
            public void then_a_team_instance_is_returned()
            {
                _result.ShouldNotBeNull();
            }
        }
    }
}
