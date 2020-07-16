
function MatchAlhorithms(HomeTeam, AwayTeam, MatchStatistics) {

    var differ = HomeTeam.Overall - AwayTeam.Overall;
    var range = Math.floor(Math.random() * 100) + 1
  
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
                MatchStatistics.HomeShots++;
                homeComment(MatchStatistics, HomeTeam);
            }
           
            if (range >= 0 && range <= 13) {
                MatchStatistics.AwayShots++;
                awayComment(MatchStatistics);
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

    // TO DO WhoShots - function
    $('#homePlayer').text(HomeTeam.Players[10].Name + ' ' + HomeTeam.Players[10].Surname);
}

function awayComment(MatchStatistics) {
    var commentAway = $('#commentAway');
    commentAway.show("slow").delay(2900).hide("slow");
    commentAway.position({
        my: 'left+85',
        at: 'left top',
        of: $('#awayComment')

    });
    $('#awayMinute').text(MatchStatistics.Counter + 1);
}
 