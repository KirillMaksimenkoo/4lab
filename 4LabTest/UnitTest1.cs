using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _4lab;

namespace _4LabTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void CreatePoint()
        {

            Point point = new Point(1,2);
            Assert.AreEqual(1, point.X);
            Assert.AreEqual(2, point.Y);

        }

        [TestMethod]
        public void CreateRectangle()
        {

            Point initialPosition = new Point(1, 2);
            Rectangle rectangle = new Rectangle(initialPosition, "red", 3, 4);
            Assert.AreEqual(1, initialPosition.X);
            Assert.AreEqual(2, initialPosition.Y);
            Assert.AreEqual("red", rectangle.Color);
            Assert.AreEqual(3, rectangle.Width);
            Assert.AreEqual(4, rectangle.Height);

        }

        [TestMethod]
        public void MoveRectangle()
        {
            Point initialPosition = new Point(1, 2);
            Rectangle rectangle = new Rectangle(initialPosition, "red", 1, 2);
            rectangle.Move(3, 4);

            Assert.AreEqual(4, initialPosition.X);
            Assert.AreEqual(6, initialPosition.Y);
        }

        [TestMethod]
        public void ResizeRectangle()
        {
            Point initialPosition = new Point(1, 2);
            Rectangle rectangle = new Rectangle(initialPosition, "red", 3, 4);
            rectangle.Resize(5, 6);

            Assert.AreEqual(5, rectangle.Width);
            Assert.AreEqual(6, rectangle.Height);
        }

        [TestMethod]
        public void ChangeRectangleColor()
        {

            Point initialPosition = new Point(1, 2);
            Rectangle rectangle = new Rectangle(initialPosition, "red", 3, 4);
            rectangle.ChangeColor("black");

            Assert.AreEqual("black", rectangle.Color);

        }

        [TestMethod]
        public void RectangleRotate()
        {
            
            Point initialPosition = new Point(0, 0);
            Rectangle rectangle = new Rectangle(initialPosition, "Red", 10, 5);

            rectangle.Rotate(90);

            Assert.AreEqual(90.0, rectangle.Rotate(90));
        }
    }

    [TestClass]
    public class IsoscelesTrapezoidTest
    {
        [TestMethod]
        public void CreateTrapezoid()
        {
            Point initialPosition = new Point(1, 2);
            IsoscelesTrapezoid trapezoid = new IsoscelesTrapezoid(initialPosition, "red", 3, 2, 4);

            Assert.AreEqual(1, initialPosition.X);
            Assert.AreEqual(2, initialPosition.Y);
            Assert.AreEqual("red", trapezoid.Color);
            Assert.AreEqual(3, trapezoid.TopBase);
            Assert.AreEqual(2, trapezoid.BottomBase);
            Assert.AreEqual(4, trapezoid.Height);
        }

        [TestMethod]
        public void MoveTrapezoid()
        {
            Point initialPosition = new Point(1, 2);
            IsoscelesTrapezoid trapezoid = new IsoscelesTrapezoid(initialPosition, "red", 3, 2, 4);
            trapezoid.Move(3, 4);

            Assert.AreEqual(4, initialPosition.X);
            Assert.AreEqual(6, initialPosition.Y);
        }

        [TestMethod]
        public void ResizeTrapezoid()
        {
            Point initialPosition = new Point(1, 2);
            IsoscelesTrapezoid trapezoid = new IsoscelesTrapezoid(initialPosition, "red", 3, 2, 4);
            trapezoid.Resize(5, 6);

            Assert.AreEqual(5, trapezoid.TopBase);
            Assert.AreEqual(6, trapezoid.BottomBase);
        }

        [TestMethod]
        public void ChangeTrapezoidColor()
        {
            Point initialPosition = new Point(1, 2);
            IsoscelesTrapezoid trapezoid = new IsoscelesTrapezoid(initialPosition, "red", 3, 2, 4);
            trapezoid.ChangeColor("black");

            Assert.AreEqual("black", trapezoid.Color);
        }

        [TestMethod]
        public void TrapezoidRotate()
        {
            Point initialPosition = new Point(0, 0);
            IsoscelesTrapezoid trapezoid = new IsoscelesTrapezoid(initialPosition, "Red", 10, 5, 8);

            Assert.AreEqual(90.0, trapezoid.Rotate(90));
        }
    }

    [TestClass]
    public class RectangularTrapeziumTests
    {
        [TestMethod]
        public void CreateRectangularTrapezium()
        {
            Point initialPosition = new Point(1, 2);
            RectangularTrapezium trapezium = new RectangularTrapezium(initialPosition, "red", 3, 2, 4);

            Assert.AreEqual(1, initialPosition.X);
            Assert.AreEqual(2, initialPosition.Y);
            Assert.AreEqual("red", trapezium.Color);
            Assert.AreEqual(3, trapezium.TopBase);
            Assert.AreEqual(2, trapezium.BottomBase);
            Assert.AreEqual(4, trapezium.Height);
        }

        [TestMethod]
        public void MoveRectangularTrapezium()
        {
            Point initialPosition = new Point(1, 2);
            RectangularTrapezium trapezium = new RectangularTrapezium(initialPosition, "red", 3, 2, 4);
            trapezium.Move(3, 4);

            Assert.AreEqual(4, initialPosition.X);
            Assert.AreEqual(6, initialPosition.Y);
        }

        [TestMethod]
        public void ResizeRectangularTrapezium()
        {
            Point initialPosition = new Point(1, 2);
            RectangularTrapezium trapezium = new RectangularTrapezium(initialPosition, "red", 3, 2, 4);
            trapezium.Resize(5, 6);

            Assert.AreEqual(5, trapezium.TopBase);
            Assert.AreEqual(6, trapezium.BottomBase);
        }

        [TestMethod]
        public void ChangeRectangularTrapeziumColor()
        {
            Point initialPosition = new Point(1, 2);
            RectangularTrapezium trapezium = new RectangularTrapezium(initialPosition, "red", 3, 2, 4);
            trapezium.ChangeColor("black");

            Assert.AreEqual("black", trapezium.Color);
        }

        [TestMethod]
        public void RectangularTrapeziumRotate()
        {

            Point initialPosition = new Point(0, 0);
            RectangularTrapezium trapezium = new RectangularTrapezium(initialPosition, "Red", 10, 5, 8);

            Assert.AreEqual(90.0, trapezium.Rotate(90));
        }
    }
}
