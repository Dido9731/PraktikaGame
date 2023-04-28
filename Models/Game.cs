using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikaGame.Models
{
    public class Game
    {
        public Game()
        {
            Players = new List<Player>();
        }
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime? FinishedOn { get; set; }
    }
}
