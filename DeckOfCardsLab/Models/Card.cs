namespace DeckOfCardsLab.Models
{
    public class Card
    {
        public string Code { get; set; }
        public string Image {  get; set; }
        public Images Images { get; set; }
        public string Value { get; set; }
        public string Suit { get; set; }

    }
}
