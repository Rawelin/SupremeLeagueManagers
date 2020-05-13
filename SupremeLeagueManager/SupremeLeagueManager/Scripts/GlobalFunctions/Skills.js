// static -  excludes position on the field 
function PlayerSkills(player) {
  
    var averageSkill = 0;

    switch (player.PositionShort) {
        case 'GK':
            player.AverageSkills = (player.GoalKeeper + player.Diving + player.Handling + player.Reflex) / 4;
            player.AverageSkills = player.AverageSkills.toFixed(0);
            break;
        case 'CB':
            player.AverageSkills = (player.Defence + player.Tackling + player.Covering + player.Heading) / 4;
            player.AverageSkills = player.AverageSkills.toFixed(0);
            break;
        case 'LB':
        case 'RB':
            player.AverageSkills = (player.Defence + player.Attack + player.Technique + player.LongPassAccuracy + player.Speed + player.Acceleration) / 6;
            player.AverageSkills = player.AverageSkills.toFixed(0);
            break;
        case 'DM':
            player.AverageSkills = (player.Defence + player.Midfield + player.Tackling + player.Covering + player.Speed + player.Acceleration) / 6;
            player.AverageSkills = player.AverageSkills.toFixed(0);
            break;
        case 'CM':
            player.AverageSkills = (player.Midfield + player.ShortPassAccuracy + player.LongPassAccuracy + player.Technique +
                player.Speed + player.Acceleration) / 6;
            player.AverageSkills = player.AverageSkills.toFixed(0);
            break;
        case 'LM':
        case 'RM':
            player.AverageSkills = (player.Midfield + player.Attack + player.Technique + player.LongPassAccuracy + player.Speed + player.Acceleration) / 6;
            player.AverageSkills = player.AverageSkills.toFixed(0);
            break;
        case 'AM':
            player.AverageSkills = (player.Midfield + player.Attack + player.Technique + player.ShortPassAccuracy +
                player.LongPassAccuracy + player.ShotPower + player.ShotAccuracy + player.Speed + player.Acceleration) / 9;
            player.AverageSkills = player.AverageSkills.toFixed(0);
            break;
        case 'LW':
        case 'RW':
            player.AverageSkills = (player.Attack + player.Technique + player.ShortPassAccuracy + player.LongPassAccuracy + player.ShotPower +
                player.ShotAccuracy + player.Speed + player.Acceleration) / 8;
            player.AverageSkills = player.AverageSkills.toFixed(0);
            break;
        case 'SS':
            player.AverageSkills = (player.Midfield + player.Attack + player.Technique + player.ShortPassAccuracy + player.ShotPower +
                player.ShotAccuracy + player.Speed + player.Acceleration) / 8;
            player.AverageSkills = player.AverageSkills.toFixed(0);
            break;
        case 'CF':
            player.AverageSkills = (player.Attack + player.Technique + player.ShortPassAccuracy + player.ShotPower + player.ShotAccuracy +
                player.Speed + player.Acceleration) / 7;
            player.AverageSkills = player.AverageSkills.toFixed(0);
            break;
    }

    averageSkill = player.AverageSkills;

    return averageSkill;
}

