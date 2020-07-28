
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
                getStriker(MatchStatistics, HomeTeam, true)
            if (range >= 0 && range <= 23)
                getStriker(MatchStatistics, AwayTeam, false)
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
                getStriker(MatchStatistics, HomeTeam, true)
            if (range >= 0 && range <= 15)
                getStriker(MatchStatistics, AwayTeam, false)
            break;
        case -1:
            if (range >= 86 && range <= 100)
                getStriker(MatchStatistics, HomeTeam, true)
            if (range >= 0 && range <= 14)
                getStriker(MatchStatistics, AwayTeam, false)
            break;
        case 0:
            if (range >= 85 && range <= 100)
                getStriker(MatchStatistics, HomeTeam, true)
            if (range >= 0 && range <= 13)
                getStriker(MatchStatistics, AwayTeam, false)
            break;
        case 1:
            if (range >= 84 && range <= 100)
                getStriker(MatchStatistics, HomeTeam, true)
            if (range >= 0 && range <= 13)
                getStriker(MatchStatistics, AwayTeam, false)
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
                getStriker(MatchStatistics, HomeTeam, true)
            if (range >= 95 && range <= 100)
                getStriker(MatchStatistics, AwayTeam, false)
            break;
    }

    var shotSum = MatchStatistics.HomeShots + MatchStatistics.AwayShots;
    var shotOnSum = MatchStatistics.HomeShotsOnTarget + MatchStatistics.AwayShotsOnTarget
    var shotOffSum = MatchStatistics.HomeShotsOffTarget + MatchStatistics.AwayShotsOffTarget


    MatchStatistics.ProgressBarShot = ((MatchStatistics.HomeShots / shotSum) * 100).toFixed(0);
    MatchStatistics.ProgressBarShotOnTarget = ((MatchStatistics.HomeShotsOnTarget / shotOnSum) * 100).toFixed(0);
    MatchStatistics.ProgressBarShotOffTarget = ((MatchStatistics.HomeShotsOffTarget / shotOffSum) * 100).toFixed(0);
}


function homeComment(MatchStatistics, HomeTeam, Commentary, Goal) {
    var commentHome = $('#commentHome');
    commentHome.show(200).delay(2600).hide(200);
    commentHome.position({
        my: 'right+85',
        at: 'left top',
        of: $('#homeComment')
    });

    $('#homeMinute').text(MatchStatistics.Counter + 1);
    $('#homeAssistant').text(HomeTeam.Players[1].Name + ' ' + HomeTeam.Players[1].Surname);
    $('#homeScorer').text(HomeTeam.Players[0].Name + ' ' + HomeTeam.Players[0].Surname);

    if (Commentary != null) {
        $('#homeActionResult').text(Commentary);

        if (Goal) {
            clearInterval(MatchStatistics.IntervalId);
            $('#pauseMatch').hide(300);
            $('#startMatch').show(300);
            commentHome.show(200);
        }
    }
}

function awayComment(MatchStatistics, AwayTeam, Commentary, Goal) {
    var commentAway = $('#commentAway');
    commentAway.show("slow").delay(2900).hide("slow");
    commentAway.position({
        my: 'left+85',
        at: 'left top',
        of: $('#awayComment')

    });

    $('#awayMinute').text(MatchStatistics.Counter + 1);
    $('#awayAssistant').text(AwayTeam.Players[1].Name + ' ' + AwayTeam.Players[1].Surname);
    $('#awayScorer').text(AwayTeam.Players[0].Name + ' ' + AwayTeam.Players[0].Surname);

    if (Commentary != null) {
        $('#awayActionResult').text(Commentary);

        if (Goal) {
            clearInterval(MatchStatistics.IntervalId);
            $('#pauseMatch').hide(300);
            $('#startMatch').show(300);
            commentAway.show(200);
        }
    }
}

//function strikeHome(MatchStatistics, HomeTeam) {
//    if (MatchStatistics.LiveMatch == true) {
//        getStrikerLive(MatchStatistics, HomeTeam, true)
//    } else {
//        getStriker(MatchStatistics, HomeTeam, true)
//    }
//}

