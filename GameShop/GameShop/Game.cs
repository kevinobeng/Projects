using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop
{
    public abstract class Game : IComparable
    {
        // Game is an abstract base class, we inherit Xboxgame and PSGame from this.
        public enum Condition
        {
            poor,
            fair,
            good,
            mint
        };
        protected string console;
        protected string gameTitle;
        protected string gameDev;
        protected Condition condition;
        protected decimal originalPrice;
        protected DateTime releaseDate;

        //constructor
        public Game(string gameTitle, string gameDev,
            Condition condition, decimal originalPrice, DateTime releaseDate)
        {
            this.gameTitle = gameTitle;
            this.gameDev = gameDev;
            this.condition = condition;
            this.originalPrice = originalPrice;
            this.releaseDate = releaseDate;
        }
        public string GameTitle
        {
            get { return gameTitle; }
            set { gameTitle  = value; }
        }

        public string GameDev
        {
            get { return gameDev; }
            set { gameDev = value; }
        }

        public int CalculateApproximateAgeInYears()
        {
            DateTime now = DateTime.Now;
            TimeSpan ageAsTimeSpan = now.Subtract(releaseDate);
            int ageInYears = ageAsTimeSpan.Days / 365; // this will just approximate years not taking into account leap year
            return ageInYears;
        }
        // this method has to be implemented in the derived class
        public abstract decimal CalculateApproximateValue();
        public virtual string Description()
        {
            //get a string describing the current vehicles condition from the names in the Condition enumeration
            // we can get the enumeration name here eg. good or fair as text as opposed to its value
            string conditionName = Enum.GetName(typeof(Condition), condition);
            // build a string describing the current Game

            string description = string.Format("Game Title: {0}{1}Console: {2}{3}Game Developer: {4}{5}" +
                "Condition: {6}{7}Release Date: {8}:{9}Current Value: {10}",
                gameTitle, Environment.NewLine,
                console, Environment.NewLine,
                gameDev, Environment.NewLine,
                conditionName, Environment.NewLine,
                releaseDate, Environment.NewLine,
                CalculateApproximateValue());
            return description;
        }
        // Implement IComparable CompareTo method - Provide default sort order
        // this will be used if we need to sort the vehicles
        int IComparable.CompareTo(object obj)
        {
            //iComparable returns +1, 0 or -1
            Game othergame = (Game)obj;
            decimal differenceInPrice = this.CalculateApproximateValue() - othergame.CalculateApproximateValue();
            // we want to return +1, 0 or -1
            return Math.Sign(differenceInPrice);
        }
    }
}
