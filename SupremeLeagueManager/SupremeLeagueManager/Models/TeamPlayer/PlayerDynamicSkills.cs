using SupremeLeagueManager.Models.Global_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.GlobalModels
{
    public class PlayerDynamicSkills
    {
        private Player Player;
        private int currentPosition;
        private int formation;
        private double dynamicSkills;

        public PlayerDynamicSkills(Player Player, int currentPosition, int formation)
        {
            this.Player = Player;
            this.currentPosition = currentPosition;
            this.formation = formation;

            Menu();
        }

        public double GetDynamicSkills()
        {
            return dynamicSkills;
        }

        public void Formation442()
        {
            if (currentPosition < 11)
            {
                switch (currentPosition)
                {
                    case 0:
                        Player.Position = Player.PlayerPosition.GK;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 1:
                        Player.Position = Player.PlayerPosition.LB;
                        dynamicSkills = PlayerSkills.Compute(Player) * Player.LeftFootSkills * 0.01;
                        break;
                    case 2:
                    case 3:
                        Player.Position = Player.PlayerPosition.CB;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 4:
                        Player.Position = Player.PlayerPosition.RB;
                        dynamicSkills = PlayerSkills.Compute(Player) * Player.RightFootSkills * 0.01;
                        break;
                    case 5:
                        Player.Position = Player.PlayerPosition.LM;
                        dynamicSkills = PlayerSkills.Compute(Player) * Player.RightFootSkills * 0.01;
                        break;
                    case 6:
                        Player.Position = Player.PlayerPosition.DM;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 7:
                        Player.Position = Player.PlayerPosition.CM;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 8:
                        Player.Position = Player.PlayerPosition.RM;
                        dynamicSkills = PlayerSkills.Compute(Player) * Player.RightFootSkills * 0.01;
                        break;
                    case 9:
                        Player.Position = Player.PlayerPosition.CF;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 10:
                        Player.Position = Player.PlayerPosition.CF;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                }
            }
        }

        public void Formation433()
        {
            if (currentPosition < 11)
            {
                switch (currentPosition)
                {
                    case 0:
                        Player.Position = Player.PlayerPosition.GK;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 1:
                        Player.Position = Player.PlayerPosition.LB;
                        dynamicSkills = PlayerSkills.Compute(Player) * Player.LeftFootSkills * 0.01;
                        break;
                    case 2:
                    case 3:
                        Player.Position = Player.PlayerPosition.CB;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 4:
                        Player.Position = Player.PlayerPosition.RB;
                        dynamicSkills = PlayerSkills.Compute(Player) * Player.RightFootSkills * 0.01;
                        break;
                    case 5:
                        Player.Position = Player.PlayerPosition.CM;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 6:
                        Player.Position = Player.PlayerPosition.DM;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 7:
                        Player.Position = Player.PlayerPosition.CM;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 8:
                        Player.Position = Player.PlayerPosition.LW;
                        dynamicSkills = PlayerSkills.Compute(Player) * Player.LeftFootSkills * 0.01;
                        break;
                    case 9:
                        Player.Position = Player.PlayerPosition.CF;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 10:
                        Player.Position = Player.PlayerPosition.RW;
                        dynamicSkills = PlayerSkills.Compute(Player) * Player.RightFootSkills * 0.01;
                        break;
                }
            }
        }

        public void Formation451()
        {
            if (currentPosition < 11)
            {
                switch (currentPosition)
                {
                    case 0:
                        Player.Position = Player.PlayerPosition.GK;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 1:
                        Player.Position = Player.PlayerPosition.LB;
                        dynamicSkills = PlayerSkills.Compute(Player) * Player.LeftFootSkills * 0.01;
                        break;
                    case 2:
                    case 3:
                        Player.Position = Player.PlayerPosition.CB;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 4:
                        Player.Position = Player.PlayerPosition.RB;
                        dynamicSkills = PlayerSkills.Compute(Player) * Player.RightFootSkills * 0.01;
                        break;
                    case 5:
                        Player.Position = Player.PlayerPosition.DM;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 6:
                        Player.Position = Player.PlayerPosition.DM;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 7:
                        Player.Position = Player.PlayerPosition.LM;
                        dynamicSkills = PlayerSkills.Compute(Player) * Player.LeftFootSkills * 0.01;
                        break;
                    case 8:
                        Player.Position = Player.PlayerPosition.AM;
                        dynamicSkills = PlayerSkills.Compute(Player) ;
                        break;
                    case 9:
                        Player.Position = Player.PlayerPosition.RM;
                        dynamicSkills = PlayerSkills.Compute(Player) * Player.RightFootSkills * (0.01);
                        break;
                    case 10:
                        Player.Position = Player.PlayerPosition.CF;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                }
            }
        }

        public void Formation352()
        {
            if (currentPosition < 11)
            {
                switch (currentPosition)
                {
                    case 0:
                        Player.Position = Player.PlayerPosition.GK;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 1: 
                    case 2:
                    case 3:
                        Player.Position = Player.PlayerPosition.CB;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 4:
                    case 5:
                        Player.Position = Player.PlayerPosition.DM;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 6:
                        Player.Position = Player.PlayerPosition.LM;
                        dynamicSkills = PlayerSkills.Compute(Player) * Player.LeftFootSkills * 0.01;
                        break;
                    case 7:
                        Player.Position = Player.PlayerPosition.AM;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 8:
                        Player.Position = Player.PlayerPosition.RM;
                        dynamicSkills = PlayerSkills.Compute(Player) * Player.RightFootSkills * 0.01;
                        break;
                    case 9:
                        Player.Position = Player.PlayerPosition.CF;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                    case 10:
                        Player.Position = Player.PlayerPosition.CF;
                        dynamicSkills = PlayerSkills.Compute(Player);
                        break;
                }
            }
        }

        private void Menu()
        {
            switch (formation)
            {
                case 1:
                    Formation442();
                    break;
                case 2:
                    Formation433();
                    break;
                case 3:
                    Formation451();
                    break;
                case 4:
                    Formation352();
                    break;
            }
        }
    }
}