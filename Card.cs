namespace ClassCatacombs;

public class Card(CardColor color, CardRank rank)
{
    private CardColor Color { get; set; } = color;
    private CardRank Rank { get; set; } = rank;
    public void DisplayData() => Console.WriteLine($"The {Color} {Rank}");
    
}


public enum CardColor
{
    Blue,
    Red,
    Green,
    Yellow,
    Orange,
    Violet,
    Pink,
    Black,
    White,
}

public enum CardRank
{
   One,
   Two,
   Three,
   Four,
   Five,
   Six,
   Seven,
   Eight,
   Nine,
   Ten,
   Dollar,
   Ampersand,
   Percent,
   Caret
}