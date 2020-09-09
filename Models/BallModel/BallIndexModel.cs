using System.Collections.Generic;

namespace DemoWeb.Models.BallModel
{
    public class BallIndexModel
    {
        public IEnumerable<BallIndexListingModel> Balls { get; set; }
        public BallIndexListingModel Ball { get; set; }
    }
}
