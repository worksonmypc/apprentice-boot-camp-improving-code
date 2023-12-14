using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriviaGame
{
    public class Game
    {
        List<string> playerNames = new List<string>();

        int[] playerBoardPlaces = new int[6];
        int[] playerPurses = new int[6];

        bool[] playerPenaltyBoxes = new bool[6];

        LinkedList<string> popQuestions = new LinkedList<string>();
        LinkedList<string> scienceQuestions = new LinkedList<string>();
        LinkedList<string> sportsQuestions = new LinkedList<string>();
        LinkedList<string> rockQuestions = new LinkedList<string>();

        int currentPlayer = 0;
        bool isGettingOutOfPenaltyBox;

        public Game()
        {
            for (int i = 0; i < 50; i++)
            {
                popQuestions.AddLast("Pop Question " + i);
                scienceQuestions.AddLast(("Science Question " + i));
                sportsQuestions.AddLast(("Sports Question " + i));
                rockQuestions.AddLast(CreateRockQuestion(i));
            }
        }

        public string CreateRockQuestion(int index)
        {
            return "Rock Question " + index;
        }

        public bool IsPlayable()
        {
            return (GetNumberOfPlayers() >= 2);
        }

        public bool AddPlayer(string playerName)
        {


            playerNames.Add(playerName);
            playerBoardPlaces[GetNumberOfPlayers()] = 0;
            playerPurses[GetNumberOfPlayers()] = 0;
            playerPenaltyBoxes[GetNumberOfPlayers()] = false;

            Console.WriteLine(playerName + " was added");
            Console.WriteLine("They are player number " + playerNames.Count);
            return true;
        }

        public int GetNumberOfPlayers()
        {
            return playerNames.Count;
        }

        public void Roll(int roll)
        {
            Console.WriteLine(playerNames[currentPlayer] + " is the current player");
            Console.WriteLine("They have rolled a " + roll);

            if (playerPenaltyBoxes[currentPlayer])
            {
                if (roll % 2 != 0)
                {
                    isGettingOutOfPenaltyBox = true;

                    Console.WriteLine(playerNames[currentPlayer] + " is getting out of the penalty box");
                    playerBoardPlaces[currentPlayer] += roll;
                    if (playerBoardPlaces[currentPlayer] > 11) playerBoardPlaces[currentPlayer] -= 12;

                    Console.WriteLine(playerNames[currentPlayer]
                            + "'s new location is "
                            + playerBoardPlaces[currentPlayer]);
                    Console.WriteLine("The category is " + GetCurrentCategory());
                    AskQuestion();
                }
                else
                {
                    Console.WriteLine(playerNames[currentPlayer] + " is not getting out of the penalty box");
                    isGettingOutOfPenaltyBox = false;
                }

            }
            else
            {

                playerBoardPlaces[currentPlayer] += roll;
                if (playerBoardPlaces[currentPlayer] > 11) playerBoardPlaces[currentPlayer] -= 12;

                Console.WriteLine(playerNames[currentPlayer]
                        + "'s new location is "
                        + playerBoardPlaces[currentPlayer]);
                Console.WriteLine("The category is " + GetCurrentCategory());
                AskQuestion();
            }

        }

        private void AskQuestion()
        {
            if (GetCurrentCategory() == "Pop")
            {
                Console.WriteLine(popQuestions.First());
                popQuestions.RemoveFirst();
            }
            if (GetCurrentCategory() == "Science")
            {
                Console.WriteLine(scienceQuestions.First());
                scienceQuestions.RemoveFirst();
            }
            if (GetCurrentCategory() == "Sports")
            {
                Console.WriteLine(sportsQuestions.First());
                sportsQuestions.RemoveFirst();
            }
            if (GetCurrentCategory() == "Rock")
            {
                Console.WriteLine(rockQuestions.First());
                rockQuestions.RemoveFirst();
            }
        }


        private string GetCurrentCategory()
        {
            switch (playerBoardPlaces[currentPlayer])
            {
                case 0:
                case 4:
                case 8:
                    return "Pop";
                case 1:
                case 5:
                case 9:
                    return "Science";
                case 2:
                case 6:
                case 10:
                    return "Sports";
                default:
                    return "Rock";
            }
        }

        public bool QuestionWasCorrectlyAnswered()
        {
            if (playerPenaltyBoxes[currentPlayer])
            {
                if (isGettingOutOfPenaltyBox)
                {
                    Console.WriteLine("Answer was correct!!!!");
                    playerPurses[currentPlayer]++;
                    Console.WriteLine(playerNames[currentPlayer]
                            + " now has "
                            + playerPurses[currentPlayer]
                            + " Gold Coins.");

                    bool winner = HasCurrentPlayerWon();
                    currentPlayer++;
                    if (currentPlayer == playerNames.Count) currentPlayer = 0;

                    return winner;
                }
                else
                {
                    currentPlayer++;
                    if (currentPlayer == playerNames.Count) currentPlayer = 0;
                    return true;
                }



            }
            else
            {

                Console.WriteLine("Answer was corrent!!!!");
                playerPurses[currentPlayer]++;
                Console.WriteLine(playerNames[currentPlayer]
                        + " now has "
                        + playerPurses[currentPlayer]
                        + " Gold Coins.");

                bool winner = HasCurrentPlayerWon();
                currentPlayer++;
                if (currentPlayer == playerNames.Count) currentPlayer = 0;

                return winner;
            }
        }

        public bool WrongAnswer()
        {
            Console.WriteLine("Question was incorrectly answered");
            Console.WriteLine(playerNames[currentPlayer] + " was sent to the penalty box");
            playerPenaltyBoxes[currentPlayer] = true;

            currentPlayer++;
            if (currentPlayer == playerNames.Count) currentPlayer = 0;
            return true;
        }


        private bool HasCurrentPlayerWon()
        {
            return playerPurses[currentPlayer] != 6;
        }
    }

}