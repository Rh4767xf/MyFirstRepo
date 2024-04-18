using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
    internal class Player
    {
        // Attributes
        private string name;
        private int score;
        private int livesLeft;
        private int gold;
        private string weapon;

        // Getter and Setter
        public Player(string name)
        {
            this.name = name;
        }
        public Player(string name, int startingLives)
        {
            this.name = name;
            livesLeft = startingLives;
        }
        public int GetScore()
        {
            return score;
        }
        public int GetLivesLeft()
        {
            return livesLeft;
        }
        public int GetGold()
        {
            return gold;
        }
        public string GetWeapon()
        {
            return weapon;
        }

        public void AddPoints(int totalPoints)
        {
            score += totalPoints;
        }

        public void AddGold(int totalGold)
        {
            gold += totalGold;
        }
        public void EquipWeapon(string newWeapon)
        {
            weapon = newWeapon;
        }
        public void Kill()
        {
            // We make sure they can't get negative lives.
            if (livesLeft > 0)
            {
                livesLeft--;

            }
        }
    } // End class
} // End main
