namespace SVGBlazor.Models
{
    public class Obdelnik : Tvar
    {
        public int Vyska { get; set; } = 50;
        public int Sirka { get; set; } = 30;


        public override string Nakresli()
        {
            return $"<rect width='{Sirka}' height='{Vyska}' x='{X}' y='{Y}' fill='{barva}' stroke='{(Vybrany ? "black" : "none")}' stroke-width='3' />";
        }
    }
}
