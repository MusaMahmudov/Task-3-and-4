using Task3;

List<Team> teams = new List<Team>
            {
                new Team(12), new Team(14), new Team(4), new Team(1), new Team(25),
                new Team(43), new Team(10), new Team(34), new Team(53), new Team(13),
                new Team(32), new Team(33), new Team(74), new Team(45), new Team(94),
                new Team(46), new Team(94), new Team(87), new Team(67), new Team(92)
            };

teams.Sort();
var firstThreeTeams = teams.Take(3);
int sumOfPoints = firstThreeTeams.Sum(t => t.Points);

Console.WriteLine(sumOfPoints);
