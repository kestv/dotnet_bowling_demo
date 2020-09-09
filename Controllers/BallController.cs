using System.Linq;
using BowlingData;
using DemoWeb.Models.BallModel;
using Microsoft.AspNetCore.Mvc;

namespace DemoWeb.Controllers
{
    public class BallController : Controller
    {
        IBall ballService;
        public BallController(IBall ballService)
        {
            this.ballService = ballService;
        }

        public IActionResult Index()
        {
            var ballModels = ballService.GetBalls();

            var listingResult = ballModels.Select(result => new BallIndexListingModel
            {
                Id = result.ID,
                Name = result.Name,
                Size = result.Size
            });

            var model = new BallIndexModel()
            {
                Balls = listingResult
            };

            return View(model);
        }

        public ActionResult Detail(int id)
        {
            var ball = ballService.Get(id);

            var model = new BallDetailModel()
            {
                Name = ball.Name,
                Size = ball.Size
            };

            return View(model);
        }
    }
}
