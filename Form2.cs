using PraktikaGame.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikaGame
{
    public partial class SecondaryMenu : Form
    {
        Game game { get; set; }
        public SecondaryMenu()
        {
            InitializeComponent();
            game = new Game();
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            game.Players.Add(new Player(usernameTextBox.Text));
            if (usernameTextBox.Text.Length < 30)
            {
                Label player = new Label();
                player.Text = usernameTextBox.Text;
                player.Location = new Point(10, 50 + game.Players.Count() * 30);
                player.AutoSize = true;
                player.Font = new Font("Bold", 18);
                player.Show();
            }
        }
    }
}
