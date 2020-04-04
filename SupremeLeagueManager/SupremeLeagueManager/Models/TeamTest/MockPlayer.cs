using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.TeamTest
{
    public class MockPlayer
    {
        public List<Player> mockPlayers = new List<Player>();

        public MockPlayer()
        {
            CrateMockPlayerList();
        }

        public List<Player> GetPlayers()
        {
            return mockPlayers;
        }

        public void CrateMockPlayerList()
        {
            Player courtois = new Player()
            {
                Name = "Thibaut",
                Surname = "Cortouis",
                Age = 27,
                Nationality = Person.PersonNationality.Belgium,
                Position = Player.PlayerPosition.GoalKeeper,
                LeftFootPlaysSkill = 50,
                RightFootPlaysSkill = 100,
                Speed = 80,
                Acceleration = 78,
                Reflex = 95,
                Diving = 90,
                Tackling = 78,
                Covering = 80,
                Heading = 78,
                LongPassAccuracy = 80,
                ShortPassAccuracy = 60,
                ShotPower = 80,
                ShotAccuracy = 60
            };

            Player marcelo = new Player()
            {
                Name = "Marcelo",
                Surname = "",
                Age = 31,
                Nationality = Person.PersonNationality.Brazil,
                Position = Player.PlayerPosition.Defender,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 70,
                Speed = 88,
                Acceleration = 85,
                Reflex = 70,
                Diving = 60,
                Tackling = 80,
                Covering = 82,
                Heading = 77,
                LongPassAccuracy = 88,
                ShortPassAccuracy = 85,
                ShotPower = 80,
                ShotAccuracy = 78
            };

            Player ramos = new Player()
            {
                Name = "Sergio",
                Surname = "Ramos",
                Age = 34,
                Nationality = Person.PersonNationality.Spain,
                Position = Player.PlayerPosition.Defender,
                LeftFootPlaysSkill = 75,
                RightFootPlaysSkill = 100,
                Speed = 85,
                Acceleration = 85,
                Reflex = 72,
                Diving = 68,
                Tackling = 95,
                Covering = 96,
                Heading = 94,
                LongPassAccuracy = 78,
                ShortPassAccuracy = 80,
                ShotPower = 80,
                ShotAccuracy = 75
            };

            Player varane = new Player()
            {
                Name = "Raphael",
                Surname = "Varane",
                Age = 26,
                Nationality = Person.PersonNationality.France,
                Position = Player.PlayerPosition.Defender,
                LeftFootPlaysSkill = 75,
                RightFootPlaysSkill = 100,
                Speed = 92,
                Acceleration = 88,
                Reflex = 69,
                Diving = 65,
                Tackling = 93,
                Covering = 92,
                Heading = 88,
                LongPassAccuracy = 78,
                ShortPassAccuracy = 75,
                ShotPower = 80,
                ShotAccuracy = 70
            };

            Player carvajal = new Player() 
            {
                Name = "Daniel",
                Surname = "Carvajal",
                Age = 28,
                Nationality = Person.PersonNationality.Spain,
                Position = Player.PlayerPosition.Defender,
                LeftFootPlaysSkill = 100,  
                RightFootPlaysSkill = 60,
                Speed = 82,
                Acceleration = 84,
                Reflex = 69,
                Diving = 62,
                Tackling = 81,
                Covering = 82,
                Heading = 77,
                LongPassAccuracy = 85,
                ShortPassAccuracy = 80,
                ShotPower = 77    ,
                ShotAccuracy = 78
            };

            Player casemiro = new Player()
            {
                Name = "Casemiro",
                Surname = "",
                Age = 28,
                Nationality = Person.PersonNationality.Brazil,
                Position = Player.PlayerPosition.Midfielder,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 60,
                Speed = 80,
                Acceleration = 82,
                Reflex = 72,
                Diving = 62,
                Tackling = 87,
                Covering = 85,
                Heading = 76,
                LongPassAccuracy = 80,
                ShortPassAccuracy = 86,
                ShotPower = 80,
                ShotAccuracy = 77
            };

            Player modric = new Player()
            {
                Name = "Luka",
                Surname = "Modric",
                Age = 28,
                Nationality = Person.PersonNationality.Croatia,
                Position = Player.PlayerPosition.Midfielder,
                LeftFootPlaysSkill = 80,
                RightFootPlaysSkill = 100,
                Speed = 83,
                Acceleration = 82,
                Reflex = 66,
                Diving = 60,
                Tackling = 75,
                Covering = 73,
                Heading = 72,
                LongPassAccuracy = 90,
                ShortPassAccuracy = 92,
                ShotPower = 88,
                ShotAccuracy = 85
            };

            Player kroos = new Player()
            {
                Name = "Toni",
                Surname = "Kroos",
                Age = 30,
                Nationality = Person.PersonNationality.Germany,
                Position = Player.PlayerPosition.Midfielder,
                LeftFootPlaysSkill = 80,
                RightFootPlaysSkill = 100,
                Speed = 82,
                Acceleration = 85,
                Reflex = 63,
                Diving = 62,
                Tackling = 76,
                Covering = 73,
                Heading = 75,
                LongPassAccuracy = 96,
                ShortPassAccuracy = 90,
                ShotPower = 90,
                ShotAccuracy = 86
            };

            Player hazard = new Player()
            {
                Name = "Eden",
                Surname = "Hazard",
                Age = 29,
                Nationality = Person.PersonNationality.Belgium,
                Position = Player.PlayerPosition.Midfielder,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 70,
                Speed = 90,
                Acceleration = 92,
                Reflex = 78,
                Diving = 62,
                Tackling = 66,
                Covering = 73,
                Heading = 78,
                LongPassAccuracy = 88,
                ShortPassAccuracy = 85,
                ShotPower = 90,
                ShotAccuracy = 91
            };

            Player bale = new Player()
            {
                Name = "Gareth",
                Surname = "Bale",
                Age = 30,
                Nationality = Person.PersonNationality.Wales,
                Position = Player.PlayerPosition.Midfielder,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 70,
                Speed = 97,
                Acceleration = 95,
                Reflex = 78,
                Diving = 62,
                Tackling = 66,
                Covering = 65,
                Heading = 83,
                LongPassAccuracy = 87,
                ShortPassAccuracy = 85,
                ShotPower = 95,
                ShotAccuracy = 88
            };

            Player benzema = new Player()
            {
                Name = "Karim",
                Surname = "Benzema",
                Age = 30,
                Nationality = Person.PersonNationality.France,
                Position = Player.PlayerPosition.Attacker,
                LeftFootPlaysSkill = 70,
                RightFootPlaysSkill = 100,
                Speed = 88,
                Acceleration = 92,
                Reflex = 70,
                Diving = 62,
                Tackling = 58,
                Covering = 60,
                Heading = 85,
                LongPassAccuracy = 78,
                ShortPassAccuracy = 82,
                ShotPower = 88,
                ShotAccuracy = 94
            };

            mockPlayers.Add(courtois);
            mockPlayers.Add(marcelo);
            mockPlayers.Add(ramos);
            mockPlayers.Add(varane);
            mockPlayers.Add(carvajal);
            mockPlayers.Add(casemiro);
            mockPlayers.Add(kroos);
            mockPlayers.Add(modric);
            mockPlayers.Add(hazard);
            mockPlayers.Add(bale);
            mockPlayers.Add(benzema);


            foreach(var player in mockPlayers)
            {
                player.SetAverageSkills();
            }
        }
    }
}