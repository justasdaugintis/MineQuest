
namespace MineQuest
{
    public class Mine 
    {
        public int Health { get; private set; } = 1;

        public bool IsDestroyed => Health < 1;

        public readonly Point _location;

        public void Hit(int factor)
        {
            Health -= factor;
        }

        public Mine (Point location)
        {
            _location = location;
        }

        public int GetCoordinatesX()
        {
            return _location.X;

        }
        public int GetCoordinatesY()
        {
            return _location.Y;

        }
    }
}
