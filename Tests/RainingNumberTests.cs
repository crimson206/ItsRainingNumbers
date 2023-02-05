using ClassLibrary1;

namespace Tests
{
    [TestClass]
    public class RainingNumberTests
    {
        [TestMethod]
        public void InitializeWithNumber()
        {
            int number = 1;
            int speed = 5;
            double xPosition = 40;
            IRainingNumber rainingNumber = new RainingNumber(1, 5, 40);
            Assert.AreEqual(rainingNumber.Number, 1);
        }

        [TestMethod]
        public void InitializeWithSpeed()
        {
            int number = 1;
            int speed = 5;
            double xPosition = 40;
            IRainingNumber rainingNumber = new RainingNumber(1, 5, 40);

            Assert.AreEqual(rainingNumber.Speed, 5);
        }

        [TestMethod]
        public void InitializeWithXPosition()
        {
            int number = 1;
            int speed = 5;
            double xPosition = 40;
            IRainingNumber rainingNumber = new RainingNumber(1, 5, 40);

            Assert.AreEqual(rainingNumber.XPosition, 40);
        }


        [TestMethod]
        public void InitializeWithInitialYPosition1()
        {
            int number = 1;
            int speed = 5;
            double xPosition = 40;
            IRainingNumber rainingNumber = new RainingNumber(1, 5, 40);

            Assert.AreEqual(rainingNumber.YPosition, 1);
        }

        [TestMethod]
        public void MoveBySpeed()
        {
            int number = 1;
            int speed = 5;
            double xPosition = 40;
            IRainingNumber rainingNumber = new RainingNumber(1, 5, 40);

            double[] expectedPositions = new double[] { 6, 11, 16, 21 };

            foreach(double position in expectedPositions)
            {
                rainingNumber.Move();
                Assert.AreEqual(rainingNumber.YPosition, position);
            }
        }
    }
}