//function strikeAway(MatchStatistics, AwayTeam) {
//    if (MatchStatistics.LiveMatch == true) {
//        getStrikerLive(MatchStatistics, AwayTeam, false)
//    } else {
//        getStriker(MatchStatistics, AwayTeam, false)
//    }
//}

function strikerValue(Team) {

    for (var i = 1; i < 11; i++) {
        if (Team.Players[i].Attack >= 95) {
            striker = Math.floor(Math.random() * 9) + 90;
            Team.Players[i].ShotTemp = striker;
        } else if (Team.Players[i].Attack >= 90 && Team.Players[i].Attack < 95) {
            striker = Math.floor(Math.random() * 14) + 85;
            Team.Players[i].ShotTemp = striker;
        } else if (Team.Players[i].Attack >= 85 && Team.Players[i].Attack < 90) {
            striker = Math.floor(Math.random() * 19) + 80;
            Team.Players[i].ShotTemp = striker;
        } else if (Team.Players[i].Attack >= 80 && Team.Players[i].Attack < 85) {
            striker = Math.floor(Math.random() * 24) + 75;
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
            striker = Math.floor(Math.random() * 59) + 40;
            Team.Players[i].ShotTemp = striker;
        } else if (Team.Players[i].Attack < 30) {
            striker = Math.floor(Math.random() * 69) + 30;
            Team.Players[i].ShotTemp = striker;
        }
    }
}


function getStriker(MatchStatistics, Team, Home) {


    strikerValue(Team);

    var TeamTmp = JSON.parse(JSON.stringify(Team));
    TeamTmp.Players.sort((x, y) => x.ShotTemp > y.ShotTemp ? -1 : 1);

    for (var i = 0; i < 11; i++) {
        console.log(TeamTmp.Players[i].PlayerId + ' ' + TeamTmp.Players[i].Surname + ' ' + TeamTmp.Players[i].Name + ' ' + TeamTmp.Players[i].ShotTemp);
    }

    var range = Math.floor(Math.random() * 98) + 1;
    var scorrerIndexPosition = TeamTmp.Players[0].IndexPosition;
    var assistantIndexPosition = TeamTmp.Players[1].IndexPosition;
    var chance;
    var commentary = null;
    var goal = false;

    var shotOnTarget = 0;
    var shotOffTarget = 0;
    var goal = 0;

    if (TeamTmp.Players[0].PositionShort == "CB") {
        chance = TeamTmp.Players[0].Heading + TeamTmp.Players[0].ShotTemp + range;
        console.log('acc: ' + TeamTmp.Players[0].Heading + ' temp: ' + TeamTmp.Players[0].ShotTemp + ' range: ' + range + ' position ' + TeamTmp.Players[0].PositionShort);
    } else {
        chance = TeamTmp.Players[0].ShotAccuracy + TeamTmp.Players[0].ShotTemp + range;
        console.log('acc: ' + TeamTmp.Players[0].ShotAccuracy + ' temp: ' + TeamTmp.Players[0].ShotTemp + ' range: ' + range + ' position ' + TeamTmp.Players[0].PositionShort);
    }

    if (chance > 260) {
        var shotRange = Math.floor(Math.random() * 19) + 16;
        commentary = "strzał z około " + shotRange + " metrów i ....gollll !!!";
        shotOnTarget++;
        goal++;
        Team.Players[scorrerIndexPosition].Goals += 1;
        goal = true;
    } else {
        commentary = "strzał niecelny"
        shotOffTarget++;
    }
  
   
    console.log(chance);

    if (Home == true) {
        MatchStatistics.HomeShots++;
        MatchStatistics.HomeShotsOnTarget += shotOnTarget;
        MatchStatistics.HomeShotsOffTarget += shotOffTarget;
        MatchStatistics.HomeGoals += goal
        homeComment(MatchStatistics, TeamTmp, commentary, goal);
    } else {
        MatchStatistics.AwayShots++;
        MatchStatistics.AwayShotsOnTarget += shotOnTarget;
        MatchStatistics.AwayGoals += goal
        MatchStatistics.AwayShotsOffTarget += shotOffTarget;
        awayComment(MatchStatistics, TeamTmp, commentary, goal);
    }
}