// dynamic - includes position on the field
function PlayerSkillsDynamic(player, formation) {

    var currentPosition = player.IndexPosition;
    var originalPosition = player.PositionShort;
    var dynamicAverageSkill = 0;

    //console.log(player.IndexPosition + ' ' + player.Name + ' ' +player.PositionShort);

    if (formation == 1) {
        switch (currentPosition) {

            case 0:
                player.PositionShort = 'GK';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 1:
                player.PositionShort = 'LB';
                player.AverageDynamicSkills = (PlayerSkills(player) * player.LeftFootSkills * 0.01).toFixed(0);
                break;
            case 2:
            case 3:
                player.PositionShort = 'CB';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 4:
                player.PositionShort = 'RB';
                player.AverageDynamicSkills = (PlayerSkills(player) * player.RightFootSkills * 0.01).toFixed(0);
                break;
            case 5:
                player.PositionShort = 'LM';
                player.AverageDynamicSkills = (PlayerSkills(player) * player.LeftFootSkills * 0.01).toFixed(0);
                break;
            case 6:
                player.PositionShort = 'DM';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 7:
                player.PositionShort = 'CM';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 8:
                player.PositionShort = 'RM';
                player.AverageDynamicSkills = (PlayerSkills(player) * player.RightFootSkills * 0.01).toFixed(0);
                break;
            case 9:
            case 10:
                player.PositionShort = 'CF';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
        }
    } else if (formation == 2) {
        switch (currentPosition) {

            case 0:
                player.PositionShort = 'GK';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 1:
                player.PositionShort = 'LB';
                player.AverageDynamicSkills = (PlayerSkills(player) * player.LeftFootSkills * 0.01).toFixed(0);
                break;
            case 2:
            case 3:
                player.PositionShort = 'CB';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 4:
                player.PositionShort = 'RB';
                player.AverageDynamicSkills = (PlayerSkills(player) * player.RightFootSkills * 0.01).toFixed(0);
                break;
            case 5:
                player.PositionShort = 'CM';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 6:
                player.PositionShort = 'DM';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 7:
                player.PositionShort = 'CM';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 8:
                player.PositionShort = 'LW';
                player.AverageDynamicSkills = (PlayerSkills(player) * player.LeftFootSkills * 0.01).toFixed(0);
                break;
            case 9:
                player.PositionShort = 'CF';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 10:
                player.PositionShort = 'RW';
                player.AverageDynamicSkills = (PlayerSkills(player) * player.RightFootSkills * 0.01).toFixed(0);
                break;
        }
    } else if (formation == 3) {
        switch (currentPosition) {

            case 0:
                player.PositionShort = 'GK';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 1:
                player.PositionShort = 'LB';
                player.AverageDynamicSkills = (PlayerSkills(player) * player.LeftFootSkills * 0.01).toFixed(0);
                break;
            case 2:
            case 3:
                player.PositionShort = 'CB';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 4:
                player.PositionShort = 'RB';
                player.AverageDynamicSkills = (PlayerSkills(player) * player.RightFootSkills * 0.01).toFixed(0);
                break;
            case 5:
                player.PositionShort = 'LM';
                player.AverageDynamicSkills = (PlayerSkills(player) * player.LeftFootSkills * 0.01).toFixed(0);
                break;
            case 6:
                player.PositionShort = 'CM';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 7:
                player.PositionShort = 'DM';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 8:
                player.PositionShort = 'CM';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 9:
                player.PositionShort = 'RM';
                player.AverageDynamicSkills = (PlayerSkills(player) * player.RightFootSkills * 0.01).toFixed(0);
                break;
            case 10:
                player.PositionShort = 'CF';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
        }
    } else if (formation == 4) {
        switch (currentPosition) {

            case 0:
                player.PositionShort = 'GK';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 1:
            case 2:
            case 3:
                player.PositionShort = 'CB';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 4:
                player.PositionShort = 'LM';
                player.AverageDynamicSkills = (PlayerSkills(player) * player.LeftFootSkills * 0.01).toFixed(0);
                break;
            case 5:
                player.PositionShort = 'CM';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 6:
                player.PositionShort = 'DM';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 7:
                player.PositionShort = 'CM';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
            case 8:
                player.PositionShort = 'RM';
                player.AverageDynamicSkills = (PlayerSkills(player) * player.RightFootSkills * 0.01).toFixed(0);
                break;
            case 9:
            case 10:
                player.PositionShort = 'CF';
                player.AverageDynamicSkills = PlayerSkills(player);
                break;
        }
    }

    player.PositionShort = originalPosition;

    return dynamicAverageSkill = player.AverageDynamicSkills;
}

// dynamic - includes position on the field
function TeamSkills(team) {

    // 1. 4-4-2
    // 2. 4-3-3
    // 3. 4.5.1
    // 4. 3.5.2
   
    var goalKeeper = defence =  midfield =  attack = speed = technique =  overall = 0;

    switch (team.Formation) {
        case 1:
        case 2:
        case 3:
            for (var i = 1; i < 5; i++) {
                defence += parseInt(PlayerSkillsDynamic(team.Players[i], team.Formation));
            }
            defence /= 4;
            break;
        case 4:
            for (var i = 1; i < 4; i++) {
                defence += parseInt(PlayerSkillsDynamic(team.Players[i], team.Formation));
            }
            defence /= 3;
            break;
    }

    switch (team.Formation) {
        case 1:
            for (var i = 5; i < 9; i++) {
                midfield += parseInt(PlayerSkillsDynamic(team.Players[i], team.Formation));
            }
            midfield /= 4;
            break;
        case 2:
            for (var i = 5; i < 8; i++) {
                midfield += parseInt(PlayerSkillsDynamic(team.Players[i], team.Formation));
            }
            midfield /= 3;
            break;
        case 3:
            for (var i = 5; i < 10; i++) {
                midfield += parseInt(PlayerSkillsDynamic(team.Players[i], team.Formation));
            }
            midfield /= 5;
            break;
        case 4:
            for (var i = 4; i < 9; i++) {
                midfield += parseInt(PlayerSkillsDynamic(team.Players[i], team.Formation));
            }
            midfield /= 5;
            break;
    }

    switch (team.Formation) {
        case 1:
            for (var i = 9; i < 11; i++) {
                attack += parseInt(PlayerSkillsDynamic(team.Players[i], team.Formation));
            }
            attack /= 2;
            break;
        case 2:
            for (var i = 8; i < 11; i++) {
                attack += parseInt(PlayerSkillsDynamic(team.Players[i], team.Formation));
            }
            attack /= 3;
            break;
        case 3:
            for (var i = 10; i < 11; i++) {
                attack += parseInt(PlayerSkillsDynamic(team.Players[i], team.Formation));
            }
            break;
        case 4:
            for (var i = 9; i < 11; i++) {
                attack += parseInt(PlayerSkillsDynamic(team.Players[i], team.Formation));
            }
            attack /= 2;
            break;
    }

    if (team.Formation) {

        goalKeeper = parseInt(PlayerSkillsDynamic(team.Players[0], team.Formation));

        for (var i = 1; i < 11; i++) {
            speed += team.Players[i].Speed;
            technique += team.Players[i].Technique;
        }
        speed /= 10;
        technique /= 10;
    }

    team.GoalKeeper = goalKeeper.toFixed(0);
    team.Defence = defence.toFixed(0);
    team.Midfield = midfield.toFixed(0);
    team.Attack = attack.toFixed(0);
    team.Speed = speed.toFixed(0);
    team.Technique = technique.toFixed(0);

    overall = (goalKeeper + defence + midfield + attack) / 4;

    team.Overall = overall.toFixed(0);
}