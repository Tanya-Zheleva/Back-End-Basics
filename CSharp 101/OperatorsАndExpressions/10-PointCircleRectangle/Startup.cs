namespace _10_PointCircleRectangle
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            Circle circle = new Circle(1, 1, 1.5);
            Rectangle rect = new Rectangle(1, -1, 6, 2);

            bool isInCircle = (x - circle.Cx) * (x - circle.Cx) + (y - circle.Cy) * (y - circle.Cy) <= circle.R * circle.R;
            bool isInRect = (x >= rect.Left && x <= rect.Right) && (y >= rect.Bottom && y <= rect.Top);

            if (isInCircle)
            {
                if (isInRect)
                {
                    Console.WriteLine("inside circle inside rectangle");
                }
                else
                {
                    Console.WriteLine("inside circle outside rectangle");
                }
            }
            else
            {
                if (isInRect)
                {
                    Console.WriteLine("outside circle inside rectangle");
                }
                else
                {
                    Console.WriteLine("outside circle outside rectangle");
                }
            }
        }
    }
}
