
function PlayerSkill(player) {
  
    switch (player.PositionShort) {
        case 'GK':
            player.AverageSkills = (player.GoalKeeper + player.Diving + player.Handling + player.Reflex) / 4;
            player.AverageSkills = player.AverageSkills.toFixed(0);
            break;
        case 'CB':
            player.AverageSkills = (player.Defence + player.Tackling + player.Covering + player.Heading + player.Speed + player.Acceleration) / 6;
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
        default:
            break;
    }
}