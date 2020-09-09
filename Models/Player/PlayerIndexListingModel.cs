using BowlingData;
using System.Collections.Generic;
namespace DemoWeb.Models.Player
{
    public class PlayerIndexListingModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public double Average { get; set; }
        public List<Ball> Balls { get; set; }
    }
}
