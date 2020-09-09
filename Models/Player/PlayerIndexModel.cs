using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWeb.Models.Player
{
    public class PlayerIndexModel
    {
        public IEnumerable<PlayerIndexListingModel> Players { get; set; }
    }
}
