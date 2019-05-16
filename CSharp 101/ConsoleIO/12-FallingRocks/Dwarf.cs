namespace _12_FallingRocks
{
    public class Dwarf
    {
        public int Cx { get; set; }

        public int Cy { get; set; }

        public int LeftArm => this.Cx - 1;

        public int RightArm => this.Cx + 1;
    }
}
