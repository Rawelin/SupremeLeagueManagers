using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.TeamTest
{
    public class MockPlayer
    {
        public List<List<Player>> mockPlayers = new List<List<Player>>();

        public MockPlayer()
        {
            CrateMockPlayerList();
        }

        public List<List<Player>> GetPlayers()
        {
            return mockPlayers;
        }

        public void CrateMockPlayerList()
        {
            Player courtois = new Player()
            {
                TeamId = 14,
                Name = "Thibaut",
                Surname = "Cortouis",
                Age = 27,
                Nationality = Person.PersonNationality.Belgium,
                Position = Player.PlayerPosition.GK,
                LeftFootPlaysSkill = 50,
                RightFootPlaysSkill = 100,
                GoalKeeper = 94,
                Defence = 85,
                Midfield = 50,
                Attack = 32,
                Diving = 92,
                Handling = 93,
                Tackling = 80,
                Covering = 80,
                LongPassAccuracy = 80,
                ShortPassAccuracy = 60,
                ShotAccuracy = 55,
                Speed = 80,
                Acceleration = 78,
                Reflex = 95,
                Heading = 78,
                ShotPower = 80,
                Technique = 78,
                Endurance = 75,
                Stamina = 100

            };

            Player marcelo = new Player()
            {
                TeamId = 14,
                Name = "Marcelo",
                Surname = "",
                Age = 31,
                Nationality = Person.PersonNationality.Brazil,
                Position = Player.PlayerPosition.LB,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 50,
                GoalKeeper = 50,
                Defence = 78,
                Midfield = 75,
                Attack = 80,
                Diving = 55,
                Handling = 60,
                Tackling = 80,
                Covering = 84,
                LongPassAccuracy = 86,
                ShortPassAccuracy = 78,
                ShotAccuracy = 80,
                Speed = 87,
                Acceleration = 88,
                Reflex = 77,
                Heading = 78,
                ShotPower = 85,
                Technique = 84,
                Endurance = 90,
                Stamina = 100
            };

            Player ramos = new Player()
            {
                TeamId = 14,
                Name = "Sergio",
                Surname = "Ramos",
                Age = 34,
                Nationality = Person.PersonNationality.Spain,
                Position = Player.PlayerPosition.CB,
                LeftFootPlaysSkill = 75,
                RightFootPlaysSkill = 100,
                GoalKeeper = 68,
                Defence = 95,
                Midfield = 70,
                Attack = 78,
                Diving = 65,
                Handling = 55,
                Tackling = 96,
                Covering = 95,
                LongPassAccuracy = 80,
                ShortPassAccuracy = 83,
                ShotAccuracy = 78,
                Speed = 87,
                Acceleration = 88,
                Reflex = 80,
                Heading = 98,
                ShotPower = 85,
                Technique = 84,
                Endurance = 85,
                Stamina = 100
            };

            Player varane = new Player()
            {
                TeamId = 14,
                Name = "Raphael",
                Surname = "Varane",
                Age = 26,
                Nationality = Person.PersonNationality.France,
                Position = Player.PlayerPosition.CB,
                LeftFootPlaysSkill = 75,
                RightFootPlaysSkill = 100,
                GoalKeeper = 55,
                Defence = 93,
                Midfield = 65,
                Attack = 67,
                Diving = 58,
                Handling = 52,
                Tackling = 93,
                Covering = 90,
                LongPassAccuracy = 73,
                ShortPassAccuracy = 80,
                ShotAccuracy = 75,
                Speed = 92,
                Acceleration = 90,
                Reflex = 85,
                Heading = 88,
                ShotPower = 80,
                Technique = 80,
                Endurance = 83,
                Stamina = 100
            };

            Player carvajal = new Player()
            {
                TeamId = 14,
                Name = "Daniel",
                Surname = "Carvajal",
                Age = 28,
                Nationality = Person.PersonNationality.Spain,
                Position = Player.PlayerPosition.LB,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 60,
                GoalKeeper = 50,
                Defence = 77,
                Midfield = 70,
                Attack = 80,
                Diving = 52,
                Handling = 60,
                Tackling = 78,
                Covering = 80,
                LongPassAccuracy = 85,
                ShortPassAccuracy = 75,
                ShotAccuracy = 78,
                Speed = 85,
                Acceleration = 88,
                Reflex = 80,
                Heading = 75,
                ShotPower = 80,
                Technique = 84,
                Endurance = 90,
                Stamina = 100
            };

            Player casemiro = new Player()
            {
                TeamId = 14,
                Name = "Casemiro",
                Surname = "",
                Age = 28,
                Nationality = Person.PersonNationality.Brazil,
                Position = Player.PlayerPosition.DM,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 60,
                GoalKeeper = 55,
                Defence = 83,
                Midfield = 80,
                Attack = 74,
                Diving = 58,
                Handling = 52,
                Tackling = 88,
                Covering = 85,
                LongPassAccuracy = 80,
                ShortPassAccuracy = 83,
                ShotAccuracy = 78,
                Speed = 85,
                Acceleration = 88,
                Reflex = 83,
                Heading = 80,
                ShotPower = 85,
                Technique = 85,
                Endurance = 90,
                Stamina = 100
            };

            Player modric = new Player()
            {
                TeamId = 14,
                Name = "Luka",
                Surname = "Modric",
                Age = 28,
                Nationality = Person.PersonNationality.Croatia,
                Position = Player.PlayerPosition.CM,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 80,
                GoalKeeper = 55,
                Defence = 78,
                Midfield = 95,
                Attack = 80,
                Diving = 55,
                Handling = 52,
                Tackling = 78,
                Covering = 80,
                LongPassAccuracy = 90,
                ShortPassAccuracy = 94,
                ShotAccuracy = 85,
                Speed = 88,
                Acceleration = 88,
                Reflex = 85,
                Heading = 77,
                ShotPower = 87,
                Technique = 90,
                Endurance = 88,
                Stamina = 100
            };

            Player kroos = new Player()
            {
                TeamId = 14,
                Name = "Toni",
                Surname = "Kroos",
                Age = 30,
                Nationality = Person.PersonNationality.Germany,
                Position = Player.PlayerPosition.CM,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 80,
                GoalKeeper = 55,
                Defence = 78,
                Midfield = 93,
                Attack = 82,
                Diving = 55,
                Handling = 52,
                Tackling = 78,
                Covering = 80,
                LongPassAccuracy = 95,
                ShortPassAccuracy = 95,
                ShotAccuracy = 82,
                Speed = 84,
                Acceleration = 82,
                Reflex = 80,
                Heading = 80,
                ShotPower = 88,
                Technique = 88,
                Endurance = 85,
                Stamina = 100
            };

            Player hazard = new Player()
            {
                TeamId = 14,
                Name = "Eden",
                Surname = "Hazard",
                Age = 29,
                Nationality = Person.PersonNationality.Belgium,
                Position = Player.PlayerPosition.LW,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 80,
                GoalKeeper = 55,
                Defence = 78,
                Midfield = 90,
                Attack = 93,
                Diving = 55,
                Handling = 52,
                Tackling = 73,
                Covering = 75,
                LongPassAccuracy = 88,
                ShortPassAccuracy = 90,
                ShotAccuracy = 88,
                Speed = 93,
                Acceleration = 90,
                Reflex = 85,
                Heading = 80,
                ShotPower = 88,
                Technique = 93,
                Endurance = 90,
                Stamina = 100
            };

            Player bale = new Player()
            {
                TeamId = 14,
                Name = "Gareth",
                Surname = "Bale",
                Age = 30,
                Nationality = Person.PersonNationality.Wales,
                Position = Player.PlayerPosition.RW,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 70,
                GoalKeeper = 55,
                Defence = 78,
                Midfield = 90,
                Attack = 90,
                Diving = 55,
                Handling = 52,
                Tackling = 73,
                Covering = 75,
                LongPassAccuracy = 90,
                ShortPassAccuracy = 88,
                ShotAccuracy = 88,
                Speed = 99,
                Acceleration = 95,
                Reflex = 90,
                Heading = 86,
                ShotPower = 92,
                Technique = 90,
                Endurance = 85,
                Stamina = 100
            };

            Player benzema = new Player()
            {
                TeamId = 14,
                Name = "Karim",
                Surname = "Benzema",
                Age = 30,
                Nationality = Person.PersonNationality.France,
                Position = Player.PlayerPosition.CF,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 90,
                GoalKeeper = 55,
                Defence = 78,
                Midfield = 90,
                Attack = 90,
                Diving = 55,
                Handling = 52,
                Tackling = 73,
                Covering = 75,
                LongPassAccuracy = 80,
                ShortPassAccuracy = 85,
                ShotAccuracy = 90,
                Speed = 90,
                Acceleration = 90,
                Reflex = 84,
                Heading = 88,
                ShotPower = 85,
                Technique = 88,
                Endurance = 84,
                Stamina = 100
            };

            List<Player> realMadrid = new List<Player>();

            realMadrid.Add(courtois);
            realMadrid.Add(marcelo);
            realMadrid.Add(ramos);
            realMadrid.Add(varane);
            realMadrid.Add(carvajal);
            realMadrid.Add(casemiro);
            realMadrid.Add(kroos);
            realMadrid.Add(modric);
            realMadrid.Add(hazard);
            realMadrid.Add(bale);
            realMadrid.Add(benzema);

            foreach (var player in realMadrid)
            {
                player.SetAverageSkills();
            }

            mockPlayers.Add(realMadrid);

            Player b1 = new Player()
            {
                TeamId = 3,
                Name = "Thibaut",
                Surname = "Cortouis",
                Age = 27,
                Nationality = Person.PersonNationality.Belgium,
                Position = Player.PlayerPosition.GK,
                LeftFootPlaysSkill = 50,
                RightFootPlaysSkill = 100,
                GoalKeeper = 94,
                Defence = 85,
                Midfield = 50,
                Attack = 32,
                Diving = 92,
                Handling = 93,
                Tackling = 80,
                Covering = 80,
                LongPassAccuracy = 80,
                ShortPassAccuracy = 60,
                ShotAccuracy = 55,
                Speed = 80,
                Acceleration = 78,
                Reflex = 95,
                Heading = 78,
                ShotPower = 80,
                Technique = 78,
                Endurance = 75,
                Stamina = 100
            };


            Player b2 = new Player()
            {
                TeamId = 3,
                Name = "Marcelo",
                Surname = "",
                Age = 31,
                Nationality = Person.PersonNationality.Brazil,
                Position = Player.PlayerPosition.LB,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 50,
                GoalKeeper = 50,
                Defence = 78,
                Midfield = 75,
                Attack = 80,
                Diving = 55,
                Handling = 60,
                Tackling = 80,
                Covering = 84,
                LongPassAccuracy = 86,
                ShortPassAccuracy = 78,
                ShotAccuracy = 80,
                Speed = 87,
                Acceleration = 88,
                Reflex = 77,
                Heading = 78,
                ShotPower = 85,
                Technique = 84,
                Endurance = 90,
                Stamina = 100
            };

            Player b3 = new Player()
            {
                TeamId = 3,
                Name = "Sergio",
                Surname = "Ramos",
                Age = 34,
                Nationality = Person.PersonNationality.Spain,
                Position = Player.PlayerPosition.CB,
                LeftFootPlaysSkill = 75,
                RightFootPlaysSkill = 100,
                GoalKeeper = 68,
                Defence = 95,
                Midfield = 70,
                Attack = 78,
                Diving = 65,
                Handling = 55,
                Tackling = 96,
                Covering = 95,
                LongPassAccuracy = 80,
                ShortPassAccuracy = 83,
                ShotAccuracy = 78,
                Speed = 87,
                Acceleration = 88,
                Reflex = 80,
                Heading = 98,
                ShotPower = 85,
                Technique = 84,
                Endurance = 85,
                Stamina = 100
            };

            Player b4 = new Player()
            {
                TeamId = 3,
                Name = "Raphael",
                Surname = "Varane",
                Age = 26,
                Nationality = Person.PersonNationality.France,
                Position = Player.PlayerPosition.CB,
                LeftFootPlaysSkill = 75,
                RightFootPlaysSkill = 100,
                GoalKeeper = 55,
                Defence = 93,
                Midfield = 65,
                Attack = 67,
                Diving = 58,
                Handling = 52,
                Tackling = 93,
                Covering = 90,
                LongPassAccuracy = 73,
                ShortPassAccuracy = 80,
                ShotAccuracy = 75,
                Speed = 92,
                Acceleration = 90,
                Reflex = 85,
                Heading = 88,
                ShotPower = 80,
                Technique = 80,
                Endurance = 83,
                Stamina = 100
            };

            Player b5 = new Player()
            {
                TeamId = 3,
                Name = "Daniel",
                Surname = "Carvajal",
                Age = 28,
                Nationality = Person.PersonNationality.Spain,
                Position = Player.PlayerPosition.LB,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 60,
                GoalKeeper = 50,
                Defence = 77,
                Midfield = 70,
                Attack = 80,
                Diving = 52,
                Handling = 60,
                Tackling = 78,
                Covering = 80,
                LongPassAccuracy = 85,
                ShortPassAccuracy = 75,
                ShotAccuracy = 78,
                Speed = 85,
                Acceleration = 88,
                Reflex = 80,
                Heading = 75,
                ShotPower = 80,
                Technique = 84,
                Endurance = 90,
                Stamina = 100
            };

            Player b6 = new Player()
            {
                TeamId = 3,
                Name = "Casemiro",
                Surname = "",
                Age = 28,
                Nationality = Person.PersonNationality.Brazil,
                Position = Player.PlayerPosition.DM,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 60,
                GoalKeeper = 55,
                Defence = 83,
                Midfield = 80,
                Attack = 74,
                Diving = 58,
                Handling = 52,
                Tackling = 88,
                Covering = 85,
                LongPassAccuracy = 80,
                ShortPassAccuracy = 83,
                ShotAccuracy = 78,
                Speed = 85,
                Acceleration = 88,
                Reflex = 83,
                Heading = 80,
                ShotPower = 85,
                Technique = 85,
                Endurance = 90,
                Stamina = 100
            };

            Player b7 = new Player()
            {
                TeamId = 3,
                Name = "Luka",
                Surname = "Modric",
                Age = 28,
                Nationality = Person.PersonNationality.Croatia,
                Position = Player.PlayerPosition.CM,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 80,
                GoalKeeper = 55,
                Defence = 78,
                Midfield = 95,
                Attack = 80,
                Diving = 55,
                Handling = 52,
                Tackling = 78,
                Covering = 80,
                LongPassAccuracy = 90,
                ShortPassAccuracy = 94,
                ShotAccuracy = 85,
                Speed = 88,
                Acceleration = 88,
                Reflex = 85,
                Heading = 77,
                ShotPower = 87,
                Technique = 90,
                Endurance = 88,
                Stamina = 100
            };

            Player b8 = new Player()
            {
                TeamId = 3,
                Name = "Toni",
                Surname = "Kroos",
                Age = 30,
                Nationality = Person.PersonNationality.Germany,
                Position = Player.PlayerPosition.CM,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 80,
                GoalKeeper = 55,
                Defence = 78,
                Midfield = 93,
                Attack = 82,
                Diving = 55,
                Handling = 52,
                Tackling = 78,
                Covering = 80,
                LongPassAccuracy = 95,
                ShortPassAccuracy = 95,
                ShotAccuracy = 82,
                Speed = 84,
                Acceleration = 82,
                Reflex = 80,
                Heading = 80,
                ShotPower = 88,
                Technique = 88,
                Endurance = 85,
                Stamina = 100
            };

            Player b9 = new Player()
            {
                TeamId = 3,
                Name = "Eden",
                Surname = "Hazard",
                Age = 29,
                Nationality = Person.PersonNationality.Belgium,
                Position = Player.PlayerPosition.LW,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 80,
                GoalKeeper = 55,
                Defence = 78,
                Midfield = 90,
                Attack = 93,
                Diving = 55,
                Handling = 52,
                Tackling = 73,
                Covering = 75,
                LongPassAccuracy = 88,
                ShortPassAccuracy = 90,
                ShotAccuracy = 88,
                Speed = 93,
                Acceleration = 90,
                Reflex = 85,
                Heading = 80,
                ShotPower = 88,
                Technique = 93,
                Endurance = 90,
                Stamina = 100
            };

            Player b10 = new Player()
            {
                TeamId = 3,
                Name = "Lionel",
                Surname = "Messi",
                Age = 30,
                Nationality = Person.PersonNationality.Wales,
                Position = Player.PlayerPosition.RW,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 80,
                GoalKeeper = 55,
                Defence = 78,
                Midfield = 90,
                Attack = 90,
                Diving = 55,
                Handling = 52,
                Tackling = 73,
                Covering = 75,
                LongPassAccuracy = 88,
                ShortPassAccuracy =95,
                ShotAccuracy = 98,
                Speed = 93,
                Acceleration = 97,
                Reflex = 92,
                Heading = 78,
                ShotPower = 88,
                Technique = 98,
                Endurance = 90,
                Stamina = 100
            };

            Player b11 = new Player()
            {
                TeamId = 3,
                Name = "Karim",
                Surname = "Benzema",
                Age = 30,
                Nationality = Person.PersonNationality.France,
                Position = Player.PlayerPosition.CF,
                LeftFootPlaysSkill = 100,
                RightFootPlaysSkill = 90,
                GoalKeeper = 55,
                Defence = 78,
                Midfield = 70,
                Attack = 70,
                Diving = 55,
                Handling = 52,
                Tackling = 73,
                Covering = 75,
                LongPassAccuracy = 80,
                ShortPassAccuracy = 85,
                ShotAccuracy = 78,
                Speed = 78,
                Acceleration = 70,
                Reflex = 84,
                Heading = 88,
                ShotPower = 75,
                Technique = 70,
                Endurance = 84,
                Stamina = 100
            };

            List<Player> barcelona = new List<Player>();

            barcelona.Add(b1);
            barcelona.Add(b2);
            barcelona.Add(b3);
            barcelona.Add(b4);
            barcelona.Add(b5);
            barcelona.Add(b6);
            barcelona.Add(b7);
            barcelona.Add(b8);
            barcelona.Add(b9);
            barcelona.Add(b10);
            barcelona.Add(b11);

            foreach (var player in barcelona)
            {
                player.SetAverageSkills();
            }

            mockPlayers.Add(barcelona);

        }
    }
}