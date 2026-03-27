using static System.Net.WebRequestMethods;

namespace SVGBlazor.Models
{
    public class Kruh : Tvar
    {
        public int Polomer { get; set; } = 20;
        public override string Nakresli()
        {
           return $"<circle r='(Polomer)' cx='(X)' cy='(Y)' fill='(Barva)' stroke='{(Vybrany ? "black" : "none")}' stroke-width='3' />";
        }
    }
}
