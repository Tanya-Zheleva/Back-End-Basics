namespace _10_PointCircleRectangle
{
    public class Circle
    {
        public Circle(double cx, double cy, double r)
        {
            this.Cx = cx;
            this.Cy = cy;
            this.R = r;
        }

        public double Cx { get; private set; }

        public double Cy { get; private set; }

        public double R { get; private set; }
    }
}
