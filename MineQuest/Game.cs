using System;
namespace MineQuest
{
    public class Game
    {
        public static void Main()
        {
            //Global objects
            Board board = new Board(10, 10);
            Player player = new Player();
            Random _random = new Random();
            var MyMineX = 0;
            var MyMineY = 0;
            Mine YourMine = new Mine(new Point(MyMineX, MyMineY));
            Mine EnemyMine = new Mine(new Point(_random.Next(1, 10), _random.Next(1, 10)));
            //
                    Console.WriteLine("Welcome to Mine Quest");
                    Console.WriteLine("The game consists for a 10/10 grid.");

                    Console.WriteLine("Place your mine at coordinates between " +
                                          "1 and 10 in both x and y dimensions.");
            while (player.Set)
            {
                try
                {
                    Console.WriteLine("Your mine X coordinate: ");
                    MyMineX = int.Parse(Console.ReadLine());

                    Console.WriteLine("Your mine Y  coordinate: ");
                    MyMineY = int.Parse(Console.ReadLine());
                    if(MyMineX <= 10 && MyMineY <= 10 && MyMineX > 0 &&MyMineY > 0)
                    {
                        Console.WriteLine("Your mine is at: " + " X " + MyMineX + " Y " + MyMineY);

                    }
                    else
                    {
                        Console.Write("Error ! Your mine can only exist inside of 10/10 grid." +
                                      " Choose values that are between 1 and 10. ");
                        continue;
                    }

                    player.Set = false;
                }
                catch(FormatException)
                {
                    Console.Write("Error ! Your mine can only exist inside of 10/10 grid. " +
                                  "Choose values that are between 1 and 10." ) ;
                    continue;
                }

            }
              

            while (player.Play)
            {

                try
                {

                    Console.WriteLine("Check at x: ");
                    int fireX = int.Parse(Console.ReadLine());

                    if (fireX <= 10)
                    {
                        Console.WriteLine("Check at y: ");
                        int fireY = int.Parse(Console.ReadLine());

                        if (fireY <= 10)
                        {
                            player.Fire(fireX, fireY, EnemyMine);
                        }
                        else
                        {
                            Console.Write("Wrong input ! Only values of 1 to 10 are accepted. ");
                            continue;
                        }
                    }
                    else
                    {
                       
                        Console.Write("Wrong input ! Only values of 1 to 10 are accepted. ");
                        continue;
                    }
                    if (player.Play)
                    {
                        player.EnemyFire(YourMine);
                    }

                }
                catch (FormatException)
                {
                            Console.WriteLine("Wrong input ! Only values of 1 to 10 are accepted. ");
                    continue;
                }
            
            }
        }
    }
}
