namespace ClassLibrary1
{
    public class RainingNumber : IRainingNumber
    {
        public int Number { get; private set; }
        public int Speed { get; private set; }
        public double XPosition { get; private set; }
        public double YPosition { get; private set; }

        public RainingNumber(int number, int speed, double xPosition)
        {

        }

        public void Move()
        {

        }
    }
}