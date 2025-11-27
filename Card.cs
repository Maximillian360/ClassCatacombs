namespace ClassCatacombs;

public class Card
{
    private CardRank Rank { get; set; }
    private CardColor Color { get; set; }

    public Card(CardColor color, CardRank rank)
    {
        Rank = rank;
        Color = color;
    }

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