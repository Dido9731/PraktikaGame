using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikaGame.Models
{
    public class Player
    {
        public Player(string Nickname)
        {
            this.Nickname = Nickname;
        }
        public string Nickname { get; set; }
        public int PlayerId { get; set; }
        public int Points { get; set; }
        public int Game { get; set; }
    }
}
