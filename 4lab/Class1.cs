using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4lab
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    // Абстрактний клас для геометричних фігур
    public abstract class Shape
    {
        public Point Position { get; set; }
        public string Color { get; set; }

        public Shape(Point position, string color)
        {
            Position = position;
            Color = color;
        }

        public abstract void Move(int deltaX, int deltaY);
        public abstract void Resize(int width, int height);
        public abstract void ChangeColor(string newColor);
        public abstract float Rotate(float angle);
    }

    // Клас прямокутника
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(Point position, string color, int width, int height)
            : base(position, color)
        {
            Width = width;
            Height = height;
        }

        public override void Move(int deltaX, int deltaY)
        {
            Position.X += deltaX;
            Position.Y += deltaY;
        }

        public override void Resize(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override void ChangeColor(string newColor)
        {
            Color = newColor;
        }

        public override float Rotate(float angle)
        {
            return angle;
        }
    }

    public class IsoscelesTrapezoid : Shape
    {
        public int TopBase { get; set; }
        public int BottomBase { get; set; }
        public int Height { get; set; }

        public IsoscelesTrapezoid(Point position, string color, int topBase, int bottomBase, int height)
            : base(position, color)
        {
            TopBase = topBase;
            BottomBase = bottomBase;
            Height = height;
        }

        public override void Move(int deltaX, int deltaY)
        {
            Position.X += deltaX;
            Position.Y += deltaY;
        }

        public override void Resize(int topBase, int bottomBase)
        {
            TopBase = topBase;
            BottomBase = bottomBase;
        }

        public override void ChangeColor(string newColor)
        {
            Color = newColor;
        }

        public override float Rotate(float angle)
        {
            return angle;
        }
    }

    public class RectangularTrapezium : Shape
    {
        public int TopBase { get; set; }
        public int BottomBase { get; set; }
        public int Height { get; set; }

        public RectangularTrapezium(Point position, string color, int topBase, int bottomBase, int height)
            : base(position, color)
        {
            TopBase = topBase;
            BottomBase = bottomBase;
            Height = height;
        }

        public override void Move(int deltaX, int deltaY)
        {
            Position.X += deltaX;
            Position.Y += deltaY;
        }

        public override void Resize(int topBase, int bottomBase)
        {
            TopBase = topBase;
            BottomBase = bottomBase;
        }

        public override void ChangeColor(string newColor)
        {
            Color = newColor;
        }

        public override float Rotate(float angle)
        {
            return angle;
        }
    }

}
