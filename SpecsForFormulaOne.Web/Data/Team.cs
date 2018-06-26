namespace SpecsForFormulaOne.Web.Data
{
    public class Team
    {
        public Team(string teamName)
        {
            Name = teamName;
        }

        public int Id { get; }
        public string Name { get; }
    }
}
