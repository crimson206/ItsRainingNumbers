namespace ClassLibrary1
{
    public class RainingNumber : IRainingNumber
    {
        public int Number { get; private set; }
        public int Speed { get; private set; }
        public double XPosition { get; private set; }
        public double YPosition { get; private set; } = 1;

        public RainingNumber(int number, int speed, double xPosition)
        {
            Number = number;
            Speed = speed;
            XPosition = xPosition;
        }

        public void Move()
        {
            YPosition += Speed;
        }
    }
}