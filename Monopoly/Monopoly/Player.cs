using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Player
    {
        // Attributes
        private string name;
        private int position = 0;
        private bool is_in_jail = false;
        private int rounds_in_jail = 0;
        private string pseudo;
        private int distance=0; 

        public string Name { get => name; set => name = value; }
        public string Pseudo { get => pseudo; set => pseudo = value; }
        public int Position { get => position; set => position = value; }
        public bool Is_in_jail { get => is_in_jail; set => is_in_jail = value; }
        public int Rounds_in_jail { get => rounds_in_jail; set => rounds_in_jail = value; }
        public int Distance { get => distance; set => distance = value; }

        // Constructor
        public Player(string name, string pseudo)
        {
            this.name = name;
            this.pseudo = pseudo;
        }

        /// <summary>
        /// Moves the player on board by modifying its position and its travelled distance appropriately.
        /// The movement of the player is based on the total of the dices thrown.
        /// </summary>
        /// <param name="dices_sum">
        /// Results of the dices' sum from the class Dices thrown by the player.
        /// </param>
        public void Move(int dices_sum)
        {
            // Clean user display (color changing + System.Sleep to mimic the real dice throwing and pawn moving)
            Console.Write("Previous position: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Square " + this.position);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Moving pawn...");
            System.Threading.Thread.Sleep(1000);

            this.position += dices_sum;
            this.distance += dices_sum;
            if (this.position > 39) { this.position -= 40; }
            switch (this.position)
            {
                case 10:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Square 10");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(": Welcome to jail ! But keep calm, you are only visiting.");
                    break;
                case 30:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Square 30");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(": You've just walked on the go to jail square... See you there");
                    this.is_in_jail = true;
                    this.rounds_in_jail = 0;
                    this.position = 10;
                    break;
                default:
                    Console.Write("You now stand on ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Square " + this.position);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        /// <summary>
        /// Gathers the player's name and pseudo for the welcome screen or to announce the winner.
        /// </summary>
        /// <returns>
        /// String describing the player in order to be displayed.
        /// </returns>
        public string toString()
        {
            return "Player " + this.name + " also called The " + this.pseudo +".";
        }
    }
}
