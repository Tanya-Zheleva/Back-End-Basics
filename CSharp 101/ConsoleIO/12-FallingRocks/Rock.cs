namespace _12_FallingRocks
{
    public class Rock
    {
        public int X { get; set; }

        public int Y { get; set; }

        public char Symbol { get; set; }

        public int Size { get; set; }

        public int LeftEnd => this.X - this.Size / 2; 

        public int RightEnd => this.X + this.Size / 2;
    }
}
