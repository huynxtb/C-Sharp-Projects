using System;

namespace Lab_1_English_Ex1
{

    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public abstract class Shape
    {
        public Point p { get; set; }
        public Point q;
        public Shape(Point p) { this.p = p; }

        public void move(Point q) { this.q = q; }

        public abstract void Show();
    }

    class Line : Shape
    {
        public Line(Point p) : base(p) { }

        public override void Show()
        {
            Console.WriteLine(ToString());
            Console.WriteLine();
        }

        public override string ToString()
        {
            double l = Math.Sqrt(Math.Pow((double)q.x - p.x, 2) + Math.Pow((double)q.y - p.y, 2));
            return "Lines from [{" + p.x + "}:{" + p.y + "}] to [{" + q.x + "}:{" + q.y + "}] with length {" + l.ToString("N2") + "}";
        }
    }

    class Circle : Shape
    {
        public Point q { get; set; }
        public Circle(Point p) : base(p) { }

        public override void Show()
        {
            Console.WriteLine(ToString());
            Console.WriteLine();
        }

        public void move(Point q) { this.q = q; }

        public override string ToString()
        {
            double r = Math.Sqrt(Math.Pow((double)q.x - p.x, 2) + Math.Pow((double)q.y - p.y, 2));
            return "Circle have center at [{" + p.x + "}:{" + p.y + "}] with radius {" + r.ToString("N2") + "}";
        }
    }

    class Rectangle : Shape
    {
        public Point q { get; set; }
        public Point r, v;
        public Rectangle(Point p) : base(p) { }

        public override void Show()
        {


            Console.WriteLine(ToString());
            Console.WriteLine();
        }

        public void move(Point q)
        {
            this.q = q;
            r = new Point(q.x, p.y);
            v = new Point(p.x, q.y);
        }

        public override string ToString()
        {
            double width = r.x - p.x;
            double height = q.y - r.y;
            return "Rectangle 3 point is [{" + p.x + "}:{" + p.y + "}] , [{" + q.x + "}:{" + q.y + "}] , [{" + r.x + "}:{" + r.y + "}] , [{" + v.x + "}:{" + v.y + "}] with the width is {" + width + "} and height is {" + height + "}";
        }
    }

    class PolyLine : Shape
    {
        Point[] list { get; set; }
        public PolyLine(Point p, Point[] list) : base(p) { this.list = list; }

        public override void Show()
        {
            Console.WriteLine(ToString());
            Console.WriteLine();
        }

        public override string ToString()
        {
            String rs = "PolyLine from {" + p.x + ":" + p.y + "}";
            foreach (Point point in list)
            {
                double l = Math.Sqrt(Math.Pow((double)point.x - p.x, 2) + Math.Pow((double)point.y - p.y, 2));
                rs += ", to {" + p.x + ":" + p.y + "}";
                p = point;
            }
            return rs;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape lines = new Line(new Point(0, 0));
            lines.move(new Point(1, 2));
            lines.Show();
            Circle circle = new Circle(new Point(0, 0));
            circle.move(new Point(1, 2));
            circle.Show();
            Rectangle rectangle = new Rectangle(new Point(0, 0));
            rectangle.move(new Point(2, 3));
            rectangle.Show();
            Point[] list = { new Point(1, 2), new Point(2, 1), new Point(1, 0) };
            PolyLine polyLine = new PolyLine(new Point(0, 0), list);
            polyLine.Show();
            Console.ReadKey();
        }
    }
}
