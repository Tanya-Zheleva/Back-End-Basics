namespace _10_PointCircleRectangle
{
    public class Rectangle
    {
        public Rectangle(double top, double left, double width, double height)
        {
            this.Top = top;
            this.Left = left;
            this.Width = width;
            this.Height = height;
        }

        public double Top { get; private set; }

        public double Left { get; private set; }

        public double Bottom => this.Top - this.Height;

        public double Right => this.Left + this.Width;

        public double Width { get; private set; }

        public double Height { get; private set; }
    }
}
