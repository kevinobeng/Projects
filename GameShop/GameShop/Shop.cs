using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop
{
    public class Shop
    {
        // the Shop Class contains a list of Game (PSGame and XboxGame)
        // using polymorphism we inherit from the abstract base class Game
        // and provide a method that differs for the two type to calculate
        // their approximate value based on their age and condition
        private List<Game> gameStock;

        private int gameCurrentlyDisplayed = 0;

        private List<Game> gamesForSale;

        public Shop()
        {
            gameStock = new List<Game>();
        }

        public List<Game> GamesForSale
        {
            get { return gameStock; }
            set { gameStock = value; }
        }
        public int GameCurrentlyDisplayed
        {
            get { return gameCurrentlyDisplayed; }
            set { gameCurrentlyDisplayed = value; }
        }
        public int NumberOfGames
        {
            get { return gameStock.Count; }
        }

        public string DescribeCurrentGame()
        {
            string description;
            // if we have any Games we ask the displayed Game for its description
            if (gameStock.Count > 0)
            {
                description = gameStock[gameCurrentlyDisplayed].Description();
            }
            else
            {
                description = "No games in stock";
            }
            return description;
        }
        public void AddGame(Game game)
        {
            gameStock.Add(game);
        }
        public void RemoveGameAt(int index)
        {
            if (index < gameStock.Count)
            {
                gameStock.RemoveAt(index);
                // make sure gameCurrentlyDisplayed is either zero or pointing at an existing game
                LegalisGameCurrentDisplayed();
            }
        }
        private void LegalisGameCurrentDisplayed()
        {
            if(gameCurrentlyDisplayed > (gameStock.Count - 1))
            {
                gameCurrentlyDisplayed = gameStock.Count - 1; //this will be -1 if stock is zero
                if (gameCurrentlyDisplayed < 0)
                {
                    gameCurrentlyDisplayed = 0; //this should me legal or be zero
                }
            }
        }
        public bool IsPreviousGame()
        {
            if (gameCurrentlyDisplayed > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsNextGame()
        {
            if (gameCurrentlyDisplayed < gameStock.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public  void StepToPreviousGame()
        {
            if (IsPreviousGame())
            {
                gameCurrentlyDisplayed--;
            }
        }
        public void StepToNextGame()
        {
            if (IsNextGame())
            {
                gameCurrentlyDisplayed++;
            }
        }

        public string SearchForGame(int index)
        {
            return gamesForSale[index].GameTitle;
        }
    }
}
