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
            player.AverageSkills = (player.Defence + player.Midfield + player.Tackling + player.Covering) / 4;
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
            player.AverageSkills = (player.Attack + player.Technique + player.ShotPower + player.ShotAccuracy +
                player.Speed + player.Acceleration) / 6;
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

// dynamic - includes position on the field and current stamina
function PlayerSkillsDynamicEnergy(player, formation) {

    var currentPosition = player.IndexPosition;
    var originalPosition = player.PositionShort;
    var dynamicAverageSkill = 0;

    if (formation == 1) {
        switch (currentPosition) {

            case 0:
                player.PositionShort = 'GK';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
            case 1:
                player.PositionShort = 'LB';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * player.LeftFootSkills * 0.01 * rateEnergy(player)).toFixed(0);
                break;
            case 2:
            case 3:
                player.PositionShort = 'CB';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player) * rateEnergy(player)).toFixed(0);
                break;
            case 4:
                player.PositionShort = 'RB';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * player.RightFootSkills * 0.01 * rateEnergy(player)).toFixed(0);
                break;
            case 5:
                player.PositionShort = 'LM';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * player.LeftFootSkills * 0.01 * rateEnergy(player)).toFixed(0);
                break;
            case 6:
                player.PositionShort = 'DM';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
            case 7:
                player.PositionShort = 'CM';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
            case 8:
                player.PositionShort = 'RM';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * player.RightFootSkills * 0.01 * rateEnergy(player)).toFixed(0);
                break;
            case 9:
            case 10:
                player.PositionShort = 'CF';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
        }
    } else if (formation == 2) {
        switch (currentPosition) {

            case 0:
                player.PositionShort = 'GK';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
            case 1:
                player.PositionShort = 'LB';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * player.LeftFootSkills * 0.01 * rateEnergy(player)).toFixed(0);
                break;
            case 2:
            case 3:
                player.PositionShort = 'CB';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
            case 4:
                player.PositionShort = 'RB';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * player.RightFootSkills * 0.01 * rateEnergy(player)).toFixed(0);
                break;
            case 5:
                player.PositionShort = 'CM';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
            case 6:
                player.PositionShort = 'DM';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
            case 7:
                player.PositionShort = 'CM';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
            case 8:
                player.PositionShort = 'LW';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * player.LeftFootSkills * 0.01 * rateEnergy(player)).toFixed(0);
                break;
            case 9:
                player.PositionShort = 'CF';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
            case 10:
                player.PositionShort = 'RW';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * player.RightFootSkills * 0.01 * rateEnergy(player)).toFixed(0);
                break;
        }
    } else if (formation == 3) {
        switch (currentPosition) {

            case 0:
                player.PositionShort = 'GK';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
            case 1:
                player.PositionShort = 'LB';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * player.LeftFootSkills * 0.01 * rateEnergy(player)).toFixed(0);
                break;
            case 2:
            case 3:
                player.PositionShort = 'CB';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
            case 4:
                player.PositionShort = 'RB';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * player.RightFootSkills * 0.01 * rateEnergy(player)).toFixed(0);
                break;
            case 5:
                player.PositionShort = 'LM';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * player.LeftFootSkills * 0.01 * rateEnergy(player)).toFixed(0);
                break;
            case 6:
                player.PositionShort = 'CM';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
            case 7:
                player.PositionShort = 'DM';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
            case 8:
                player.PositionShort = 'CM';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
            case 9:
                player.PositionShort = 'RM';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * player.RightFootSkills * 0.01 * rateEnergy(player)).toFixed(0);
                break;
            case 10:
                player.PositionShort = 'CF';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
        }
    } else if (formation == 4) {
        switch (currentPosition) {

            case 0:
                player.PositionShort = 'GK';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
            case 1:
            case 2:
            case 3:
                player.PositionShort = 'CB';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
            case 4:
                player.PositionShort = 'LM';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * player.LeftFootSkills * 0.01 * rateEnergy(player)).toFixed(0);
                break;
            case 5:
                player.PositionShort = 'CM';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);;
                break;
            case 6:
                player.PositionShort = 'DM';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
            case 7:
                player.PositionShort = 'CM';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
            case 8:
                player.PositionShort = 'RM';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * player.RightFootSkills * 0.01 * rateEnergy(player)).toFixed(0);
                break;
            case 9:
            case 10:
                player.PositionShort = 'CF';
                player.AverageDynamicEnergySkills = (PlayerSkills(player) * rateEnergy(player)).toFixed(0);
                break;
        }
    }

    player.PositionShort = originalPosition;

    return AverageDynamicEnergySkills = player.AverageDynamicEnergySkills;
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

