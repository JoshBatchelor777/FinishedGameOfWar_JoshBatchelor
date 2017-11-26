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
            p1Label.Text = "0";
            p2Label.Text = "0";
            dealButton.Enabled = false;
            activityLabel.Text = "Welcome to War!\n" + "Press the \"Deal\" button to begin.";
        }


        /* Button Group */


       // Does nothing.
        public bool getp1Win = false;
        public bool getp2Win = false;
        // Play game button
        public void playButton_Click(object sender, EventArgs e)
        {
            // A play button should start the game after cards are dealt.
            activityLabel.Text = "Begin Battle...";
            // Player One whould be Blue, Player 2 should be Red.
            Game game = new Game("Player 1", "Player 2");
            gameResultLabel.Text = game.Play();
            // Print Player's amount of Cards to correct score labels.
            p1Label.Text = game._player1.Cards.Count.ToString();
            p2Label.Text = game._player2.Cards.Count.ToString();
            activityLabel.Text = game.GetResult;
        }

        // Deal cards to players
        // Not being used.
        private void dealButton_Click(object sender, EventArgs e)
        {
            /*
            // Disable the deal button once it is pressed.
            dealButton.Enabled = false;

            // Player One whould be Blue, Player 2 should be Red.
            Game game = new Game("Player 1",  "Player 2");
            gameResultLabel.Text = game.Play();

            p1Label.Text = game._player1.PlayerCards.ToString();
            p2Label.Text = game._player2.PlayerCards.ToString();

            if (dealButton.Enabled == false)
                activityLabel.Text = "Cards have been dealt. \n" +
                 "Press \"Play\" to begin the game.\n"+"Press F1 at any time to reset.";
                 */
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
            activityLabel.Text = result;
            gameResultLabel.Text = result;
            p1Label.Text = result;
            p2Label.Text = result;
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
