using System;
namespace MineQuest
{
    public class Player 
    {
        public bool Play { get; set; } = true;
        public bool Set { get; set; } = true;
        public static readonly Random _random = new Random();
        protected virtual int CloseRange { get; } = 1;
        protected virtual int MidRange { get; } = 2;
        protected virtual int FarRange { get; } = 3;

        public void Fire(int x, int y, Mine mine)
        {
            if (x == mine.GetCoordinatesX() && y == mine.GetCoordinatesY())
            {
                mine.Hit(1);
                Console.WriteLine("You defused an enemy mine !");
                Play = false;
            }
            else
            {
                Console.WriteLine("Nothing found!");
                if(mine._location.InRangeOf(x,y, CloseRange))
                {
                    Console.WriteLine("Enemy mine is VERY close!");
                }
                else if(mine._location.InRangeOf(x, y, MidRange))
                {
                    Console.WriteLine("Enemy mine is close by!");
                }
                else if(mine._location.InRangeOf(x, y, FarRange))
                {
                    Console.WriteLine("Enemy mine is not that far off!");
                }
                else 
                {
                    Console.WriteLine("Dont even bother looking here!");
                }
            }
        }
        public void EnemyFire(Mine mine)
        {
            int shotX = _random.Next(1, 10);
            int shotY = _random.Next(1, 10);

            if(shotX == mine.GetCoordinatesX() && shotY == mine.GetCoordinatesY())
            {
                mine.Hit(1);
                Play = false;
                Console.WriteLine("The enemy defused your mine !");
            }
            else
            {
                Console.WriteLine("Your opponent looked at " + "X: "+ shotX + " and Y:" + shotY + " and did not found anything! ");
            }
        }
    }
}

