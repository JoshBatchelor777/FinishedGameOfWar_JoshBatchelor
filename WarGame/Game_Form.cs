using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* :____________WAR! Card Game____________:
 * 
 * GAME RULES:
 * 1. Deal random Cards to each player at the start (26 each).
 * 
 * 2. Each round, both players lay a card down. Who ever
 *    places a larger number keeps both cards.
 *    
 * 3. If two cards of the same kind are drawn,
 *    each player places 3 cards down, and a 4th card
 *    face up. The 4th card decides the outcome of that War.
 *    The winner of a given war, takes every card played that round.
 * 
 * VICTORY CONDITIONS:
 * 1. The player with the entire deck (if possible) wins.
 * 
 * 2. The pkayer who won the most instances of War 
 *    (3 times) wins.
 *    
 *    Created by, Josh Batchelor.
 */

namespace WarGame
{
    public partial class Game_Form : Form
    {
        public Game_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

/* Button Group */

        // Play game button
        public void playButton_Click(object sender, EventArgs e)
        {
            // A play button should start the game after cards are dealt.

        }

        // Deal cards to players
        private void dealButton_Click(object sender, EventArgs e)
        {
            // Disable the deal button once it is pressed.
            dealButton.Enabled = false;

            // Player One whould be Blue, Player 2 should be Red.
            Game game = new Game("Player 1", Color.Blue,  "Player 2", Color.Red);


            // This is so I can target precise strings and make them
            // the color I want. 
            // Curretnly Cannot override StringBuidler in Deck Class, I think.
            var find1 = game._player1.Name;
            var find2 = game._player2.NameColor;
                foreach (var found1 in gameResultLabel.Text)
                {
                    //find1 = Color.Blue;
                }
                foreach (var found2 in gameResultLabel.Text)
                {
                    find2 = Color.Red;
                }

           // Color NameColor = Color.FromName("Red");

            gameResultLabel.Text = game.Play();


            p1Label.Text = game._player1.PlayerScore.ToString();
            p2Label.Text = game._player2.PlayerScore.ToString();

            activityLabel.Text += "Cards have been dealt. \n" + "Press \"Play\" to begin the game.";
        }

        // Quit game button
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

/* Menu Strips */
        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Does Nothing
        }

        // New game strip. F1
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // New Game Function: Clears all the labels.
            var result = "";
            p1Label.Text = result;
            p2Label.Text = result;
            gameResultLabel.Text = result;
            activityLabel.Text = result;
        
            result += "";

            // Reset the deal button.
            dealButton.Enabled = true;
        }

        // Some kind of crazy game mode, not yet implemented.
        // F2
        private void dankModeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Quit game strip. Esc
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Show readme strip. F3
        private void openReadmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String readmeFile = @"C:\Users\Student\Desktop\war_game_Readme.txt";
            using (StreamReader rdr = new StreamReader(readmeFile))
            {
                String content = rdr.ReadToEnd();
                readmeLabel.Text = content;
            }

        }
    }
}
