public class Card
{
    public string Suit;
    public string Rank;

    public Card(string Suit, string Rank)
    {
        this.Suit = Suit;
        this.Rank = Rank;
    }
    
    public string GetName()
    {
        return this.Suit == "Joker" ? $"{this.Rank} {this.Suit}": $"{this.Rank} of {this.Suit}";
    }
}