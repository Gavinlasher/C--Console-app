namespace RockPaperScissors
{
  class Program
  {

    static void Main(string[] args)
    {
      Random random = new Random();
      bool playAgain = true;
      string? player;
      string? computer;
      string? answer;

      while (playAgain)
      {
        player = "";
        computer = "";
        answer = "";
        while (player != "rock" && player != "paper" && player != "scissors")
        {

          Console.Write("Enter rock ,paper, scissors:");
          player = Console.ReadLine()?.ToLower();
        }
        switch (random.Next(1, 3))
        {
          case 1:
            computer = "rock";
            break;
          case 2:
            computer = "paper";
            break;
          case 3:
            computer = "scissors";
            break;

        }
        Console.WriteLine("Player:" + player);
        Console.WriteLine("Computer:" + computer);
        switch (player)
        {
          case "rock":
            if (computer == "rock")
            {
              Console.WriteLine("tie");
            }
            else if (computer == "paper")
            {
              Console.WriteLine("you lose");
            }
            else
            {
              Console.WriteLine("you win!");
            }
            break;
          case "paper":
            if (computer == "paper")
            {
              Console.WriteLine("tie");
            }
            else if (computer == "scissors")
            {
              Console.WriteLine("you lose");
            }
            else
            {

              Console.WriteLine("you win!");
            }
            break;
          case "scissors":
            if (computer == "scissors")
            {
              Console.WriteLine("tie");
            }
            else if (computer == "rock")
            {
              Console.WriteLine("you lose!");
            }
            else
            {

              Console.WriteLine("you win!");
            }
            break;
        }
        Console.Write("Do you want to Play again (y/n)");
        answer = Console.ReadLine()?.ToLower();
        if (answer == "y")
        {
          playAgain = true;
        }
        else if (answer == "n")
        {
          playAgain = false;
        }
        Console.ReadKey();
      }
    }
  }
}