function getStrikerTemp(MatchStatistics, Team, Side) {

    if (Side == true) {
        MatchStatistics.HomeShots++;

        strikerValue(Team)

        var TeamTmp = JSON.parse(JSON.stringify(Team));
        TeamTmp.Players.sort((x, y) => x.ShotTemp > y.ShotTemp ? -1 : 1);

        for (var i = 0; i < 11; i++) {
            console.log(TeamTmp.Players[i].PlayerId + ' ' + TeamTmp.Players[i].Surname + ' ' + TeamTmp.Players[i].Name + ' ' + TeamTmp.Players[i].ShotTemp);
        }



        var range = Math.floor(Math.random() * 98) + 1;
        var IndexPosition = TeamTmp.Players[0].IndexPosition;
        var chance = TeamTmp.Players[0].ShotAccuracy + range;
        var commentary = null;
        var goal = false;


        if (chance > 175) {
            MatchStatistics.HomeShotsOnTarget++;
            MatchStatistics.HomeGoals++;
            Team.Players[IndexPosition].Goals += 1;
            goal = true;
            var shotRange = Math.floor(Math.random() * 19) + 16;
            commentary = "strzał z około " + shotRange +  " metrów i ....gollll !!!";

        } else if (chance >= 170 && chance <= 175) {
            MatchStatistics.HomeShotsOnTarget++;
            MatchStatistics.HomeGoals++;
            Team.Players[IndexPosition].Goals += 1;
            goal = true;

            if (chance == 170) {
                commentary = "strzał w lewy róg po ziemi i ....gollll !!!";
            } else if (chance == 171) {
                commentary = "strzał w prawy róg po ziemi i ....gollll !!!";
            } else if (chance == 172) {
                commentary = "strzał bramkarz odbija piłkę ale ta wpada do siatki gollll !!!";
            } else if (chance == 173) {
                commentary = "strzał piłka odbija się od poprzeczki i ....gollll !!!";
            } else if (chance == 174) {
                commentary = "strzał piłka odbija się od słupka i ....gollll !!!";
            }
        } else if (chance >= 165 && chance < 170) {

            if (chance == 165) {
                MatchStatistics.HomeShotsOnTarget++;
                commentary = "strzeł... zbramkarz sparuję piłke na rzut rożny";
            } else if (chance == 166) {
                MatchStatistics.HomeShotsOnTarget++;
                commentary = "strzela... bramkarz wybija z piłkę nad poprzeczkę";
            } else if (chance == 167) {
                MatchStatistics.HomeShotsOffTarget++;
                commentary = "strzela i... słupek";
            } else if (chance == 168) {
                MatchStatistics.HomeShotsffTarget++;
                commentary = "strzał i... poprzeczka";
            } else if (chance == 169) {
                MatchStatistics.HomeShotsOffTarget++;
                commentary = "oddaje strzał... piłka uderza w spojenie";
            }
        } else if (chance < 165) {
            MatchStatistics.HomeShotsOffTarget++;
            commentary = "oddaje strzał... jednak niecelnie";
        }
           
        homeComment(MatchStatistics, TeamTmp, commentary, goal);

        console.log('home chance: ', chance);
        //console.log(Team.Players[IndexPosition]);
    } else {

        MatchStatistics.AwayShots++;
        strikerValue(Team)

        let TeamTmp = JSON.parse(JSON.stringify(Team));
        TeamTmp.Players.sort((x, y) => x.ShotTemp > y.ShotTemp ? -1 : 1);

        for (var i = 0; i < 11; i++) {
            console.log(TeamTmp.Players[i].PlayerId + ' ' + TeamTmp.Players[i].Surname + ' ' + TeamTmp.Players[i].Name + ' ' + TeamTmp.Players[i].ShotTemp);
        }

        awayComment(MatchStatistics, TeamTmp);

        var range = Math.floor(Math.random() * 98) + 1;
        var IndexPosition = TeamTmp.Players[0].IndexPosition;
        var chance = TeamTmp.Players[0].ShotTemp + range;
        Team.Players[IndexPosition].Goals += 1;

        console.log('away chance: ', chance);


    }
}



