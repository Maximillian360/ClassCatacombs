namespace ClassCatacombs;

public class Color
{
    public byte Red {get; set;}
    public byte Green {get; set;}
    public byte Blue {get; set;}

    public Color(byte red, byte green, byte blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }
    
    public static Color CreateBlue() => new Color(0, 0, 255);
    public static Color CreateRed() => new Color(255, 0, 0);
    public static Color CreateGreen() => new Color(0, 255, 0);
    public static Color CreateYellow() => new Color(255, 255, 0);
    public static Color CreateOrange() => new Color(255, 165 , 0);
    public static Color CreateViolet() => new Color(127, 0 , 255);
    public static Color CreateWhite() => new Color(255, 255, 255);
    public static Color CreateBlack () => new Color(0, 0, 0);
    
}