// dynamic - includes position on the field and current stamina
function TeamSkillsEnergy(team) {

    // 1. 4-4-2
    // 2. 4-3-3
    // 3. 4.5.1
    // 4. 3.5.2

    var goalKeeper = defence = midfield = attack = speed = technique = overall = 0;

    switch (team.Formation) {
        case 1:
        case 2:
        case 3:
            for (var i = 1; i < 5; i++) {
                defence += parseInt(PlayerSkillsDynamicEnergy(team.Players[i], team.Formation));
            }
            defence /= 4;
            break;
        case 4:
            for (var i = 1; i < 4; i++) {
                defence += parseInt(PlayerSkillsDynamicEnergy(team.Players[i], team.Formation));
            }
            defence /= 3;
            break;
    }

    switch (team.Formation) {
        case 1:
            for (var i = 5; i < 9; i++) {
                midfield += parseInt(PlayerSkillsDynamicEnergy(team.Players[i], team.Formation));
            }
            midfield /= 4;
            break;
        case 2:
            for (var i = 5; i < 8; i++) {
                midfield += parseInt(PlayerSkillsDynamicEnergy(team.Players[i], team.Formation));
            }
            midfield /= 3;
            break;
        case 3:
            for (var i = 5; i < 10; i++) {
                midfield += parseInt(PlayerSkillsDynamicEnergy(team.Players[i], team.Formation));
            }
            midfield /= 5;
            break;
        case 4:
            for (var i = 4; i < 9; i++) {
                midfield += parseInt(PlayerSkillsDynamicEnergy(team.Players[i], team.Formation));
            }
            midfield /= 5;
            break;
    }

    switch (team.Formation) {
        case 1:
            for (var i = 9; i < 11; i++) {
                attack += parseInt(PlayerSkillsDynamicEnergy(team.Players[i], team.Formation));
            }
            attack /= 2;
            break;
        case 2:
            for (var i = 8; i < 11; i++) {
                attack += parseInt(PlayerSkillsDynamicEnergy(team.Players[i], team.Formation));
            }
            attack /= 3;
            break;
        case 3:
            for (var i = 10; i < 11; i++) {
                attack += parseInt(PlayerSkillsDynamicEnergy(team.Players[i], team.Formation));
            }
            break;
        case 4:
            for (var i = 9; i < 11; i++) {
                attack += parseInt(PlayerSkillsDynamicEnergy(team.Players[i], team.Formation));
            }
            attack /= 2;
            break;
    }

    if (team.Formation) {

        goalKeeper = parseInt(PlayerSkillsDynamicEnergy(team.Players[0], team.Formation));

        for (var i = 1; i < 11; i++) {
            speed += team.Players[i].Speed;
            technique += team.Players[i].Technique;
        }
        speed /= 10;
        technique /= 10;
    }

    //team.GoalKeeper = goalKeeper.toFixed(0);
    //team.Defence = defence.toFixed(0);
    //team.Midfield = midfield.toFixed(0);
    //team.Attack = attack.toFixed(0);
    //team.Speed = speed.toFixed(0);
    //team.Technique = technique.toFixed(0);

    overall = (goalKeeper + defence + midfield + attack) / 4;

    team.OverallEnergy = overall.toFixed(0);
}



function staminaDecreaser(Team, MatchStatistics, pressing) {

    var rate1 = 0;
    var rate2 = 0;
    var rate3 = 0;

    if (pressing < 20) {
        rate1 = 0.017;
        rate2 = 0.029;
        rate3 = 0.022;
    } else if (pressing >= 20 && pressing < 40) {
        rate1 = 0.015;
        rate2 = 0.027;
        rate3 = 0.018;
    } else if (pressing >= 40 && pressing < 60) {
        rate1 = 0.013;
        rate2 = 0.025;
        rate3 = 0.015;
    } else if (pressing >= 60 && pressing < 80) {
        rate1 = 0.011;
        rate2 = 0.024;
        rate3 = 0.013;
    } else if (pressing >= 80 && pressing < 90) {
        rate1 = 0.009;
        rate2 = 0.022;
        rate3 = 0.011;
    }
    else if (pressing >= 90) {
        rate1 = 0.007;
        rate2 = 0.020;
        rate3 = 0.010;
    }

    for (var i = 0; i < 11; i++) {

        if (Team.Players[i].Stamina > 1) {
            if (Team.Players[i].PositionShort == "GK") {
                Team.Players[i].Stamina -= 1 / (Team.Players[i].Endurance * rate2);
            } else if (Team.Players[i].PositionShort == "CB") {
                Team.Players[i].Stamina -= 1 / (Team.Players[i].Endurance * rate3);
            } else {
                Team.Players[i].Stamina -= 1 / (Team.Players[i].Endurance * rate1);
            }
        }
    }

    if (MatchStatistics.Counter == (MatchStatistics.MatchLength / 2).toFixed(0)) {
        for (var i = 0; i < 11; i++) {
            Team.Players[i].Stamina += Team.Players[i].Stamina * 0.1;
        }
    }
}


function rateEnergy(player) {
    var rate = 1;

    if (player.Stamina >= 90 && player.Stamina <= 100) {
        return rate = 1;
    } else if (player.Stamina >= 80 && player.Stamina < 90) {
        return rate = 0.99
    } else if (player.Stamina >= 70 && player.Stamina < 80) {
        return rate = 0.98
    } else if (player.Stamina >= 60 && player.Stamina < 70) {
        return rate = 0.97
    } else if (player.Stamina >= 50 && player.Stamina < 60) {
        return rate = 0.96
    } else if (player.Stamina >= 40 && player.Stamina < 50) {
        return rate = 0.95
    } else if (player.Stamina >= 30 && player.Stamina < 40) {
        return rate = 0.94
    } else if (player.Stamina >= 20 && player.Stamina < 30) {
        return rate = 0.85
    } else if (player.Stamina >= 10 && player.Stamina < 20) {
        return rate = 0.80;
    } else if (player.Stamina >= 0 && player.Stamina < 10) {
        return rate = 0.75
    } else {
        return rate = 0.90;
    }
}