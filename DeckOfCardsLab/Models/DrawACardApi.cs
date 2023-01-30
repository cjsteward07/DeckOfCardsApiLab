using Newtonsoft.Json;

namespace DeckOfCardsLab.Models
{
    //[JsonObject(MemberSerialization = MemberSerialization.OptIn)]

    public class DrawACardApi
    {
        //[JsonProperty(PropertyName = "Success")]
        public bool Success { get; set; }
        //[JsonProperty(PropertyName = "Deck_Id")]
        public string Deck_Id { get; set; }
        //[JsonProperty(PropertyName = "Cards")]
        public List<Card> Cards { get; set; }
        //[JsonProperty(PropertyName = "Remaining")]
        public int Remaining { get; set; }


    }
}
