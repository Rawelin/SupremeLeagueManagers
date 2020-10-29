

function AISetting(Team, MatchStatistics) {

    var playerScore = MatchStatistics.HomeGoals;
    var computerScore = MatchStatistics.AwayGoals;

    if (playerScore > computerScore) {
        Team.Pressing = 80;
    } else {
        Team.Pressing = 55;
    }

}