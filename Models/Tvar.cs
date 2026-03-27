namespace SVGBlazor.Models
{
    public abstract class Tvar
    {
        public int X { get; set; }

        public int Y { get; set; }

        public string barva { get; set; } = "blue";

            public void Posun(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }
        public abstract void Nakresli();
    }
}
