using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Flurl.Http;
using DeckOfCardsLab.Models;
using Newtonsoft;

namespace DeckOfCardsLab.Controllers
{
    public class CardController : Controller
    {
        public IActionResult DrawCards()
        {
            string uri = "https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";
            var apiDeckTask = uri.GetJsonAsync<BrandNewDeckApi>();
            apiDeckTask.Wait();
            BrandNewDeckApi deck = apiDeckTask.Result;

            uri = $"https://deckofcardsapi.com/api/deck/{deck.Deck_id}/draw/?count=5";
            var apiDrawTask = uri.GetJsonAsync<DrawACardApi>();
            apiDrawTask.Wait();
            DrawACardApi cards = apiDrawTask.Result;
            return View(cards.Cards);
        }
    }
}
