
function MatchAlhorithms(HomeTeam, AwayTeam, MatchStatistics) {

    var differ = HomeTeam.Overall - AwayTeam.Overall;
    var range = Math.floor(Math.random() * 99) + 1
  
    if (differ > 10) {
        differ = 10;
    }
    if (differ < -10) {
        differ = -10
    }

    console.log('r:', range);
    console.log('d:', differ);

    switch (differ) {
        case -10:
            if (range >= 95 && range <= 100)
                MatchStatistics.HomeShots++;
            if (range >= 0 && range <= 23)
                MatchStatistics.AwayShots++;
            break;
        case -9:
            break;
        case -8:
            break;
        case -7:
            break;
        case -6:
            break;
        case -5:
            break;
        case -4:
            break;
        case -3:
            break;
        case -2:
            if (range >= 87 && range <= 100)
                MatchStatistics.HomeShots++
            if (range >= 0 && range <= 15)
                MatchStatistics.AwayShots++;
            break;
        case -1:
            if (range >= 86 && range <= 100)
                MatchStatistics.AwayShots++;
            if (range >= 0 && range <= 14)
                MatchStatistics.AwayShots++;
            break;
        case 0:
            if (range >= 85 && range <= 100) {
                strikeHome(MatchStatistics, HomeTeam);
            }
            if (range >= 0 && range <= 13) {
                strikeAway(MatchStatistics, AwayTeam);
            }
            break;
        case 1:
            if (range >= 84 && range <= 100)
                MatchStatistics.HomeShots++
            if (range >= 0 && range <= 13)
                MatchStatistics.AwayShots++;
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
        case 7:
            break;
        case 8:
            break;
        case 8:
            break;
        case 9:
            break;
        case 10:
            if (range >= 75 && range <= 100)
                MatchStatistics.HomeShots++;
            if (range >= 95 && range <= 100)
                MatchStatistics.AwayShots++;
            break;
    }

    var shotSum = MatchStatistics.HomeShots + MatchStatistics.AwayShots;

    MatchStatistics.ProgressBarShot = ((MatchStatistics.HomeShots / shotSum) * 100).toFixed(0);
}


function homeComment(MatchStatistics, HomeTeam) {
    var commentHome = $('#commentHome');
    commentHome.show(200).delay(2600).hide(200);
    commentHome.position({
        my: 'right+85',
        at: 'left top',
        of: $('#homeComment')
    });

    $('#homeMinute').text(MatchStatistics.Counter + 1);
    $('#homePlayer').text(HomeTeam.Players[0].Name + ' ' + HomeTeam.Players[0].Surname);

    //clearInterval(MatchStatistics.IntervalId);
    //$('#pauseMatch').hide(300);
    //$('#startMatch').show(300);
}

function awayComment(MatchStatistics, AwayTeam) {
    var commentAway = $('#commentAway');
    commentAway.show("slow").delay(2900).hide("slow");
    commentAway.position({
        my: 'left+85',
        at: 'left top',
        of: $('#awayComment')

    });

    $('#awayMinute').text(MatchStatistics.Counter + 1);
    $('#awayPlayer').text(AwayTeam.Players[0].Name + ' ' + AwayTeam.Players[0].Surname);
}

function strikeHome(MatchStatistics, HomeTeam) {
    if (MatchStatistics.LiveMatch == true) {
        getStrikerLive(MatchStatistics, HomeTeam, true)
    } else {
        getStriker(MatchStatistics, HomeTeam, true)
    }
}

function strikeAway(MatchStatistics, AwayTeam) {
    if (MatchStatistics.LiveMatch == true) {
        getStrikerLive(MatchStatistics, AwayTeam, false)
    } else {
        getStriker(MatchStatistics, AwayTeam, false)
    }
}

function strikerValue(Team) {

    for (var i = 1; i < 11; i++) {
        if (Team.Players[i].Attack >= 95) {
            striker = Math.floor(Math.random() * 16) + 83;
            Team.Players[i].ShotTemp = striker;
        } else if (Team.Players[i].Attack >= 90 && Team.Players[i].Attack < 95) {
            striker = Math.floor(Math.random() * 18) + 81;
            Team.Players[i].ShotTemp = striker;
        } else if (Team.Players[i].Attack >= 80 && Team.Players[i].Attack < 90) {
            striker = Math.floor(Math.random() * 19) + 80;
            Team.Players[i].ShotTemp = striker;
        } else if (Team.Players[i].Attack >= 70 && Team.Players[i].Attack < 80) {
            striker = Math.floor(Math.random() * 29) + 70;
            Team.Players[i].ShotTemp = striker;
        } else if (Team.Players[i].Attack >= 60 && Team.Players[i].Attack < 70) {
            striker = Math.floor(Math.random() * 39) + 60;
            Team.Players[i].ShotTemp = striker;
        } else if (Team.Players[i].Attack >= 50 && Team.Players[i].Attack < 60) {
            striker = Math.floor(Math.random() * 49) + 50;
            Team.Players[i].ShotTemp = striker;
        } else if (Team.Players[i].Attack >= 30 && Team.Players[i].Attack < 50) {
            striker = Math.floor(Math.random() * 40) + 59;
            Team.Players[i].ShotTemp = striker;
        } else if (Team.Players[i].Attack < 30) {
            striker = Math.floor(Math.random() * 30) + 69;
            Team.Players[i].ShotTemp = striker;
        }
    }
}

function getStrikerLive(MatchStatistics, Team, Side) {

    if (Side == true) {
        MatchStatistics.HomeShots++;

        strikerValue(Team)

        let TeamTmp = JSON.parse(JSON.stringify(Team));
        TeamTmp.Players.sort((x, y) => x.ShotTemp > y.ShotTemp ? -1 : 1);

        for (var i = 0; i < 11; i++) {
            console.log(TeamTmp.Players[i].PlayerId + ' ' + TeamTmp.Players[i].Surname + ' ' + TeamTmp.Players[i].Name + ' ' + TeamTmp.Players[i].ShotTemp);
        }

        homeComment(MatchStatistics, TeamTmp);

        let id = TeamTmp.Players[0].PlayerId;
        console.log('id: ', id)
    } else {

        MatchStatistics.AwayShots++;
        strikerValue(Team)

        let TeamTmp = JSON.parse(JSON.stringify(Team));
        TeamTmp.Players.sort((x, y) => x.ShotTemp > y.ShotTemp ? -1 : 1);

        //for (var i = 0; i < 11; i++) {
        //    console.log(TeamTmp.Players[i].Name + ' ' + TeamTmp.Players[i].ShotTemp);
        //}

        awayComment(MatchStatistics, TeamTmp);
    }
}

// TO DO For simulate
function getStriker(side) {

}


 