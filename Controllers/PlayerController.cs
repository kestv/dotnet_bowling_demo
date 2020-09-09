using System.Linq;
using BowlingData;
using DemoWeb.Models.Player;
using Microsoft.AspNetCore.Mvc;

namespace DemoWeb.Controllers
{
    public class PlayerController : Controller
    {
        IPlayer playerService;
        public PlayerController(IPlayer playerService)
        {
            this.playerService = playerService;
        }

        public IActionResult Index()
        {
            var playerModels = playerService.GetPlayers();

            var listingResult = playerModels.Select(result => new PlayerIndexListingModel
            {
                Id = result.ID,
                Name = result.FirstName + " " + result.LastName,
                Phone = result.PhoneNumber,
                Average = result.Average,
                Balls = result.Balls
            });

            var model = new PlayerIndexModel()
            {
                Players = listingResult
            };

            return View(model);
        }
    }
}
